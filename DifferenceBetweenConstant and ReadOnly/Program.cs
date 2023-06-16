using System;
using System.Configuration;

//ref link:https://www.youtube.com/watch?v=vNPBWNNlDwM
// cmd: C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\ildasm.exe

namespace ConstantAndReadOnly
{
    class Program
    {
        const int cmToMeters = 100; // Compile time constant - means absolute constant
        public static readonly double PI;// = 3.1; // Runtime constant or semi constant - means value can change but during initialize/runtime should never be change
        static Program() 
        {
            //PI = 3.1;
            PI = Convert.ToDouble(ConfigurationSettings.AppSettings[0]);
        }
        static void Main(string[] args)
        {
            
        }
    }
}