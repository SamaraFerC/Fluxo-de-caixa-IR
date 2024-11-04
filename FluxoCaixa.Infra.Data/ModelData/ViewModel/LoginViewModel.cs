using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Infra.Data.ModelData.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage ="Campo Email é obrigátorio")]
        [EmailAddress(ErrorMessage ="Email inválido")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Campo Senha é obrigatória")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [Display(Name = "Lembrar-me")]
        public bool RememberMe{ get; set; }
    }
}
