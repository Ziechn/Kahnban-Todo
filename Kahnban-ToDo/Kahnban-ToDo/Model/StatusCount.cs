using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal class StatusCount
    {
        public string Status { get; set; } = "";
        public int Count { get; set; }

        public StatusCount()
        {
            Status = "";
            Count = 0;
        }

        public StatusCount(string status, int count)
        {
            Status = status;
            Count = count;
        }
    }
}
