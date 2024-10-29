namespace SFinanceiro.ModelData.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Usuario() { }
    }
}