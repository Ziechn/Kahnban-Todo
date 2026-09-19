using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal class AppState
    {
        public string UserPath { get; set; } = "";

        public AppState(string userPath)
        {
            UserPath = userPath;
        }
    }
}
