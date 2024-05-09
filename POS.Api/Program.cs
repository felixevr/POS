using POS.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration; // Definido por mi

// Add services to the container.
builder.Services.AddInjectionInfrastructure(Configuration); // Definido por mi
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ------------------------- METODO CONEXI�N A DB -------------------------------
//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//    if (!optionsBuilder.IsConfigured)
//    {
//        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. 
//        //You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148.
//        //For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        optionsBuilder.UseSqlServer("Server=DESKTOP-2799MO7\\MSSQLSERVERDEV;Database=POS;Trusted_Connection=True;");
//    }
//}
//--------------------------------------------------------------------------------

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