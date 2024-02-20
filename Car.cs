using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_dz_8
{
    public class Car : Device
    {
        private string _model;

        public Car(string name, string model) : base(name)
        {
            _model = model;
        }

        public override void Sound()
        {
            Console.WriteLine("Автомобиль гудит!");
        }

        public override void Desc()
        {
            Console.WriteLine($"Автомобиль {_name} модели {_model}.");
        }
    }

}
