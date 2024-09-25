namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Iniciando Juego de Tetris");
            using (TetrisGame game = new TetrisGame(800, 600, "Tetris 2d"))
            {
                game.Run();
            }



        }

    }
}


