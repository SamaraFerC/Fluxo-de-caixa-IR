using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class ActivityViewModel
    {
        [Display(Name = "Nome")]
        [MaxLength(50)]
        public required string Name { get; set; }

        [MaxLength(100)]
        [Display(Name = "Descrição")]
        public required string Description { get; set; }

        [Display(Name = "Situação")]
        public required bool Status { get; set; }
    }
}