using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal class AppStore
    {
        public static Panel? mainPanel;
        public static string organization = "";
        public static string organizationPath = "";
        public static Project? project;
        public static int projectFilterCategory = -1;
        public static string projectFilterSearch = "";
        public static int projectFilterStatus = -1;
        public static string userPath = "";
        public static long userStoryId = -1;
    }
}
