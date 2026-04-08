using HarmonyLib;
using UnityEngine;

namespace CalmCity
{
    [HarmonyPatch(typeof(TouristAI), "SetSource")]
    public class TouristLimiterPatch
    {
        static bool Prefix(ushort instanceID, ref CitizenInstance data)
        {
            int mode = CalmCityConfig.TouristMode;

            if (mode == 0)
                return true;

            float chance = 1f;

            switch (mode)
            {
                case 1: chance = 0.62f; break;
                case 2: chance = 0.29f; break;
                case 3: chance = 0.19f; break;
                case 4: chance = 0.10f; break;
            }

            if (Random.value > chance)
                return false;

            return true;
        }
    }
}