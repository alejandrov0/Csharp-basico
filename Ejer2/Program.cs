﻿using System;

namespace ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
          sbyte byteConsigno = sbyte.MaxValue;
            byte byteSinSigno = byte.MaxValue;
            short shortoConSigno = short.MaxValue;
            ushort ushortSinSigno = ushort.MaxValue;
            int intConSigno = int.MaxValue;
            uint uintSinSigno = uint.MaxValue;
            long logConSigno = long.MaxValue;
            ulong ulogSinSigno = ulong.MaxValue;
            float floatValor = float.MaxValue;
            double doubleValor = double.MaxValue;
            decimal decimalValor = decimal.MaxValue;

            Console.WriteLine("MAX[sbyte]: {0}", byteConsigno);
            Console.WriteLine("MAX[byte]: {0}", byteSinSigno);
            Console.WriteLine("MAX[short]: {0}", shortoConSigno);
            Console.WriteLine("MAX[ushort]: {0}", ushortSinSigno);
            Console.WriteLine("MAX[int]: {0}", intConSigno);
            Console.WriteLine("MAX[uint]: {0}", uintSinSigno);
            Console.WriteLine("MAX[long]: {0}", logConSigno);
            Console.WriteLine("MAX[ulong]: {0}", ulogSinSigno);
            Console.WriteLine("MAX[float]: {0}", floatValor);
            Console.WriteLine("MAX[double]: {0}", doubleValor);
            Console.WriteLine("MAX[decimal]: {0}", decimalValor);
        }
    }
}
