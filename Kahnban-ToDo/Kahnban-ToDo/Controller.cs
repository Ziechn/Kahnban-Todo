using Microsoft.VisualBasic.FileIO;
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
        // Constants
        private const string FILENAME_CONTACT = "contacts";

        public int CountStatus(string status, string textBoxText)
        {
            return textBoxText.Split(status).Length - 1;
        }

        public List<StatusCount> CountStatuses(string text)
        {
            List<StatusCount> statusCounts = new List<StatusCount>();
            List<string> statusList = GetStatusList();

            foreach (string status in statusList)
            {
                string statusTag = $"[{status}]";
                int count = CountStatus(statusTag, text);

                if (statusTag.Contains("COMPLETE"))
                {
                    count += CountStatus("[X]", text);
                    count += CountStatus("[DONE]", text);
                }

                StatusCount statusCount = new StatusCount(status, count);
                statusCounts.Add(statusCount);
            }

            return statusCounts;
        }

        public void CreateDirectory(string originalPath, long id)
        {
            string directoryName = id.ToString();
            string path = Path.Combine(originalPath, directoryName);
            Directory.CreateDirectory(path);
        }

        public long GenerateId()
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

        private void DeleteDirectory(long id, string path)
        {
            string directoryName = id.ToString();
            string directoryPath = Path.Combine(path, directoryName);

            if (Directory.Exists(directoryPath))
            {
                FileSystem.DeleteDirectory(
                    directoryPath,
                    UIOption.OnlyErrorDialogs,
                    RecycleOption.SendToRecycleBin
                );
            }
        }

        private void DeleteJson(long id, string path)
        {
            string fileName = $"{id}.json";
            string filePath = Path.Combine(path, fileName);

            if (File.Exists(filePath))
            {
                FileSystem.DeleteFile(
                    filePath,
                    UIOption.OnlyErrorDialogs,
                    RecycleOption.SendToRecycleBin
                );
            }
        }

        public void DeleteOrganization(string organizationName)
        {
            string userPath = AppStore.userPath;
            string organizationPath = Path.Combine(userPath, organizationName);

            if (Directory.Exists(organizationPath))
            {
                FileSystem.DeleteDirectory(
                    organizationPath,
                    UIOption.OnlyErrorDialogs,
                    RecycleOption.SendToRecycleBin
                );
            }
        }

        public void DeleteProject(long id)
        {
            string organizationPath = AppStore.organizationPath;

            DeleteDirectory(id, organizationPath);
            DeleteJson(id, organizationPath);
        }

        public void DeleteUserStory(long id)
        {
            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";

            string projectPath = Path.Combine(organizationPath, projectId);

            DeleteDirectory(id, projectPath);
            DeleteJson(id, projectPath);
        }

        public List<string> GetFiles(string path)
        {
            return Directory.GetFiles(path, "*.json").ToList();
        }

        public string GetFile(string path, string fileName)
        {
            string fullPath = Path.Combine(path, $"{fileName}.json");
            return File.Exists(fullPath) ? fullPath : null;
        }

        public List<string> GetStatusList()
        {
            List<string> statusList = new List<string>();
            statusList.Add("BACKLOG");
            statusList.Add("BLOCKED");
            statusList.Add("CANCELLED");
            statusList.Add("COMPLETE");
            statusList.Add("PENDING");
            statusList.Add("RELEASED");
            statusList.Add("TEST");
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

        public List<Contact> ReadContacts()
        {
            string applicationPath = AppContext.BaseDirectory;

            try
            {
                string? filePath = GetFile(applicationPath, FILENAME_CONTACT);

                if (filePath is null)
                {
                    return new List<Contact>(); // no file yet, start empty
                }

                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return new List<Contact>();
            }
        }

        public T? ReadObject<T>(string path, long id)
        {
            string fileName = $"{id}.json";
            string filPath = Path.Combine(path, fileName);

            string json = File.ReadAllText(filPath);
            return JsonSerializer.Deserialize<T>(json);
        }

        public T? ReadObject<T>(string path, string name)
        {
            string fileName = $"{name}.json";
            string filPath = Path.Combine(path, fileName);

            string json = File.ReadAllText(filPath);
            return JsonSerializer.Deserialize<T>(json);
        }

        public void ResetStore()
        {
            AppStore.organization = "";
            AppStore.organizationPath = "";
            AppStore.project = null;
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

        public void Save<T>(T obj, string filePath, string name, Type? declaredType = null) where T : class
        {
            string fileName = $"{name}.json";
            string path = Path.Combine(filePath, fileName);

            string json = JsonSerializer.Serialize(
                obj,
                declaredType ?? typeof(T)
                );

            Directory.CreateDirectory(filePath);
            File.WriteAllText(path, json);
        }
    }
}
