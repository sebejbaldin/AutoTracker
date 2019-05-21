using System;
using System.Collections.Generic;
using System.Text;

namespace Baldin.SebEJ.Autotrack.DataAccess.Models
{
    public class DoorMessage : PositionMessage
    {
        public bool DoorOpen { get; set; }

        public int Passengers { get; set; }
    }
}
