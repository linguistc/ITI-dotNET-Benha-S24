namespace Assignment9.PublisherSubscriber.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cooler c = new Cooler(50);
            Heater h = new Heater(10);

            Thermostat t = new Thermostat(20);

            c.Subscribe(t);
            h.Subscribe(t);

            t.CurrentTemp = 60;
            Console.WriteLine("==========================");
            t.CurrentTemp = 40;
            Console.WriteLine("==========================");
            t.CurrentTemp = 5;

            Console.WriteLine("\n\n==========================");
            Console.WriteLine("==========================\n\n");

            Thermostat t2 = new Thermostat(30);
            c.UnSubscribe(); // Explicit un subscribtion
            c.Subscribe(t2);
            h.Subscribe(t2); // Implicit un subscribtion


            t2.CurrentTemp = 0;
            Console.WriteLine("==========================");
            t2.CurrentTemp = 40;
            Console.WriteLine("==========================");
            t2.CurrentTemp = 100;

        }
    }
}
