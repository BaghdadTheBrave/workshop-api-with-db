using Microsoft.OpenApi.Models;
using System.Reflection;
using workshop.Data;



var builder = WebApplication.CreateBuilder(args);
{

    builder.Services.AddControllers();
    builder.Services.AddSwaggerGen(c => 
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "workshop", Version = "v1" });
    });

}
var app = builder.Build();
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "workshop v1"));
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();

}
