using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/factorial/{nbr:int}", (int nbr) => {
    long factorial = 1;
    for (int i = 2; i <= nbr; i++) {
        factorial *= i;
    }
    return Results.Ok(factorial);
});

app.MapGet("/modulo/{nbr1:int}/{nbr2:int}", (int nbr1, int nbr2) => {
    long modulo = nbr1 - (nbr1 / nbr2) * nbr2;
    return Results.Ok(modulo);
});

app.MapGet("/tip/{bill:decimal}/{tip:int}", (decimal bill, decimal tip) => {
    decimal totaltip = bill * (tip/100);

    return Results.Ok(totaltip);
});
app.Run("http://localhost:5000");

