#region configuration

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCountries();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#endregion

app.MapGet("/countries", (ICountriesService service) =>
{
    return service.GetAll();
})
.WithName("GetCountries");

app.MapGet("/countries/{code}", (ICountriesService service, string code) =>
{
    return service.FindByCode(code);
})
.WithName("GetCountryByCode");


app.Run();