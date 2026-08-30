using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Kahnban_ToDo
{
    internal class Controller
    {
        public void CreateDirectory(string originalPath, string directoryName)
        {
            string path = Path.Combine(originalPath, directoryName);
            Directory.CreateDirectory(path);
        }

        public long CreateId()
        {
            string dateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            long.TryParse(dateTime, out long id);
            return id;
        }

        public List<string> GetStatusList()
        {
            List<string> statusList = new List<string>();
            statusList.Add("BACKLOG");
            statusList.Add("BLOCKED");
            statusList.Add("BUG");
            statusList.Add("CANCELLED");
            statusList.Add("COMPLETE");
            statusList.Add("FIXED");
            statusList.Add("PENDING");
            statusList.Add("RELEASED");
            statusList.Add("RFT");
            statusList.Add("TODO");
            statusList.Add("WIP");

            return statusList;
        }

        public UserStory? GetUserStory(string projectPath, long id)
        {
            string fileName = $"{id}.json";
            string path = Path.Combine(projectPath, fileName);
            string json = File.ReadAllText(path);

            UserStory? userStory = JsonSerializer.Deserialize<UserStory>(json);
            return userStory;
        }

        public void Save<T>(T obj, string fileName) where T : class
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, json);
        }
    }
}
