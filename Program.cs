using Mediccont.Infraestrutura;
using Mediccont.Models;

var builder = WebApplication.CreateBuilder(args);

//react - uso de cors
builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAllOrigins",
            builder =>
            {
                builder.AllowAnyOrigin() 
                       .AllowAnyMethod() 
                       .AllowAnyHeader();
            });
    });

// Add services to the container.
builder.Services.AddControllers();

/*
//swagger as debbuging device
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();*/

builder.Services.AddTransient<ITarefaRepository, TarefaRepository>();


// Configure the HTTP request pipeline. 
//swagger as debbuging device
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
*/

var app = builder.Build();
app.UseHttpsRedirection();

app.UseRouting();
app.UseCors("AllowAllOrigins");//DB


app.UseAuthorization();

app.MapControllers();

app.Run();

