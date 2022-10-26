using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace PetServices.Authorization
{
    public class AuthorizationStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsIdentity();

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(user)));
        }
    }
}
