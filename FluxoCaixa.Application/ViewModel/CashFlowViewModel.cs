using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class CashFlowViewModel
    {
        public int? Id { get; set; }


        [Required]
        [Display(Name = "Movimentação")]
        public int FlowTypeId { get; set; }

        [Required]
        [Display(Name = "Nome movimentacao")]
        [MaxLength(50)]
        public string FlowName { get; set; }

        [Required]
        [Display(Name = "Tipo Atividade")]
        public int ActivityId { get; set; }

        public string ActivityName { get; set; }


        [Required]
        [Display(Name = "Colaborador")]
        public int CollaboratorId { get; set; }


        [Required]
        [Display(Name = "Nome")]
        [MaxLength(50)]
        public string CollaboratorName { get; set; }

        public int PaymentTypeId { get; set; }

        [Display(Name = "Tipo de Colaborador")]
        public int CollaboratorTypeID { get;set; }

        [Required]
        [Display(Name = "Nome")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Valor")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Value { get; set; }

        public bool? Status { get; set; }
        public string? UserIncluded { get; set; }
        public DateTime? DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
