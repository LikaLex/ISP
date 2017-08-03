using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LR4_2
{
    public static class Operation
    {
        [DllImport("cdlllr4.dll", EntryPoint = "addition", CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);
        [DllImport("cdlllr4.dll", EntryPoint = "subtraction", CallingConvention = CallingConvention.Cdecl)]
        public static extern int deduct(int a, int b);
        [DllImport("cdlllr4.dll", EntryPoint = "multiplication", CallingConvention = CallingConvention.Cdecl)]
        public static extern int multiply(int a, int b);
        [DllImport("cdlllr4.dll", EntryPoint = "division", CallingConvention = CallingConvention.Cdecl)]
        public static extern double divide(int a, int b);
        [DllImport("cdlllr4.dll", EntryPoint = "nod", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getNod(int a, int b);
    }
}
