using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreValue.MoreValuePatch
{
    [HarmonyPatch(typeof(ValuableObject))]
    internal class ValuableObjectPatch
    {
        [HarmonyPatch("DollarValueSetLogic")]
        [HarmonyPostfix]

        static void IncreaseObjectValuePatch(ref float ___dollarValueCurrent, ref float ___dollarValueOriginal)
        {
            ___dollarValueCurrent *= 3f;
            ___dollarValueOriginal *= 3f;
        }

    }
}
