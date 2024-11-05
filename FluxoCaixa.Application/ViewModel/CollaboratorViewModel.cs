using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Infra.Data.ViewModel
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