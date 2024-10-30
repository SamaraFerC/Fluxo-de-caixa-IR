using System.ComponentModel.DataAnnotations;
namespace SFinanceiro.ModelData.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        public string Password { get; set; }

        public Usuario() { }
    }
}