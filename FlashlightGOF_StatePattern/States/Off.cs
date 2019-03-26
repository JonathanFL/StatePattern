using System;
using FlashlightGOF_StatePattern;
using FlashlightGOF_StatePattern.States;

namespace FlashlightGOF_StatePattern.States
{
    public class Off : FlashingStates
    {
        public override void HandlePower(IContext context)
        {
            context.SetState(new On());
            context.TurnOn();
        }
    }
}
