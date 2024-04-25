using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask2
{
    public class CommandCentre
    {
        public List<Runway> Runways { get; private set; }
        public List<Aircraft> Aircrafts { get; private set; }

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            Runways = new List<Runway>(runways);
            Aircrafts = new List<Aircraft>(aircrafts);
            RegisterAircrafts();
        }

        private void RegisterAircrafts()
        {
            foreach (var aircraft in Aircrafts)
            {
                aircraft.RegisterCommandCentre(this);
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            var availableRunway = GetAvailableRunway();
            if (availableRunway != null)
            {
                Console.WriteLine($"Літак {aircraft.Name} пішов на взліт.");
                availableRunway.IsBusy = true;
                aircraft.ConfirmTakeOff();
                availableRunway.HighLightGreen();
            }
            else
            {
                Console.WriteLine($"Немає вільної взлітної смуги для літака {aircraft.Name}.");
            }
        }

        public void RequestLand(Aircraft aircraft, Runway runway)
        {
            if (!runway.IsBusy)
            {
                Console.WriteLine($"Літак {aircraft.Name} пішов на посадку.");
                Console.WriteLine($"Перевіряється смуга {runway.Id}.");
                runway.IsBusy = true;
                aircraft.ConfirmLand();
                runway.HighLightRed();
            }
            else
            {
                Console.WriteLine($"Не вдалося сісти, смуга {runway.Id} зайнята.");
            }
        }

        private Runway GetAvailableRunway()
        {
            foreach (var runway in Runways)
            {
                if (!runway.IsBusy)
                {
                    return runway;
                }
            }
            return null;
        }
    }
}
