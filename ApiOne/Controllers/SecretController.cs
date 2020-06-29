using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApiOne.Controllers
{
    public class SecretController : Controller
    {
        [Route("/secret")]
        [Authorize]
        public string Index()
        {
            string claims = "";

            foreach (var item in User.Claims)
            {
                claims += item.Type + " " + item.Value;
            }

            return "secret message from ApiOne\r\n\r\n" +  claims;
        }
    }
}
