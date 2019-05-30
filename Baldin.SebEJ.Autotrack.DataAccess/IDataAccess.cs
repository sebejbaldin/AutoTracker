using Baldin.SebEJ.Autotrack.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baldin.SebEJ.Autotrack.DataAccess
{
    public interface IDataAccess
    {
        bool InsertGPSData(PositionMessage gpsPos);

        bool InsertDoor(DoorMessage doorMex);

        PositionMessage GetLastBusPosition(int busId);

        IEnumerable<PositionMessage> GetLastBusesPosition();

        IEnumerable<PositionMessage> GetLastBusesPositions(params int[] busIds);

        IEnumerable<PositionMessage> GetLastBusesPositions(IEnumerable<int> busIds);

        DoorMessage GetLastBusStatus(int busId);

        IEnumerable<DoorMessage> GetLastBusesStatus();

        IEnumerable<DoorMessage> GetLastBusesStatus(params int[] busIds);

        IEnumerable<DoorMessage> GetLastBusesStatus(IEnumerable<int> busIds);

    }
}
