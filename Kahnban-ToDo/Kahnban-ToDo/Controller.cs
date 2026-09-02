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
        public void CreateDirectory(string originalPath, long id)
        {
            string directoryName = id.ToString();
            string path = Path.Combine(originalPath, directoryName);
            Directory.CreateDirectory(path);
        }

        public long CreateId()
        {
            string dateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            long.TryParse(dateTime, out long id);
            return id;
        }

        public void CopyFile(string sourceFile, string destinationPath, string fileName)
        {
            string path = Path.Combine(destinationPath, fileName);
            File.Copy(sourceFile, path, overwrite: false);
        }

        public List<string> GetFiles(string path)
        {
            return Directory.GetFiles(path, "*.json").ToList();
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

        public T? ReadObject<T>(string path, long id)
        {
            string fileName = $"{id}.json";
            string filPath = Path.Combine(path, fileName);

            string json = File.ReadAllText(filPath);
            return JsonSerializer.Deserialize<T>(json);
        }

        public void Save<T>(T obj, string filePath, long id, Type? declaredType = null) where T : class
        {
            string fileName = $"{id}.json";
            string path = Path.Combine(filePath, fileName);

            string json = JsonSerializer.Serialize(
                obj,
                declaredType ?? typeof(T)
                );

            File.WriteAllText(path, json);
        }
    }
}
