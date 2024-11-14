using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoCaixa.Application.ViewModel
{
    public class FlowTypeViewModel
    {
        [Required]
        [DisplayName("Price")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Valor { get; set; }
    }
}
