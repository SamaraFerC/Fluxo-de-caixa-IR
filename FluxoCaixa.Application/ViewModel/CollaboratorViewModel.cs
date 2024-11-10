using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class CollaboratorViewModel
    {
        [Display(Name = "CPF/CNPJ")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string FullName { get; set; }

        [Display(Name = "Situação")]
        public bool Status { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime? DateBirth { get; set; }

        public int AddressID { get; set; }
        public int CollaboratorTypeID { get; set; }

        public string? UserIncluded { get; set; }
        public DateTime? DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}