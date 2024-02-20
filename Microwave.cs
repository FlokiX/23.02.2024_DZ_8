using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_dz_8
{
    public class Microwave : Device
    {
        private int _power;

        public Microwave(string name, int power) : base(name)
        {
            _power = power;
        }

        public override void Sound()
        {
            Console.WriteLine("Микроволновка пищит!");
        }

        public override void Desc()
        {
            Console.WriteLine($"Микроволновка {_name} мощностью {_power} Вт.");
        }
    }

}
