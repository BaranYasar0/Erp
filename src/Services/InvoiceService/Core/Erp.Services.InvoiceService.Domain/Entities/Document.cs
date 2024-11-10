using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Services.InvoiceService.Domain.Entities
{
    internal class Document:BaseEntity<Guid>
    {
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentExplanation { get; set; }

        #region SmartEnums

        #endregion

        #region Relations
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        #endregion

    }
}
