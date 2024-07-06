namespace Proyecto.api.DTOs
{
    public class PagoDTO
    {
        public string Pan { get; set; }
        public string ExpiryDate { get; set; }
        public string Cvv { get; set; }
        public decimal Amount { get; set; }
        public string IdentifyCommerce { get; set; }
        public string IdentifyTerminal { get; set; }
    }
}
