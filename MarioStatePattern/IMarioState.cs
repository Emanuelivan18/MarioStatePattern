﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioStatePattern
{
    public interface IMarioState
    {
        void Walk();
        void Idle();
        void Run();
        void Jump();
    }
}
