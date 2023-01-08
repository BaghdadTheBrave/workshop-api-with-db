using Microsoft.AspNetCore.Mvc;
using workshop.Contracts.Client;
using workshop.Contracts.Order;
using worksop.Models;
using workshop.Data;



namespace workshop.Controlers
{

    [ApiController]
    public class WorkshopController:ControllerBase
    {
        [HttpPost("/Client")]
        public IActionResult AddClient(AddClientRequest request)
        {
            workshopContext context = new workshopContext();


            var dateWTime = new DateTime(request.date_of_birth.Year, request.date_of_birth.Month, request.date_of_birth.Day,0,0,0);
            var client = new Client()
            {
                IdClients = Guid.NewGuid().GetHashCode(),
                SurnameClients = request.surname,
                NameClients = request.name,
                PatronymicClients = request.patronymic,
                SettlmentClients = request.settlment,
                FlatClients = request.flat, 
                StreetClients = request.street,
                HouseClients = request.house,
                
                DateOfBirth = dateWTime,
                Phone = request.phone
            };
            context.Add(client);
            context.SaveChanges();
            var response = new ClientResponse(
                client.IdClients,
                client.SurnameClients,
                client.NameClients,
                client.PatronymicClients,
                client.SettlmentClients,
                client.FlatClients,
                client.StreetClients,
                client.HouseClients,
                client.Phone 

                );
            return Ok(response);
        }

        [HttpGet("/Client/{id:int}")]
        public IActionResult GetClient(int id)
        {
            workshopContext context = new workshopContext();
            var clients = from c in context.Clients
                          where c.IdClients == id
                          select c;
            var client = clients.FirstOrDefault();
            if (client != null)
            {
                var date = DateOnly.FromDateTime((DateTime)client.DateOfBirth);
                var response = new ClientResponse(
                client.IdClients,
                client.SurnameClients,
                client.NameClients,
                client.PatronymicClients,
                client.SettlmentClients,
                client.FlatClients,
                client.StreetClients,
                client.HouseClients,
                client.Phone

                );
                return Ok(response);
            }


            return BadRequest(id);
        }

        [HttpPut("/Client/{id:int}")]
        public IActionResult UpsertClient(int id, UpsertClientRequest request)
        {
            workshopContext context = new workshopContext();
            var result = context.Clients.SingleOrDefault(c => c.IdClients == id);
            if (result != null)
            {
                result.SurnameClients = request.surname;
                result.NameClients = request.name;
                result.PatronymicClients = request.patronymic;
                result.SettlmentClients = request.settlment;
                result.FlatClients = request.flat;  
                result.StreetClients = request.street;
                result.HouseClients = request.house;
               
                result.Phone = request.phone; 


            }
            return Ok(request);
        }

        [HttpGet("/Craftsman/{id:int}")]
        public IActionResult GetCraftsman(int id)
        {
            return Ok(id);
        }


        [HttpGet("/Order/{id:int}")]
        public IActionResult ShowOrder(int id)
        {
            return Ok(id);
        }

        [HttpPost("/Order")]
        public IActionResult AddOrder(AddOrderRequest request)
        {
            return Ok(request);
        }

        [HttpGet("/Product/{id:int}")]
        public IActionResult ShowProduct(int id) 
        {
            return Ok(id);
        }

        

    }
}
