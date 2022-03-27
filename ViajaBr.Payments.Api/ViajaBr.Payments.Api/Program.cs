using ViajaBr.Payments.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/api/payments", () =>
{
    var payment = new Payments(
        new List<Payment>()
        {
            new (PaymentMethod.Pix, "MercadoPago"),
            new (PaymentMethod.Transfer, "SafetyPay")
        });

    return payment;
});

app.Run();

