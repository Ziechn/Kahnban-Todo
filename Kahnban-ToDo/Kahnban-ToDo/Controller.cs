using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
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

        public void Save<T>(T obj, string fileName) where T : class
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, json);
        }
    }
}
