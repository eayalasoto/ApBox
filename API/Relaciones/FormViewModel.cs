
using API.Models.Facturas;
using API.Models.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Relaciones
{
    public class FormViewModel
    {
        public virtual ComplementosPagosModel complementoPago { get; set;}

        public virtual FacturaEmitidaXmlModel facturaEmitidaXml { get; set; }
    }
}
