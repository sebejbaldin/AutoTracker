
using System;
using System.Collections.Generic;
using System.Text;

namespace Baldin.SebEJ.Autotrack.DataAccess.Models
{
    public class PositionMessage
    {
        public int Id { get; set; }

        public string BusCode { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        public Location Location { get; set; }
    }
}
