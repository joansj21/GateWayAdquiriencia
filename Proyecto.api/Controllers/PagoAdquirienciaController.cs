using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.api.DTOs;
using Proyecto.api.Utilitarios;
using Proyecto.BW.Interfaces.BW;

namespace Proyecto.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoAdquirienciaController : ControllerBase
    {
        private readonly IGestionarPagoBW gestionarPagoBW;
        public PagoAdquirienciaController(IGestionarPagoBW gestionarPagoBW)
        {
            this.gestionarPagoBW = gestionarPagoBW;
        }



        [HttpPost]

            public async Task<IActionResult> RegistrarCompra(PagoDTO pago)
        {
           

            try
            {
                var exito = await gestionarPagoBW.direcionaPago( MapperPagos.MapperAPago(pago));

                if (exito)
                {
                    return Ok(true);
                }
                else
                {
                    return BadRequest(false);
                }
            }
            catch (Exception ex)
            {
                // Aquí podrías hacer un registro de errores o manejar la excepción según tu aplicación
                return StatusCode(500, new { message = $"Error interno del servidor: {ex.Message}" });
            }
        }



    }
}
