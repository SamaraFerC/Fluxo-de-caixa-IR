using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Application.ViewModel
{
    public class AddressViewModel
    {
        [Display(Name = "Endereço")]
        [MaxLength(100)]
        public string? Street { get; set; }

        [Display(Name = "CEP")]
        [MaxLength(20)]
        public string? CEP { get; set; }

        [Display(Name = "Cidade")]
        [MaxLength(100)]
        public string? City { get; set; }

        [Display(Name = "Estado")]
        [MaxLength(100)]
        public string? State { get; set; }

        public bool? Status { get; set; }
        public string? UserIncluded { get; set; }
        public DateTime? DateIncluded { get; set; }
        public string? UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
