using API.Operaciones.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Relaciones
{
    [Table("rel_xml_facturas_emitidas")]
    public class FacturaEmitidaXml
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? IdFe { get; set; }
        [ForeignKey("IdFe")]
        public virtual FacturaEmitida FacturaEmitida { get; set; }

        [DisplayName("Folio Fiscal")]
        public String Uuid { get; set; }

        [DisplayName("Archivo")]
        public byte[] ArchivoFisicoXml { get; set; }

    }
}
