﻿using GSharp.Base.Cores;
using GSharp.Base.Objects;
using GSharp.Graphic.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSharp.Graphic.Objects
{
    public abstract class NumberBlock : ObjectBlock
    {
        public abstract GNumber GNumber { get; }

        public NumberBlock()
        {

        }
    }
}
