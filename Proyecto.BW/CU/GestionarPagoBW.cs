using Proyecto.BC.Modelos;
using Proyecto.BW.Interfaces.BW;
using Proyecto.BW.Interfaces.SG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BW.CU
{
    public class GestionarPagoBW : IGestionarPagoBW
    {

        private readonly IGestionarPagoSG gestionarPagoDA;

        public GestionarPagoBW(IGestionarPagoSG gestionarPagoDA)
        {
            this.gestionarPagoDA = gestionarPagoDA;
        }

        public async Task<bool> direcionaPago(Pago pago)
        {
            return await gestionarPagoDA.direcionaPago(pago);
        }
    }
}
