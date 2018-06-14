﻿using Huanent.Logging.File.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Huanent.Logging.File.UI
{
    public static class ConfigHelper
    {
        readonly static string _path = Path.Combine(AppContext.BaseDirectory, "logs", "config.json");
        public static ConfigModel Get()
        {
            if (!System.IO.File.Exists(_path)) return null;
            return JsonConvert.DeserializeObject<ConfigModel>(System.IO.File.ReadAllText(_path));
        }

        public static void Save(ConfigModel config)
        {
            System.IO.File.WriteAllText(_path, JsonConvert.SerializeObject(config));
        }
    }
}
