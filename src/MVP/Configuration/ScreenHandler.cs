using MVP.Settings;
using Newtonsoft.Json;

namespace MVP.Configuration
{
    public static class ScreenHandler
    {
        private static string path = "Users/omar.nunez/Downloads/MVP/configFile.json";
        // private static string path;



        private static ScreenHandlerBuilder Builder { get; set; }

        public static void ShowFields()
        {
            
        }

        private class ScreenHandlerBuilder
        {
            private ScreenHandlerBuilder SetPath(string path)
            {
                ScreenHandler.path = path;
                return this;
            }

            public ScreenHandlerBuilder SetTitle(string title)
            {
                Console.Title = title;
                return this;
            }

            public ScreenHandlerBuilder SetFields(IEnumerable<Field> fields)
            {
                var name = new List<string>(fields);
            }
            public ScreenHandlerBuilder SetActions(IEnumerable<MVP.Settings.Action> actions)
            {

            }
        }

        public static void Configure()
        {
            var configFile = JsonConvert.DeserializeObject<ConfigFile>(path)!;
            Builder.SetTitle(configFile.Title);
            Builder.SetFields(configFile.Fields);
            // Builder.SetActions(configFile.Actions);
        }
    }
}