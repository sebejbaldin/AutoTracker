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
    [Route("api/v1/track/busgps")]
    [ApiController]
    public class BusPositionV1Controller : ControllerBase
    {
        private IDataAccess _dataAccess;

        public BusPositionV1Controller(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<DoorMessage> GetLastBusStatus(string busId)
        {
            return await _dataAccess.GetLastBusStatusAsync(busId);
        }

        [HttpGet]
        public async Task<IEnumerable<DoorMessage>> GetLastBusesStatus(IEnumerable<string> busIds)
        {
            return await _dataAccess.GetLastBusesStatusAsync(busIds);
        }

        [HttpGet("all", Name = "GetAllBusesPos")]
        public async Task<IEnumerable<PositionMessage>> GetLastBusesPosition()
        {
            return await _dataAccess.GetLastBusesStatusAsync();
        }
    }
}