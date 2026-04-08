using ColossalFramework;

namespace CalmCity
{
    public static class CooldownManager
    {
        private static uint[] citizenCooldowns;
        private static uint[] touristCooldowns;

        public static void Initialize()
        {
            citizenCooldowns = new uint[CitizenManager.MAX_CITIZEN_COUNT];
            touristCooldowns = new uint[CitizenManager.MAX_CITIZEN_COUNT];
        }

        public static bool ShouldRunCitizen(ushort citizenID)
        {
            int cooldown = CalmCityConfig.GetCitizenCooldown();
            if (cooldown == 0) return true;

            uint currentFrame = SimulationManager.instance.m_currentFrameIndex;
            ref uint nextFrame = ref citizenCooldowns[citizenID];

            // 🔥 Anti-Starvation
            if (currentFrame > nextFrame + 500)
            {
                nextFrame = currentFrame + (uint)cooldown;
                return true;
            }

            if (nextFrame > currentFrame)
                return false;

            nextFrame = currentFrame + (uint)(cooldown + (citizenID % 17));

            return true;
        }

        public static bool ShouldRunTourist(ushort citizenID)
        {
            int cooldown = CalmCityConfig.GetTouristCooldown();
            if (cooldown == 0) return true;

            uint currentFrame = SimulationManager.instance.m_currentFrameIndex;
            ref uint nextFrame = ref touristCooldowns[citizenID];

            // 🔥 Anti-Starvation
            if (currentFrame > nextFrame + 500)
            {
                nextFrame = currentFrame + (uint)cooldown;
                return true;
            }

            if (nextFrame > currentFrame)
                return false;

            nextFrame = currentFrame + (uint)(cooldown + (citizenID % 17));

            return true;
        }
    }
}