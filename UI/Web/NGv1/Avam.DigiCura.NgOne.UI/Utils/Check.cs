using System;

namespace Avam.DigiCura.NgOne.UI.Utils
{
    public class Check
    {
        public static void ThrowIfTrue(bool conditionResult, Exception ex)
        {
            if (conditionResult) throw ex;
        }
        public static void ExecuteIfTrue(bool conditionResult, Action trueAction)
        {
            if (conditionResult) trueAction();
        }
    }
}