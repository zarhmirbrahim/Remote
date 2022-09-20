using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Remote.Managers
{
    public class UsersTable
    {
        [JsonProperty]
        private Dictionary<Guid, UserInfo> users = new();

        public static UsersTable FromFile(string file_name)
        {
            string file_data = File.ReadAllText(file_name);
            UsersTable table = JsonConvert.DeserializeObject<UsersTable>(file_data)!;

            if (table == null)
                table = new();
            return table;
        }

        public void ToFile(string file_name)
        {
            string file_data = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(file_name, file_data);
        }

        public UserInfo GetUser(Guid guid)
        {
            return users[guid];
        }

        public void SetUser(Guid guid, UserInfo user)
        {
            users[guid] = user;
        }
    }

    [JsonConverter(typeof(JsonUserReadWriteConverter))]
    public class UserInfo
    {
        public string Name { get; private set; }
        [JsonIgnore]
        public Image Icon { get; private set; }
        public string IconPath { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetIcon(string path)
        {
            Icon = Image.FromFile(path);
            IconPath = path;
        }
    }

    public class JsonUserReadWriteConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            return null;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            var user = value as UserInfo;
            if (user != null)
            {
                writer.WritePropertyName("Name");
                writer.WriteValue("Name");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(UserInfo);
        }
    }
}
