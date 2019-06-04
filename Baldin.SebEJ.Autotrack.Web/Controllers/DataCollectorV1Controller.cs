using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Baldin.SebEJ.Autotrack.DataAccess;
using Baldin.SebEJ.Autotrack.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Baldin.SebEJ.Autotrack.Web.Controllers
{
    [Route("api/v1/track/collector")]
    [ApiController]
    public class DataCollectorV1Controller : ControllerBase
    {
        private IDataAccess _dataAccess;

        public DataCollectorV1Controller(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpPost(Name = "AddBusStatus")]
        public async Task<StatusCodeResult> InsertBusStatus(DoorMessage door)
        {
            return (await _dataAccess.InsertBusStatusAsync(door)) ? (StatusCodeResult)Ok() : (StatusCodeResult)BadRequest();
        }

        [HttpPost("bulk", Name = "AddBulkBusStatus")]
        public async Task<StatusCodeResult> InsertBulkBusStatuses(IEnumerable<DoorMessage> doors)
        {
            return (await _dataAccess.InsertBulkBusStatusesAsync(doors)) ? (StatusCodeResult)Ok() : (StatusCodeResult)BadRequest();
        }
    }
}