/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class TheWorld
    {
        public char[,] Grid;
        public int PlayerLocationX;
        public int PlayerLocationY;
        public int WorldSizeX;
        public int WorldSizeY;
        
        public TheWorld()
        {
            WorldSizeX = 25;
            WorldSizeY = 120;

            Grid = new char[WorldSizeX, WorldSizeY]; // 2d array
            PlayerLocationX = 2;
            PlayerLocationY = 2;

            CreateWorld();

            Grid[PlayerLocationX, PlayerLocationY] = 'P';
        }

        public void CreateWorld()
        {
            for (int i = 0; i < WorldSizeX; i++)
            {
                for(int j = 0; j < WorldSizeY; j++)
                {
                    Grid[i, j] = ' ';
                }
            }
        }

       public void PrintWorld()
        {
            Console.Clear();

            string S = "";

            for (int i = 0; i < WorldSizeX; i++)
            {
                for (int j = 0; j < WorldSizeY; j++)
                {
                   S += (Grid[i,j]);
                }
                
                S += "\n";
            }     
            
            Console.WriteLine(S);

        }

               
        public void PlayerMovement()
        {
            

            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            Console.Clear();

            switch (KeyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    Grid[PlayerLocationX, PlayerLocationY + 1] = 'P';
                    Grid[PlayerLocationX, PlayerLocationY] = ' ';
                    PlayerLocationY++;
                    break;

                case ConsoleKey.LeftArrow:
                    Grid[PlayerLocationX, PlayerLocationY -1] = 'P';
                    Grid[PlayerLocationX, PlayerLocationY] = ' ';
                    PlayerLocationY--;
                    break;

                case ConsoleKey.UpArrow:
                    Grid[PlayerLocationX-1, PlayerLocationY ] = 'P';
                    Grid[PlayerLocationX, PlayerLocationY] = ' ';
                    PlayerLocationX--;
                    break;

                case ConsoleKey.DownArrow:
                    Grid[PlayerLocationX+1, PlayerLocationY] = 'P';
                    Grid[PlayerLocationX, PlayerLocationY] = ' ';
                    PlayerLocationX++;
                    break;

            }   
        }
    }
}
*/
namespace Game
{
    public class ProgramBase
    {
    }
}