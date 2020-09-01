using System;

namespace PointlessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string myMovingObject = "▓▓";
            string myGoal = "░░";
            int myMovingObjectY = 10;
            int myMovingObjectX = 10;
            int preMovingObjectY = myMovingObjectY;
            int preMovingObjectX = myMovingObjectX;
            int goalY = 10;
            int goalX = 100;
            bool validKeyPress = false;
            bool wictory = false;
            char[] myMovementList = new char[] { 'W', 'w', 'A', 'a', 'S', 's', 'D', 'd' };
            char myMovement = '0';

            do
            {
                Console.Clear();
                Console.WriteLine("Connect the two squares using your WASD-keys.");
                for (int y = 0; y < 20; y++)
                {
                    for (int x = 0; x < 120; x++)
                    {
                        if (y == myMovingObjectY && x == myMovingObjectX)
                            Console.Write(myMovingObject);
                        else if (y == goalY && x == goalX)
                            Console.Write(myGoal);
                        else if (goalY == myMovingObjectY && goalX == myMovingObjectX)
                            wictory = true;
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                do
                {
                    char myKeyPress = Console.ReadKey().KeyChar;

                    for (int i = 0; i < myMovementList.Length; i++)
                    {
                        char validKey = myMovementList[i];

                        if (myKeyPress == validKey)
                        {
                            myMovement = myKeyPress;
                            validKeyPress = true;
                            break;
                        }

                        else
                        {
                            validKeyPress = false;
                        }

                    }
                } while (validKeyPress != true);

                if (myMovement == 'w' || myMovement == 'W')
                    myMovingObjectY--;
                else if (myMovement == 's' || myMovement == 'S')
                    myMovingObjectY++;
                else if (myMovement == 'a' || myMovement == 'A')
                    myMovingObjectX = myMovingObjectX - 2;
                else if (myMovement == 'd' || myMovement == 'D')
                    myMovingObjectX = myMovingObjectX + 2;
            } while (wictory == false);

            Console.Clear();
            Console.WriteLine("Congratulations! You won the pointless game!");
        }
    }
}
