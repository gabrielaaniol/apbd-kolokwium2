using kolos2.Data;
using kolos2.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ITree, Tree>();

var app = builder.Build();

app.UseAuthorization();           
app.MapControllers();            
app.Run();                        