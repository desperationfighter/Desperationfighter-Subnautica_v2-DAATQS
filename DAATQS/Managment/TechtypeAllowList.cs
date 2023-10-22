using Nautilus.Json;
using System.Collections.Generic;

namespace DAATQS.Managment
{
    public class TechTypeAllowList : ConfigFile
    {
        public TechTypeAllowList() : base("AllowList")
        {
        }

        public List<string> TechType = new List<string>() { "builder", "Knife", "Seaglide", "LaserCutter", "Flare", "PropulsionCannon", "HeatBlade", "RepulsionCannon", "fireextinguisher", "airbladder", "flashlight", "divereel", "welder", "scanner", "stasisrifle" };
    }

}
