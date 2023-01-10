using Microsoft.AspNetCore.Mvc;
using workshop.Contracts.Client;
using workshop.Contracts.Order;
using worksop.Models;
using workshop.Data;
using workshop.Contracts.Craftsmen;
using workshop.Contracts.Product;

namespace workshop.Controlers
{

    [ApiController]
    public class WorkshopController:ControllerBase
    {
        [HttpPost("/Client")]
        public IActionResult AddClient(AddClientRequest request)
        {
            workshopContext context = new workshopContext();


            var dateWTime = new DateTime(request.year, request.month, request.day,0,0,0);
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
                request.year,
                request.month,
                request.day,
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
                date.Year,
                date.Month,
                date.Day,
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
            var dateWTime = new DateTime(request.year, request.month, request.day, 0, 0, 0);
            var updatedClient = context.Clients.SingleOrDefault(c => c.IdClients == id);
            if (updatedClient != null)
            {
                updatedClient.SurnameClients = request.surname;
                updatedClient.NameClients = request.name;
                updatedClient.PatronymicClients = request.patronymic;
                updatedClient.SettlmentClients = request.settlment;
                updatedClient.FlatClients = request.flat;  
                updatedClient.StreetClients = request.street;
                updatedClient.HouseClients = request.house;
                updatedClient.DateOfBirth = dateWTime;
                updatedClient.Phone = request.phone;


            }
            context.SaveChanges();
            return Ok(request);
        }

        [HttpGet("/Craftsman/{id:int}")]
        public IActionResult GetCraftsman(int id)
        {
            workshopContext context = new workshopContext();
            var craftsmen = from c in context.Craftsmen
                          where c.IdCraftsmen == id
                          select c;
            var craftsman = craftsmen.FirstOrDefault();
            if (craftsman != null)
            {
                var response = new CraftsmenResponse(
                craftsman.IdCraftsmen,
                craftsman.SurnameCraftsmen,
                craftsman.NameCraftsmen,
                craftsman.PatronymicCraftsmen,
                craftsman.RankCraftsmen,
                craftsman.ExpCraftsmen,
                craftsman.RatingCraftsmen,
                craftsman.Phone

                );
                return Ok(response);
            }


            return BadRequest(id);
        }


        [HttpGet("/Order/{id:int}")]
        public IActionResult ShowOrder(int id)
        {
            workshopContext context = new workshopContext();
            var result = from o in context.Orders
                         where o.IdOrders == id
                         join c in context.Clients on o.IdclntOrders equals c.IdClients
                         join p in context.Products on o.IdProductOrders equals p.IdProducts
                        select new
                        {
                            id = o.IdOrders,
                            idClient = c.IdClients,
                            nameClient = c.NameClients,
                            idProduct = p.IdProducts,
                            nameProduct = p.NameProducts,
                            year = o.StartDateOrders.Value.Year,
                            month = o.StartDateOrders.Value.Month,
                            day = o.StartDateOrders.Value.Day,
                        };
            var order = result.FirstOrDefault();
            if (order != null)
            {
                var response = new OrderResponse(
                    order.id,
                    order.idClient,
                    order.nameClient,
                    order.idProduct,
                    order.nameProduct,
                    order.year,
                    order.month,
                    order.day
                    );
                return Ok(response);
            }

            return BadRequest(id);
        }

        [HttpPost("/Order")]
        public IActionResult AddOrder(AddOrderRequest request)
        {
            workshopContext context = new workshopContext();
            var date = DateTime.Now;
            var order = new Order()
            {
                IdOrders = Guid.NewGuid().GetHashCode(),
                IdProductOrders = request.idProduct,
                IdclntOrders = request.idClient
            };
            context.Add(order);
            context.SaveChanges();
            var response = ShowOrder(order.IdOrders);
            return Ok(response);
        }

        [HttpGet("/Product/{id:int}")]
        public IActionResult ShowProduct(int id) 
        {

            
            workshopContext context = new workshopContext();
            var result = from pr in context.Products
                         where pr.IdProducts == id
                         join w in context.WorkSurs on pr.IdWorkSurProducts equals w.IdWorkSurs
                         join s in context.Shapes on w.IdShapeWorkSurs equals s.IdShapes
                         join st in context.Steels on w.IdSteelWorkSurs equals st.IdSteel
                         join f in context.Furnitures on pr.IdFurnitureProducts equals f.IdFurnitures
                         join sh in context.Sheaths on pr.IdSheathProducts equals sh.IdSheaths
                         join cr in context.Craftsmen on pr.IdCrftsmnProducts equals cr.IdCraftsmen
                         join t in context.Typesses on pr.IdTypeProducts equals t.IdTypess
                         join l in context.Locks on pr.IdLockProducts equals l.IdLocks
                         select new
                         {
                             id = pr.IdProducts,
                             name = pr.NameProducts,
                             weight= pr.WeightProducts,
                             length = pr.LengthProducts,
                             lenWorkSur = w.LengthWorkSurs,
                             angle = w.AngleWorkSurs,
                             shape = s.NameShapes,
                             steel = st.NameSteel,
                             furniture = f.MaterialFurnitures,
                             sheath = sh.IdSheaths,
                             idCraftsman = cr.IdCraftsmen,
                             nameCraftsman = cr.NameCraftsmen,
                             type = t.NameTypess,
                             lockName = l.NameLocks
                         };
            var p  = result.FirstOrDefault();
            if (p != null)
            {
                var response = new ProductResponse(
                    p.id,
                    p.name,
                    p.weight.GetValueOrDefault(),
                    p.length.GetValueOrDefault(),
                    p.lenWorkSur.GetValueOrDefault(),
                    p.angle.GetValueOrDefault(),
                    p.shape,
                    p.steel,
                    p.furniture,
                    p.sheath.ToString(),
                    p.idCraftsman,
                    p.nameCraftsman,
                    p.type,
                    p.lockName
                    );
                return Ok(response);
            }

            return BadRequest(id);
            
        }

        

    }
}
