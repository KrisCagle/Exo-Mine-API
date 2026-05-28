using examineAPI.Models;
using examineAPI.Models.DTOs;
List<FacilityMineral> facilityMinerals = new()
{
    new FacilityMineral()
        {
            Id = 1,
            FacilityId = 1,
            MineralId = 1,
            Quantity = 307
        },
    new FacilityMineral()
        {
            Id = 2,
            FacilityId = 1,
            MineralId = 2,
            Quantity = 0
        },
    new FacilityMineral()
        {
            Id = 3,
            FacilityId = 2,
            MineralId = 4,
            Quantity = 647
        },
    new FacilityMineral()
        {
            Id = 4,
            FacilityId = 3,
            MineralId = 3,
            Quantity = 868
        }
};

List<Governor> governors = new()
    {
        new Governor()
        {
            Id = 1,
            Name = "Patricia Purdy",
            ColonyId = 1,
            Status = true
        },
        new Governor()
        {
            Id = 2,
            Name = "Katrina Bahringer",
            ColonyId = 2,
            Status = true
        },
        new Governor()
        {
            Id = 3,
            Name = "Lola Wolff",
            ColonyId = 3,
            Status = true
        },
        new Governor()
        {
            Id = 4,
            Name = "Damon Hartman",
            ColonyId = 1,
            Status = true
        }
    };

List<Colony> colonies = new()
{
    new Colony()
    {
        Id = 1, 
        Name = "Earth"
    },
    new Colony()
    {
        Id = 1, 
        Name = "Mars"
    },
    new Colony()
    {
        Id = 1, 
        Name = "Europa"
    }
};

List<Mineral> minerals = new()
{
        new Mineral()
        {
            Id = 1,
            Name = "Iron"
        },
        new Mineral()
        {
            Id = 2,
            Name = "Chromium"
        },
        new Mineral()
        {
            Id = 3,
            Name = "Sodium"
        },
        new Mineral()
        {
            Id = 4,
            Name = "Molybdenum"
        }
    
};

List<Facilities> facilities = new()
{
        new Facilities()
        {
            Id = 1,
            Name = "Ganymede",
            Status = true
        },
        new Facilities()
        {
            Id = 2,
            Name = "Io",
            Status = true
        },        
        new Facilities()
        {
            Id = 3,
            Name = "Titan",
            Status = true
        },    
};

 List<ColonyMinerals> colonyMinerals = new()
{
         new ColonyMinerals()
         {
             Id = 1,
             ColonyId = 2,
             MineralId = 4,
             Quantity = 7
         },
         new ColonyMinerals()
         {
             Id = 2,
             ColonyId = 2,
             MineralId = 1,
             Quantity = 3
         },
         new ColonyMinerals()
         {
             Id = 3,
             ColonyId = 2,
             MineralId = 2,
             Quantity = 5
         },
         new ColonyMinerals()
         {
             Id = 4,
             ColonyId = 2,
             MineralId = 3,
             Quantity = 4
         },
         new ColonyMinerals()
         {
             Id = 5,
             ColonyId = 1,
             MineralId = 1,
             Quantity = 21
         },
         new ColonyMinerals()
         {
             Id = 6,
             ColonyId = 1,
             MineralId = 2,
             Quantity = 10
         },
         new ColonyMinerals()
         {
             Id = 7,
             ColonyId = 1,
             MineralId = 3,
             Quantity = 12
         }
};

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

app.MapGet("api/colonyMinerals", () =>
{
    return colonyMinerals.Select(cm => new ColonyMineralsDTO
    {
        Id = cm.Id,
        ColonyId = cm.ColonyId,
        MineralId = cm.MineralId,
        Quantity = cm.Quantity 

    });
});

app.MapPut("/api/colonyMinerals/{id}", (int id, ColonyMineralsDTO updatedMineral) =>
{
    ColonyMinerals colonyMineral = colonyMinerals.FirstOrDefault(cm => cm.Id == id);
    if (colonyMineral == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(new ColonyMineralsDTO
    {
        Id = colonyMineral.Id,
        ColonyId = colonyMineral.ColonyId,
        MineralId = colonyMineral.MineralId,
        Quantity = colonyMineral.Quantity
    });
});



app.Run();