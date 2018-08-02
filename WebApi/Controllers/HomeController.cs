using System.Web.Http;

namespace WebApi.Controllers
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "Hello Web API";
        }
    }
}