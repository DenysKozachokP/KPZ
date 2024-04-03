namespace task05Library
{
    public class Hero
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; }
        public List<string> Deeds { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Build: {Build}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothing: {Clothing}");
            Console.WriteLine($"Inventory:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"Deeds:");
            foreach (var deed in Deeds)
            {
                Console.WriteLine($"- {deed}");
            }
        }
    }
}
