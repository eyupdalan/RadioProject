using System.Web.Http;

namespace RadyoAPI.Controllers
{
    public class TestController : ApiController
    {
        public object Get()
        {

            return new { data="Awake" };
        }
    }
}
