using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Baldin.SebEJ.Autotrack.DataAccess.Models;

namespace Baldin.SebEJ.Autotrack.DataAccess
{
    public class InMemoryBusTracker : IDataAccess
    {
        //private List<PositionMessage> _positions = new List<PositionMessage>();
        private List<DoorMessage> _messages = new List<DoorMessage>();

        public async Task<IEnumerable<DoorMessage>> GetLastBusesStatusAsync()
        {
            var data = from message in _messages
                       orderby message.BusCode, message.Timestamp
                       group message by message.BusCode into mexGroup
                       select mexGroup.Last();
            return data;
        }

        public async Task<IEnumerable<DoorMessage>> GetLastBusesStatusAsync(params string[] busIds)
        {
            return await GetLastBusesStatusAsync(busIds.AsEnumerable());
        }

        public async Task<IEnumerable<DoorMessage>> GetLastBusesStatusAsync(IEnumerable<string> busIds)
        {
            var data = from message in _messages
                       where busIds.Any(y => y == message.BusCode)
                       orderby message.BusCode, message.Timestamp
                       group message by message.BusCode into mexGroup
                       select mexGroup.Last();
            return data;
        }

        public async Task<DoorMessage> GetLastBusStatusAsync(string busId)
        {
            var data = from message in _messages
                       where busId == message.BusCode
                       orderby message.Timestamp
                       select message;
            return data.LastOrDefault();
        }

        public async Task<bool> InsertBulkBusStatusesAsync(IEnumerable<DoorMessage> doorMex)
        {
            _messages.AddRange(doorMex);
            return true;
        }

        public async Task<bool> InsertBusStatusAsync(DoorMessage doorMex)
        {
            _messages.Add(doorMex);
            return true;
        }
    }
}
