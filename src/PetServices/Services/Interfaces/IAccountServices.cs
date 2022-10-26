using PetModels.Models;

namespace PetServices.Services.Interfaces
{
    public interface IAccountServices
    {
        Task CreateAsync(Account account);

        Task UpdateAsync(Account account);

        Task DeleteAsync(Account account);

        Task DisableAsync(Account account);

        Task ResetPasswordAsync(Account account);

        Task ConfirmAccount(Account account);

        Task<IEnumerable<Account>> GetAccountsByNameAsync(string name);

        Task<Account> GetAccountByEmailAsync(string email);

        Task<Account> GetAccountById(Guid id);
    }
}
