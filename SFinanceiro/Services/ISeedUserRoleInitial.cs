namespace SFinanceiro.Services
{
    public interface ISeedUserRoleInitial
    {
        Task SeedRolesAsync();

        Task SeedUsersAsync();
    }
}
