using eshop.Application.Services;
using eshop.DataAccess;
using eshop.DataAccess.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<IUserService, UserService>();

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddDbContext<EshopDbContext>(option => option.UseSqlServer(connectionString));



builder.Services.AddCors(option => option.AddPolicy("allow", builder =>
{
    /*
     * http://www.halkbank.com.tr
     * https://www.halkbank.com.tr
     * https://api.halkbank.com.tr
     * https://www.halkbank.com.tr:8282
     * 
     * 
     *  http://www.halkbank.com.tr/krediler
     * 
     */
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
}));


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BU CUMLE COK GIZLI")),
                        ValidIssuer = "identity.halkbak.com",
                        ValidAudience = "hr.halkbank",
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("allow");


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
