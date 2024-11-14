using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class FlowTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Situação")]
        public bool Status { get; set; }
        public string? UserIncluded { get; set; }
        public DateTime? DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
