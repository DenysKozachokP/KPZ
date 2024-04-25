using System;
using System.Text;
using ClassLibraryTask2;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Runway[] runways = { new Runway(), new Runway() };
            Aircraft[] aircrafts = { new Aircraft("Embraer E190"), new Aircraft("Bombardier CRJ900") };

            CommandCentre commandCentre = new CommandCentre(runways, aircrafts);

            for (int i = 0; i < aircrafts.Length; i++)
            {
                aircrafts[i].RequestTakeOff();
            }

            commandCentre.Aircrafts[1].RequestLand(commandCentre.Runways[1]);
            commandCentre.Aircrafts[0].RequestLand(commandCentre.Runways[0]);
        }
    }
}