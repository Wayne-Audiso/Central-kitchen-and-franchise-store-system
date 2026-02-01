using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using N_Tier.Application.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Services
{
    public interface IAuthService
    {
        Task<LoginResponseModel> LoginAsync(LoginUserModel request);
    }
}
