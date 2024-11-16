using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal static class ErrorString
    {
        private static string ERROR;

        public static String Print() => ERROR;
        public static void Input(String error) => ERROR += (error + "\n");
    }
}
