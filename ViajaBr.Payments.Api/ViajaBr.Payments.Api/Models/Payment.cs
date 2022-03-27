namespace ViajaBr.Payments.Api.Models
{
    public record Payment (PaymentMethod PaymentMethod, string Supplier, List<string> Banks = null);
}