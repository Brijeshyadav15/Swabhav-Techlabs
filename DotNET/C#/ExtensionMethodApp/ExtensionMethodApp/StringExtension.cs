using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodApp
{
    static class StringExtension
    {
        public static String AddHiTech(this String input)
        {
            return input + "HiTech";
        }
    }
}
