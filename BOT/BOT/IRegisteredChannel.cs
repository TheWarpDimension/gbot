﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBot
{
    interface IRegisteredChannel:IRegisterable
    {
        Dictionary<string, int> permslist; //string=adress, int=perms
    }
}
