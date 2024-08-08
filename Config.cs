using System.Collections.Generic;
using Rocket.API;

namespace Tortellio.BuilderMode
{
    public class Config : IRocketPluginConfiguration
    {
        public bool EnableServerAnnouncer;
        public float RestrictiveDistance;
        public float MinY;
        public float MaxY;
        public string MessageColor;
        public string DiscordWebHook;
        public string DiscordWebHookIcon;
        public string DiscordWebHookName;
        public List<ushort> BlacklistedBarricades { get; set; }
        public void LoadDefaults()
        {
            EnableServerAnnouncer = true;
            RestrictiveDistance = 50f;
            MinY = -20f;
            MaxY = 400f;
            MessageColor = "Yellow";
            DiscordWebHook = "";
            DiscordWebHookIcon = "https://cdn.discordapp.com/avatars/807474843469611059/a_d5c8540bda187272055cee53219e99d3.gif?size=1024";
            DiscordWebHookName = "BuilderMode";
            BlacklistedBarricades = new List<ushort> { 1234, 5678 };
        }
    }
}
