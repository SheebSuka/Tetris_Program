namespace Tetris
{
    class Tetromino
    {
        public int[,] Forma { get; private set; }
        private static readonly int[][][] formas = new int[][][]
        {
 // Pieza I
 new int[][]
 {
 new int[] { 1, 1, 1, 1 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 }
 },
 // Pieza O
 new int[][]
 {
 new int[] { 1, 1, 0, 0 },
 new int[] { 1, 1, 0, 0 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 }
 },
 // Pieza T
 new int[][]
 {
 new int[] { 0, 1, 0, 0 },
 new int[] { 1, 1, 1, 0 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 }
 },
 // Pieza L
 new int[][]
 {
 new int[] { 1, 0, 0, 0 },
 new int[] { 1, 1, 1, 0 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 }
 },
 // Pieza J
 new int[][]
 {
 new int[] { 0, 0, 1, 0 },
 new int[] { 1, 1, 1, 0 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 }
 },
 // Pieza S
 new int[][]
 {
 new int[] { 0, 1, 1, 0 },
 new int[] { 1, 1, 0, 0 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 }
 },
 // Pieza Z
 new int[][]
 {
 new int[] { 1, 1, 0, 0 },
 new int[] { 0, 1, 1, 0 },
 new int[] { 0, 0, 0, 0 },
 new int[] { 0, 0, 0, 0 }
 }
        };
        public Tetromino(int tipo)
        {
            Forma = new int[4, 4];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Forma[y, x] = formas[tipo][y][x];
                }
            }
        }
        // Método para rotar la pieza
        public void Rotar()
        {
            int[,] rotada = new int[4, 4];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    rotada[y, x] = Forma[3 - x, y];
                }
            }
            Forma = rotada;
        }

    }
}

