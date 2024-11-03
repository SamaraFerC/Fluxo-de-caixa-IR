using System.ComponentModel.DataAnnotations;

namespace SFinanceiro.ModelData.ViewModel
{
    public class CollaboratorViewModel
    {
        [Display(Name = "CPF/CNPJ")]
        public int CollaboratorId { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Situação")]
        public bool Status { get; set; }
    }
}
