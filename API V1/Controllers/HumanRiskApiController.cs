using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using API_V1.DTO;

namespace API_V1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HumanRiskApiController : ControllerBase
    {
        private readonly RiskObjectService objectService;
        private readonly IConfiguration configuration;
        public HumanRiskApiController(IConfiguration _configuration)
        {
           configuration = _configuration;
           objectService = new RiskObjectService();
        }
       

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(objectService.GetAll());
        }

        [HttpPost]
        public JsonResult Post(RiskObjectDTO riskObject)
        {
            return new JsonResult(objectService.Create(riskObject.Title, riskObject.Description));
        }

       [HttpPost]
       [Route("Update")]
       public void Update(int id,RiskObjectDTO riskObject)
        {
            objectService.Update(id, riskObject.Title, riskObject.Description);
        }

        [HttpPost]
        [Route("Delete")]
        public void Delete(int id)
        {
            objectService.Delete(id);
        }
    }
}
