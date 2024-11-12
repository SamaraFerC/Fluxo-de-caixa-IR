using FluxoCaixa.Application.Vallidation;
using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class CollaboratorViewModel
    {
        [Required]
        [MaxLength(18)]
        [Display(Name = "CPF/CNPJ")]
        [CpfCnpj(ErrorMessage = "O CPF/CNPJ é inválido.")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Situação")]
        public bool Status { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? DateBirth { get; set; }

        public AddressViewModel? addressVM { get; set; }
        public CollaboratorTypeViewModel? CollaboratorTypeVM { get; set; }

        public int AddressID { get; set; }

        [Display(Name = "Tipo de Colaborador")]
        public int CollaboratorTypeID { get; set; }

        public string? UserIncluded { get; set; }
        public DateTime? DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}