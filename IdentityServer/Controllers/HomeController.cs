using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIdentityServerInteractionService identity;

        public HomeController(IIdentityServerInteractionService identity)
        {
            this.identity = identity;
        }

        public async Task<IActionResult> error(string errorId)
        {
            var errormessage = await identity.GetErrorContextAsync(errorId);

            return Ok(errormessage);
        }
    }
}