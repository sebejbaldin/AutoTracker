using Baldin.SebEJ.Autotrack.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Baldin.SebEJ.Autotrack.DataAccess
{
    public interface IDataAccess
    {
        //bool InsertGPSData(PositionMessage gpsPos);

        //bool InsertDoor(DoorMessage doorMex);

        //bool InsertBulkGPSData(IEnumerable<PositionMessage> gpsPos);

        //bool InsertBulkDoor(IEnumerable<DoorMessage> doorMex);

        //PositionMessage GetLastBusPosition(int busId);

        //IEnumerable<PositionMessage> GetLastBusesPosition();

        //IEnumerable<PositionMessage> GetLastBusesPositions(params int[] busIds);

        //IEnumerable<PositionMessage> GetLastBusesPositions(IEnumerable<int> busIds);

        //DoorMessage GetLastBusStatus(int busId);

        //IEnumerable<DoorMessage> GetLastBusesStatus();

        //IEnumerable<DoorMessage> GetLastBusesStatus(params int[] busIds);

        //IEnumerable<DoorMessage> GetLastBusesStatus(IEnumerable<int> busIds);

        //Task<bool> InsertGPSDataAsync(PositionMessage gpsPos);

        Task<bool> InsertBusStatusAsync(DoorMessage doorMex);

        //Task<bool> InsertBulkGPSDataAsync(IEnumerable<PositionMessage> gpsPos);

        Task<bool> InsertBulkBusStatusesAsync(IEnumerable<DoorMessage> doorMex);

        //Task<PositionMessage> GetLastBusPositionAsync(int busId);

        //Task<IEnumerable<PositionMessage>> GetLastBusesPositionAsync();

        //Task<IEnumerable<PositionMessage>> GetLastBusesPositionsAsync(params int[] busIds);

        //Task<IEnumerable<PositionMessage>> GetLastBusesPositionsAsync(IEnumerable<int> busIds);

        Task<DoorMessage> GetLastBusStatusAsync(string busId);

        Task<IEnumerable<DoorMessage>> GetLastBusesStatusAsync();

        Task<IEnumerable<DoorMessage>> GetLastBusesStatusAsync(params string[] busIds);

        Task<IEnumerable<DoorMessage>> GetLastBusesStatusAsync(IEnumerable<string> busIds);
    }
}
