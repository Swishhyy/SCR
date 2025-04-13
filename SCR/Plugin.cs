﻿using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCR
{
    public class Plugin : Plugin<Config>
    {
        // Override the plugin's name property.
        public override string Name => "SCR";
        // Override the plugin's author property.
        public override string Author => "Swishhyy";
        // Override the plugin's version property.
        public override Version Version => new(1, 0, 0);
    }
}
