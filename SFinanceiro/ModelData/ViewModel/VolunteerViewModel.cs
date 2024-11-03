using System.ComponentModel.DataAnnotations;

namespace SFinanceiro.ModelData.ViewModel
{
    public class VolunteerViewModel
    {
        [Display(Name = "CPF/CNPJ")]
        public int VolunteerId { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
