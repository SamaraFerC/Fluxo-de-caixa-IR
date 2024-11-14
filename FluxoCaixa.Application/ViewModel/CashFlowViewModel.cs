using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class CashFlowViewModel
    {
        public int? Id { get; set; }

        public int FlowTypeId { get; set; }
        public string FlowName { get; set; }

        public int ActivityId { get; set; }

        public string ActivityName { get; set; }

        public int CollaboratorId { get; set; }

        public string CollaboratorName { get; set; }

        public int PaymentTypeId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Price")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Valor { get; set; }

        public bool? Status { get; set; }
        public string? UserIncluded { get; set; }
        public DateTime? DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
