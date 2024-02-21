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

using System;

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
            WorldSizeY = 70;

            Grid = new char[WorldSizeX, WorldSizeY];
            PlayerLocationX = 2;
            PlayerLocationY = 2;

            CreateWorld();

            Grid[PlayerLocationX, PlayerLocationY] = 'P';
        }

        public void CreateWorld()
        {
            for (int i = 0; i < WorldSizeX; i++)
            {
                for (int j = 0; j < WorldSizeY; j++)
                {
                    if (i == 0 || i == WorldSizeX - 1 || j == 0 || j == WorldSizeY - 1)
                    {
                        Grid[i, j] = '#';
                    }
                    else
                    {
                        Grid[i, j] = ' ';
                    }
                }
            }
        }

        public void PrintWorld()
        {
            Console.Clear();

            for (int i = 0; i < WorldSizeX; i++)
            {
                for (int j = 0; j < WorldSizeY; j++)
                {
                    Console.Write(Grid[i, j]);
                }

                Console.WriteLine();
            }
        }

        public void PlayerMovement()
        {
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            Console.Clear();

            int newPlayerLocationX = PlayerLocationX;
            int newPlayerLocationY = PlayerLocationY;

            switch (KeyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    newPlayerLocationY++;
                    break;

                case ConsoleKey.LeftArrow:
                    newPlayerLocationY--;
                    break;

                case ConsoleKey.UpArrow:
                    newPlayerLocationX--;
                    break;

                case ConsoleKey.DownArrow:
                    newPlayerLocationX++;
                    break;
            }


            if (newPlayerLocationX > 0 && newPlayerLocationX < WorldSizeX - 1 &&
                newPlayerLocationY > 0 && newPlayerLocationY < WorldSizeY - 1)
            {
                
                Grid[newPlayerLocationX, newPlayerLocationY] = 'P';
                Grid[PlayerLocationX, PlayerLocationY] = ' ';
                PlayerLocationX = newPlayerLocationX;
                PlayerLocationY = newPlayerLocationY;
            }
        }
    }
}
