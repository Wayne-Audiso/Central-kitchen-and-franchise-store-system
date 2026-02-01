using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class UsersController(IUserService userService) : ApiController
{
}
