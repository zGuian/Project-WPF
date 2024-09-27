using Register.Desktop.Infra.CrossCutting.IOC.Services;
using Register.Desktop.Infra.CrossCutting.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServicesInjection(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware(typeof(GlobalErrorHandlingMiddleware));
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
