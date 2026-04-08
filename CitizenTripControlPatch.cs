using HarmonyLib;

namespace CalmCity
{
    [HarmonyPatch(typeof(ResidentAI), "UpdateLocation")]
    public class CitizenTripControlPatch
    {
        static bool Prefix(ushort citizenID, ref Citizen data)
        {
            int mode = CalmCityConfig.CitizenMode;

            if (mode == 0)
                return true;

            int divisor = 1;

            switch (mode)
            {
                case 1:
                    divisor = 2;
                    break;

                case 2:
                    divisor = 3;
                    break;

                case 3:
                    divisor = 4;
                    break;

                case 4:
                    divisor = 6;
                    break;

                default:
                    divisor = 1;
                    break;
            }

            uint frame = SimulationManager.instance.m_currentFrameIndex;

            // 🔹 Frame-Verteilung (Divisor)
            if (((citizenID + frame) % divisor) != 0)
                return false;

            // 🔹 Cooldown entscheidet final
            return CooldownManager.ShouldRunCitizen(citizenID);
        }
    }
}