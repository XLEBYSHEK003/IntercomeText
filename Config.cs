using System;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace IntercomeText
{

    public class Config : IConfig
    {
        [Description("Is the plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Text in intercome")]
        public string StartedIntercomeText { get; set; } = "1";
    }
}
