namespace Game
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            TheWorld World = new TheWorld();
            while (true)
            {
                World.PrintWorld();
                World.PlayerMovement();
            }
        }
    }
}
