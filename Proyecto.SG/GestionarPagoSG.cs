using Proyecto.BC.Constantes;
using Proyecto.BC.Modelos;
using Proyecto.BW.Interfaces.SG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto.SG
{
    public class GestionarPagoSG : IGestionarPagoSG
    {

        private readonly HttpClient clienteHttp;

        public GestionarPagoSG(HttpClient clienteHttp)
        {
            this.clienteHttp = clienteHttp;
        }
        public async Task<bool> direcionaPago(Pago pago)
        {
            // Serializar el objeto user a JSON
            try
            {
                var jsonContent = new StringContent(JsonSerializer.Serialize(pago), System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage respuesta = await clienteHttp.PostAsync(URLAdquirienciaConstante.URL, jsonContent);

                if (!respuesta.IsSuccessStatusCode)
                    throw new HttpRequestException($"Error en {URLAdquirienciaConstante.URL} al obtener el mensaje");
                  // return false;

                string contenido = await respuesta.Content.ReadAsStringAsync();

                // Imprimir el contenido de la respuesta
                Console.WriteLine("Contenido de la respuesta:");
                Console.WriteLine(contenido);

                // Deserializar la respuesta a un booleano
                ResponsePago resultado = JsonSerializer.Deserialize<ResponsePago>(contenido);


                if (resultado.responseAuthCode=="0") return true;
                return false;
            } catch (Exception ex)
            {

                return false;
            }
        }
    }
}
