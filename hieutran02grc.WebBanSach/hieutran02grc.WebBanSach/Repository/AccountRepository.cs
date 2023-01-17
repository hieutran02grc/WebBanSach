using hieutran02grc.WebBanSach.Models;
using Microsoft.AspNetCore.Identity;

namespace hieutran02grc.WebBanSach.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> ConfirmEmailAsync(string uid, string token)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel)
        {
            throw new NotImplementedException();
        }

        public Task GenerateEmailConfirmationTokenAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task GenerateForgotPasswordTokenAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> PasswordSignInAsync(SignInModel signInModel)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
