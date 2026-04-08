using ICities;
using HarmonyLib;

namespace CalmCity
{
    public class CalmCityMod : IUserMod
    {
        public string Name => "Calm City Simulation";

        public string Description =>
            "Fewer decisions. Improved performance.";

        private Harmony harmony;

        public void OnEnabled()
        {
            harmony = new Harmony("com.calmcity.simulation");
            harmony.PatchAll();

            CalmCityConfig.Load();
            CooldownManager.Initialize();
        }

        public void OnDisabled()
        {
            harmony?.UnpatchAll("com.calmcity.simulation");
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            string[] options = new string[]
            {
                "Vanilla",
                "Lightly Reduced",
                "Reduced",
                "Very Reduced",
                "Ultra"
            };

            helper.AddDropdown("Citizen Simulation", options, CalmCityConfig.CitizenMode, (i) =>
            {
                CalmCityConfig.CitizenMode = i;
                CalmCityConfig.Save();
            });

            helper.AddDropdown("Tourist Simulation", options, CalmCityConfig.TouristMode, (i) =>
            {
                CalmCityConfig.TouristMode = i;
                CalmCityConfig.Save();
            });
        }
    }
}