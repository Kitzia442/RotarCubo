using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotarCubo
{
    public class Matriz
    {
        public float[,] matrizValores;
        public Matriz(float[,] matriz)
        {
            matrizValores = matriz;
        }

        public static Vertex vectorMatriz(Vertex vertex, float[,] funcionM)
        {
            float x = (funcionM[0, 0] * vertex.x) + (funcionM[1, 0] * vertex.y) + (funcionM[2, 0] * vertex.z);
            float y = (funcionM[0, 1] * vertex.x) + (funcionM[1, 1] * vertex.y) + (funcionM[2, 1] * vertex.z);
            float z = (funcionM[0, 2] * vertex.x) + (funcionM[1, 2] * vertex.y) + (funcionM[2, 2] * vertex.z);

            return new Vertex(x, y, z);
        }

        public static float[,] RotacionX(float angle)
        {
            float sin = (float)Math.Sin(angle);
            float cos = (float)Math.Cos(angle);

            float[,] rotacionX = new float[3, 3] {
                {1, 0, 0},
                {0, cos, -sin},
                {0, sin, cos}
            };
            return rotacionX;
        }

        public static float[,] RotacionY(float angle)
        {
            float sin = (float)Math.Sin(angle);
            float cos = (float)Math.Cos(angle);

            float[,] rotacionY = new float[3, 3] {
                {cos, 0, sin},
                {0, 1, 0},
                {-sin, 0, cos}
            };
            return rotacionY;
        }

        public static float[,] RotacionZ(float angle)
        {
            float sin = (float)Math.Sin(angle);
            float cos = (float)Math.Cos(angle);

            float[,] rotacionZ = new float[3, 3] {
                {cos, -sin, 0},
                {sin, cos, 0},
                {0, 0, 1}
            };
            return rotacionZ;
        }
    }
}





