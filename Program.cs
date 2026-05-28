List<facilityMineral> facilityMinerals = new List <facilityMineral>();
{
new facilityMineral()
    {
        Id = 1,
        facilityId = 1,
        mineralId = 1,
        quantity = 307
    };
new facilityMineral()
    {
        Id = 2,
        facilityId = 1,
        mineralId = 2,
        quantity = 0
    };
    new facilityMineral()
    {
        Id = 3,
        facilityId = 2,
        mineralId = 4,
        quantity = 647
    };
    new facilityMineral()
    {
        Id = 4,
        facilityId = 3,
        mineralId = 3,
        quantity = 868
    };
new List<governor> governors = new List<governor>();
    {
        new governor()
        {
            Id = 1,
            Name = "Patricia Purdy",
            colonyId = 1,
            status = true
        };
        new governor()
        {
            Id = 1,
            Name = "Patricia Purdy",
            colonyId = 1,
            status = true
        };
    }



}
List<colony> colonies = new List <colony>();
{
new colony(){Id = 1, Name = "Earth"};
new colony(){Id = 1, Name = "Mars"};
new colony(){Id = 1, Name = "Europa"};
}


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();