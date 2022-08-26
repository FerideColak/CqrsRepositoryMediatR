using MediatR;
using CqrsRepositoryMediatR.Repositories;
using AutoMapper;
using CqrsRepositoryMediatR.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddControllers();

var config = new MapperConfiguration(conf =>
{
    conf.AddProfile<MappingProfile>();
});
builder.Services.AddScoped(s => config.CreateMapper());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
