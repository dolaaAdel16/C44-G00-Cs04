using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo01OOP
{
    internal class Program
    {
        static void Main()
        {
                // Your existing code here...

                enum Gender { M, F }

        enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA,
            SecurityOfficer
        }

        class HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate(int d, int m, int y)
            {
                Day = d;
                Month = m;
                Year = y;
            }

            public string Display()
            {
                return Day + "/" + Month + "/" + Year;
            }
        }
    }
    }
}
