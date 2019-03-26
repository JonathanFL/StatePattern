using System;
using System.Collections.Generic;
using System.Text;

namespace FlashlightGOF_StatePattern.Factories
{
    public abstract class FlashlightControl
    {
        public abstract IFlashlight Flashlight();

        public IFlashlight GetObject()
        {
            return this.Flashlight();
        }
    }
}
