using System;
using System.Collections.Generic;
using System.Text;

namespace FlashlightGOF_StatePattern.Factories
{
    public class FlashlightFactory : FlashlightControl
    {
        public override IFlashlight Flashlight()
        {
            IFlashlight flashlight = new Flashlight();

            return flashlight;
        }
    }
}
