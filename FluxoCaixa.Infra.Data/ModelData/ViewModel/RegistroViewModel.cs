using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Infra.Data.ModelData.ViewModel
{
    public class RegistroViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email{ get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password",ErrorMessage ="Senha Incorreta")]
        public string? ConfirmPassword { get; set; }
    }
}