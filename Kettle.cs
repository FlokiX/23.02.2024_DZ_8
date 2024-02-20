using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_dz_8
{
    public class Kettle : Device
    {
        private int _volume;

        public Kettle(string name, int volume) : base(name)
        {
            _volume = volume;
        }

        public override void Sound()
        {
            Console.WriteLine("Чайник булькает!");
        }

        public override void Desc()
        {
            Console.WriteLine($"Чайник {_name} объемом {_volume} мл.");
        }
    }

}
