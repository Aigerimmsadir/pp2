﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    class Rules
    {
        static bool Check(char[] arr, string msg)
        {
            return arr.Contains(msg[0]);
        }
        public static bool IsNonZeroDigit(string msg)
        {
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return Check(arr, msg);
        }
        public static bool IsDigit(string msg)
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return Check(arr, msg);
        }
        public static bool IsZero(string msg)
        {
            char[] arr = { '0' };
            return Check(arr, msg);
        }
        public static bool IsOperator(string msg)
        {
            char[] arr = { '+', '-', '/', '*','f' };
            return Check(arr, msg); 
        }
        public static bool IsEqualSign(string msg)
        {
            char[] arr = { '=','f' };
            return Check(arr, msg);
        }
    }
}
