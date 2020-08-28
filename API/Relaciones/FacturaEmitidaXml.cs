using API.Operaciones.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Relaciones
{
    [Table("REL_XML_FACTURAS_EMITIDAS")]
    public class FacturaEmitidaXml
    {
        public int IdRfe { get; set; }
        [ForeignKey("IdRfe")]

        public virtual FacturaEmitida FacturaEmitida { get; set; }

        [DisplayName("Folio Fiscal")]
        public String Uuid { get; set; }

        [DisplayName("Archivo")]
        public byte[] ArchivoFisicoXml { get; set; }

    }
}
