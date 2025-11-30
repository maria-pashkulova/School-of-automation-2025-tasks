namespace DiceBattleMethods
{
    internal class Program
    {
        static byte playerTotalScore = 0;
        static byte enemyTotalScore = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Dice battle");
            byte rounds = 5;

            for (int i = 0; i < rounds; i++)
            {
                byte playerRoll = RollDice();
                byte enemyRoll = RollDice();

                BattleRound(playerRoll, enemyRoll);
            }

            AnnounceWinner();

        }

        public static byte RollDice()
        {
            Random rnd = new Random();

            return (byte)rnd.Next(1, 7);
        }

        public static void BattleRound( byte playerRoll, byte enemyRoll)
        {
            /*  
             *  a.	Takes two numbers.
                b.	Prints who wins the round: 
                    i.	Higher roll → winner
                    ii.	Same roll → “It's a tie!”
            */

            Console.WriteLine($"{Environment.NewLine}Player rolled: {playerRoll}, Enemy rolled: {enemyRoll}");

            if (playerRoll > enemyRoll)
            {
                Console.WriteLine("Player wins the round!");
                playerTotalScore++;
            }
            else if (enemyRoll > playerRoll)
            {
                Console.WriteLine("Enemy wins the round!");
                enemyTotalScore++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        public static void AnnounceWinner()
        {

            Console.WriteLine($"{Environment.NewLine}Final result is: Player Score: {playerTotalScore}, Enemy Score: {enemyTotalScore} ");

            if (playerTotalScore > enemyTotalScore)
            {
                Console.WriteLine("Player is the overall winner!");
            }
            else if (enemyTotalScore > playerTotalScore)
            {
                Console.WriteLine("Enemy is the overall winner!");
            }
            else
            {
                Console.WriteLine("The game ends in a tie!");
            }
        }
    }
}
