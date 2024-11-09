using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class ActivityViewModel
    {
        public ActivityViewModel(string name, string description, bool status)
        {
            Name = name;
            Description = description;
            Status = status;
        }

        [Display(Name = "Nome")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Situação")]
        public bool Status { get; set; }
    }
}