using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using SalesManagment.Application.Interactor;
using SalesManagment.Application.Interactor.interfaces;
using SalesManagment.Context.Data;
using SalesManagment.Context.Persistence;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Context.Repository;
using SalesManagment.Context.Repository.interfaces;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var assembly = Assembly.Load("SalesManagment.Application");

string strConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(strConnection);
});

//Dependence

builder.Services.AddScoped<IRegionsIbgeInteractor, RegionsIbgeInteractor>(); 
builder.Services.AddScoped<IAttendanceRepository, AttendanceRepository>(); 
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>(); 
builder.Services.AddScoped<IMicroRegionRepository, MicroRegionRepository>(); 
builder.Services.AddScoped<IRegionRepository, SalesManagment.Context.Persistence.RegionRepository>(); 
builder.Services.AddScoped<ISellerRegionRepository, SellerRegionRepository>();   
builder.Services.AddScoped<ISellerRepository, SellerRepository>();   
builder.Services.AddScoped<ISearchByZipCodeInteractor, SearchByZipCodeInteractor>();   
builder.Services.AddTransient<IRepository<T>, Repository<T>>();
builder.Services.AddValidatorsFromAssembly(assembly);
builder.Services.AddMediatR(assembly);


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
