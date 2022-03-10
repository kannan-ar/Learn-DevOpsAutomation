using Learn_DevOpsAutomation.Test.UI.Utility.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_DevOpsAutomation.Test.UI.Utility
{
    public class Configuration
    {
        private static readonly Lazy<Configuration> lazy = new(() => new Configuration());
        private AutomationSettings _automationSettings;

        private Configuration() { }


        public static AutomationSettings AutomationSettings
        {
            get
            {
                if(lazy.Value._automationSettings == null)
                {
                    lazy.Value._automationSettings = lazy.Value.GetSettings();
                }

                return lazy.Value._automationSettings;
            }
        }

        public AutomationSettings GetSettings()
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "AutomationSettings.json");
            var json = File.ReadAllText(folderPath);
            var automationSettings = JsonConvert.DeserializeObject<AutomationSettings>(json);
            return automationSettings;
        }
    }
}
