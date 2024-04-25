namespace ClassLibraryTask2
{
    public class Aircraft
    {
        public readonly string Name;
        private CommandCentre CommandCentre;

        public Aircraft(string name)
        {
            Name = name;
        }

        public void RegisterCommandCentre(CommandCentre commandCentre)
        {
            CommandCentre = commandCentre;
        }

        public void RequestTakeOff()
        {
            if (CommandCentre != null)
            {
                CommandCentre.RequestTakeOff(this);
            }
            else
            {
                Console.WriteLine($"Літак {Name} не може здійснити запит на взліт. Командний центр не зареєстрований.");
            }
        }

        public void RequestLand(Runway runway)
        {
            if (CommandCentre != null)
            {
                CommandCentre.RequestLand(this, runway);
            }
            else
            {
                Console.WriteLine($"Літак {Name} не може здійснити запит на посадку. Командний центр не зареєстрований.");
            }
        }

        public void ConfirmTakeOff()
        {
            Console.WriteLine($"Літак {Name} пішов на взліт.");
        }

        public void ConfirmLand()
        {
            Console.WriteLine($"Літак {Name} пішов на посадку.");
        }
    }
}
