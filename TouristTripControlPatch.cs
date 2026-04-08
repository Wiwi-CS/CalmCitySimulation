using HarmonyLib;

namespace CalmCity
{
    [HarmonyPatch(typeof(TouristAI), "UpdateLocation")]
    public class TouristTripControlPatch
    {
        static bool Prefix(ushort citizenID, ref Citizen data)
        {
            int mode = CalmCityConfig.TouristMode;

            if (mode == 0)
                return true;

            return CooldownManager.ShouldRunTourist(citizenID);
        }
    }
}