using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models.User;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class AuthController(IAuthService authService) : ApiController
{
    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUserModel request)
    {
        var result = await authService.LoginAsync(request);
        if (result == null)
        {
            return Unauthorized(new { message = "Sai tài khoản hoặc mật khẩu" });
        }
        return Ok(result);
    }
}
