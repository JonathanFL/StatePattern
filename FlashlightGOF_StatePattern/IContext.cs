using System;
using System.Collections.Generic;
using System.Text;

namespace FlashlightGOF_StatePattern
{
    public interface IContext
    {
        void SetState(FlashingStates newState);
        void TurnOff();
        void TurnOn();
        void FlashingMode();
        void SolidMode();
    }
}
