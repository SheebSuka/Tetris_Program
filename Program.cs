using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {



            var gameWindowSettings = GameWindowSettings.Default;
            var nativeWindowSettings = new NativeWindowSettings()
            {

                Size = new Vector2i(800, 600),
                Title = "Tetris 2D",
                Flags = ContextFlags.ForwardCompatible

            };

            using (TetrisGame game = new TetrisGame(gameWindowSettings, nativeWindowSettings))
            {
                game.Run();

            }



        }

    }
}


