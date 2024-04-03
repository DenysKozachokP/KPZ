using task05Library;
namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {

            HeroBuilder heroBuilder = new HeroBuilder();
            HeroBuilder enemyBuilder = new HeroBuilder();

            CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
            CharacterDirector enemyDirector = new CharacterDirector(enemyBuilder);

            heroDirector.CreateCharacter("Galahad", "Male", 180, "Muscular", "Brown", "Green", "Plate Armor", new List<string> { "Longsword", "Shield" }, new List<string> { "Protecting the innocent", "Slaying dragons", "Seeking the Holy Grail" });
            Hero hero = heroBuilder.Build();

            Console.WriteLine("Hero:");
            hero.DisplayInfo();
            Console.WriteLine();

            enemyDirector.CreateCharacter("Morgana", "Female", 185, "Curvy", "Black", "Purple", "Dark Robe", new List<string> { "Book of Shadows", "Poisonous Dagger" }, new List<string> { "Spreading chaos", "Corrupting the pure", "Conspiring against the throne" });
            Hero enemy = enemyBuilder.Build();

            Console.WriteLine("Enemy:");
            enemy.DisplayInfo();
        }
    }
}