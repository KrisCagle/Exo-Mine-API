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
}

List<governor> governors = new List<governor>();
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
        new governor()
        {
            Id = 2,
            Name = "Katrina Bahringer",
            colonyId = 2,
            status = true
        };
        new governor()
        {
            Id = 3,
            Name = "Lola Wolff",
            colonyId = 3,
            status = true
        };
        new governor()
        {
            Id = 4,
            Name = "Damon Hartman",
            colonyId = 1,
            status = true
        };
    }

List<colony> colonies = new List <colony>();
{
    new colony()
    {
        Id = 1, 
        Name = "Earth"};
    new colony()
    {
        Id = 1, 
        Name = "Mars"};
    new colony()
    {
        Id = 1, 
        Name = "Europa"};
}

List<mineral> minerals = new List <mineral>();
{
        new mineral()
        {
            Id = 1,
            name = "Iron"
        };
        new mineral()
        {
            Id = 2,
            name = "Chromium"
        };
        new mineral()
        {
            Id = 3,
            name = "Sodium"
        };
        new mineral()
        {
            Id = 4,
            name = "Molybdenum"
        };
    
}

List<facilities> facilities = new List<facilities>();
{
        new facilities()
        {
            Id = 1,
            Name = "Ganymede",
            status = true
        };
        new facilities()
        {
            Id = 2,
            Name = "Io",
            status = true
        };
        new facilities()
        {
            Id = 3,
            Name = "Titan",
            status = true
        };    
}

 List<colonyMinerals> colonyMinerals = new List<colonyMinerals>();
{
         new colonyMinerals()
         {
             Id = 1,
             colonyId = 2,
             mineralId = 4,
             quantity = 7
         };
         new colonyMinerals()
         {
             Id = 2,
             colonyId = 2,
             mineralId = 1,
             quantity = 3
         };
         new colonyMinerals()
         {
             Id = 3,
             colonyId = 2,
             mineralId = 2,
             quantity = 5
         };
         new colonyMinerals()
         {
             Id = 4,
             colonyId = 2,
             mineralId = 3,
             quantity = 4
         };
         new colonyMinerals()
         {
             Id = 5,
             colonyId = 1,
             mineralId = 1,
             quantity = 21
         };
         new colonyMinerals()
         {
             Id = 6,
             colonyId = 1,
             mineralId = 2,
             quantity = 10
         };
         new colonyMinerals()
         {
             Id = 7,
             colonyId = 1,
             mineralId = 3,
             quantity = 12
         };
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