using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;


namespace LibExemplo
{
    public class Class1
    {
        public string TST;
        public Class1()
        {
#if NETFULL
            TST = "NETFULL";
#endif

#if NETSTANDARD
            TST = "NETSTANDARD";
#endif
        }
    }
}
