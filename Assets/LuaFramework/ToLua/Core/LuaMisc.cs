using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Runtime.CompilerServices;

namespace LuaInterface
{
    public class GCRef
    {
        public int reference;
        public string name = null;

        public GCRef(int reference, string name)
        {
            this.reference = reference;
            this.name = name;
        }
    }
}