using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace Tetris
{
    internal class TetrisGame : GameWindow
    {

        private int[,] tablero;
        private const int columnas = 10;
        private const int filas = 20;
        private const int tamanoCelda = 30;
        public TetrisGame(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
            tablero = new int[filas, columnas];
        }


        protected override void OnLoad()
        {
            base.OnLoad();
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f); //Negro
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
            //Logia de movimiento y cntrol del juego
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            //Codigo para dibujar cosas en el tablero
            dibujarTablero();

            SwapBuffers();
        }

        private void dibujarTablero()
        {
            for (int y = 0; y < filas; y++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    if (tablero[x, y] == 0)
                    {
                        GL.Color3(0.8f, 0.8f, 0.8f);
                    }
                    else
                    {
                        //Color celda ocupada
                        GL.Color3(0.2f, 0.2f, 0.2f);
                    }
                    GL.Begin(PrimitiveType.Quads);
                    GL.Vertex2(x * tamanoCelda, y * tamanoCelda);
                    GL.Vertex2((x + 1) * tamanoCelda, y * tamanoCelda);
                    GL.Vertex2((x + 1) * tamanoCelda, (y + 1) * tamanoCelda);
                    GL.Vertex2(x * tamanoCelda, (y + 1) * tamanoCelda);
                    GL.End();
                }
            }
        }
    }

}

