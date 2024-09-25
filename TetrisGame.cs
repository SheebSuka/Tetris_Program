using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System.Numerics;

namespace Tetris
{
    internal class TetrisGame : GameWindow
    {

        private int _vao, _vbo;
        private Shader _shader;
        private Vector2[] vertices = new Vector2[]
        {
            new Vector2(0.0f,0.0f),
            new Vector2(0.0f, 1.0f),
            new Vector2(1.0f, 1.0f),
            new Vector2(1.0f, 0.0f),
        };

        private Matrix4x4 _projectionMatrix;

        public TetrisGame(int width, int height, string title)
            : base(GameWindowSettings.Default, new NativeWindowSettings()
            { Size = (width, height), Title = title });



        //public TetrisGame(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        //{
        //    tablero = new int[filas, columnas];
        //}


        protected override void OnLoad()
        {
            base.OnLoad();
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f); //Negro
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
            //Logia de movimiento y control del juego
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit);//<-Hay pedos aqui
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
                    if (tablero[y, x] == 0)
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

