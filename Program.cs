using System;

namespace tictactoe
{

    class Program
    {
        static int[] board = new int[9];
        static void Main(string[] args)
        {
            printBoard();

            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }
            
            // board[0] = 0;
            // board[1] = 0;
            // board[2] = 0;
            // board[3] = 0;
            // board[4] = 0;
            // board[5] = 0;
            // board[6] = 0;
            // board[7] = 0;
            // board[8] = 0;

            int userTurn = -1;
            int computerTurn = -1;
            Random rand = new Random();

            while (checkForWinner() == 0) {

                // don't allow the human to choose an already occupied square
                while (userTurn == -1 || board[userTurn] != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number from 1 - 9");
                    userTurn = int.Parse(Console.ReadLine());
                    userTurn = userTurn - 1;
                    Console.WriteLine("You typed " + userTurn);
                }


                board[userTurn] = 1 ;

                // don't let the computer pic an invalid number
                while (computerTurn == -1 || board[computerTurn] != 0)
                {
                    computerTurn = rand.Next(8);
                    Console.WriteLine("Computer chooses " + computerTurn);
                }

                board[computerTurn] = 2;
                printBoard();


            }
            Console.WriteLine();
            Console.WriteLine("Player " + checkForWinner() + " won the game! ");
            Console.WriteLine();
            
        }


        private static int checkForWinner()
        {
            // Return a 0 if nobody won. Return the player number if they won.


            // Top row.
            if (board[0] == board[1] && board[1] == board[2])
            {
                return board[0];
            }

            // Second row.
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }

            // Third row.
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }

            // First column
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }

            // Second column
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }

            // Third column
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }

            // First diagonal
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }

            // Second diagonal
            if (board[6] == board[4] && board[4] == board[2])
            {
                return board[6];
            }

            

            return 0;

        }

        private static void printBoard()
        {
            Console.WriteLine();
            for (int i = 0; i <9; i++)
            {
                // Print the board.
                // Console.WriteLine("Square " + i + " contains " + board[i]);

                // Print x or o for each square
                // 0 means unoccupied. 1 means player 1 (x) 2 means player 2 (O)

                if (board[i] == 0 )
                {
                    
                    Console.Write($"| {i + 1} |");
                    
                    // Console.Write(i + 1);

                }
                if (board[i] == 1 )
                {
                    Console.Write("| X |");
                    
                }
                if (board[i] == 2 )
                {
                    Console.Write("| O |");
                    
                }

                // print a new line every 3rd character
                if (i == 2 || i == 5 || i == 8.5)
                {
                    Console.WriteLine();
                    Console.WriteLine("|---||---||---|");
                }
            }
            Console.WriteLine();
        
        }
    }
}