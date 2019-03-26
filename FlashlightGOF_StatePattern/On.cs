using System;

namespace FlashlightGOF_StatePattern
{
    public class On : FlashingStates
    {
        public override void OnEnter(IContext context)
        {
            context.SetState(new Solid());
        }

        public override void HandlePower(IContext context)
        {
            context.TurnOff();
            context.SetState(new Off());
        }
    }

    public class Solid : On
    {
        public override void OnEnter(IContext context) { }

        public override void ModePressed(IContext context)
        {
            context.SolidMode();
            context.SetState(new Flashing());
        }
    }

    public class Flashing : On
    {
        public override void OnEnter(IContext context) { }

        public override void ModePressed(IContext context)
        {
            context.FlashingMode();
            context.SetState(new Solid());
        }
    }
}
