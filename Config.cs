using Rocket.API;

namespace Tortellio.BuilderMode
{
    public class Config : IRocketPluginConfiguration
    {
        public bool EnableServerAnnouncer;
        public float RestrictiveDistance;
        public string MessageColor;
        public void LoadDefaults()
        {
            EnableServerAnnouncer = true;
            RestrictiveDistance = 5f;
            MessageColor = "Yellow";
        }
    }
}
