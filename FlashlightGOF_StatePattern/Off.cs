using System;

namespace FlashlightGOF_StatePattern
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
