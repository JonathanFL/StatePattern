using FlashlightGOF_StatePattern;

namespace FlashlightGOF_StatePattern.States
{
    public class FlashingStates
    {
        public virtual void HandlePower(IContext context) { }

        public virtual void ModePressed(IContext context) { }

        public virtual void OnEnter(IContext context) { }
    }
}
