using System;
using System.Collections.Generic;
using System.Text;
using FlashlightGOF_StatePattern.States;

namespace FlashlightGOF_StatePattern
{
    public class Flashlight : IFlashlight, IContext
    {
        private FlashingStates _flashingState;

        public Flashlight()
        {
            SetState(new Off());
        }

        public void Power()
        {
            _flashingState.HandlePower(this);
        }

        public void Mode()
        {
            _flashingState.ModePressed(this);
        }

        public void SetState(FlashingStates newState)
        {
            _flashingState = newState;
            _flashingState.OnEnter(this);
        }



        // implementations of IContext

        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }
        
        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }

        public void FlashingMode()
        {
            Console.WriteLine("Light is flashing");
        }

        public void SolidMode()
        {
            Console.WriteLine("Light is solid");
        }
    }
}
