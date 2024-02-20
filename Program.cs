namespace Devices_dz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kettle = new Kettle("Vitek", 7);
            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine();

            var microwave = new Microwave("Samsung", 320);
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine();

            var car = new Car("Chevrolet", "Chevelle");
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine();

            var steamer = new Steamer("Titanic", 22290);
            steamer.Show();
            steamer.Sound();
            steamer.Desc();
        }
    }
}
