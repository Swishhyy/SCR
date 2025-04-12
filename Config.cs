using Exiled.API.Interfaces;

using System.ComponentModel;

namespace SCR
{
    public class Config : IConfig
    {
        [Description("Enable or disable the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable or disable debug.")]
        public bool Debug { get; set; } = false;
    }
}
