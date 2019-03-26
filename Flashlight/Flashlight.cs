using System;
using System.Collections.Generic;
using System.Text;

namespace Flashlight
{
    
    public class Flashlight
    {
        public enum FlashLightState
        {
            On = 1,
            Off = 2
        }

        public Flashlight()
        {
            
        }

        private void EvaluateState(FlashLightState state)
        {
            switch (state)
            {
                case FlashLightState.On:
                    Console.WriteLine("Flashlight is On");
                    break;
                case FlashLightState.Off:
                    Console.WriteLine("Flashlight is Off");
                    break;
            }
        }

        public void TurnOn()
        {
            EvaluateState(FlashLightState.On);
        }

        public void TurnOff()
        {
            EvaluateState(FlashLightState.Off);
        }
    }
}
