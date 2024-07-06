using Proyecto.api.DTOs;
using Proyecto.BC.Modelos;

namespace Proyecto.api.Utilitarios
{
    public class MapperPagos
    {

        public static Pago MapperAPago(PagoDTO pagoDTO) {



            return new Pago()
            {
                Amount = pagoDTO.Amount.ToString(),
                Cvv = pagoDTO.Cvv,
                ExpiryDate = pagoDTO.ExpiryDate,
                IdentifyCommerce = pagoDTO.IdentifyCommerce,
                IdentifyTerminal = pagoDTO.IdentifyTerminal,
                Pan = pagoDTO.Pan

            };
        }
    }
}
