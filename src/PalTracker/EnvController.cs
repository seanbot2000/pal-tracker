using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("env")]
    public class EnvController : Controller
    {
        private readonly CloudFoundryInfo _cloudFoundryInfo;

        public EnvController(CloudFoundryInfo cloudFoundryInfo)
        {
            _cloudFoundryInfo = cloudFoundryInfo;
        }

        [HttpGet]
        public CloudFoundryInfo Get()
        {
            return _cloudFoundryInfo;
        }
    }
}