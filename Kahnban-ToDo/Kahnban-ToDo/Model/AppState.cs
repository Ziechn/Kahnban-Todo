using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal class AppState
    {
        public string Path { get; set; } = "";

        public AppState(string path)
        {
            Path = path;
        }
    }
}
