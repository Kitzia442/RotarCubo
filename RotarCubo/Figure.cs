using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotarCubo
{
    public class Figure
    {
        public Vertex[] vertex;
        public Figure()
        {
            this.vertex = new Vertex[]
            {
                new Vertex(-75, 75, -75),
                new Vertex(75, 75, -75),
                new Vertex(75, -75, -75),
                new Vertex(-75, -75, -75),
                new Vertex(-75, -75, 75),
                new Vertex(75, -75, 75),
                new Vertex(75, 75, 75),
                new Vertex(-75, 75, 75)
            };
        }

        public void rotarEnX(float angle)
        {
            for (int i = 0; i < vertex.Length; i++)
            {
                Vertex vertexX = vertex[i];

                vertexX = Matriz.vectorMatriz(vertexX, Matriz.RotacionX(angle));
                vertex[i] = vertexX;
            }

        }


        public void rotarEnY(float angulo)
        {
            for (int i = 0; i < vertex.Length; i++)
            {
                Vertex vertexY = vertex[i];

                vertexY = Matriz.vectorMatriz(vertexY, Matriz.RotacionY(angulo));
                vertex[i] = vertexY;
            }
        }

        public void rotarEnZ(float angulo)
        {
            for (int i = 0; i < vertex.Length; i++)
            {
                Vertex vertexZ = vertex[i];

                vertexZ = Matriz.vectorMatriz(vertexZ, Matriz.RotacionZ(angulo));
                vertex[i] = vertexZ;
            }

        }

        public void rotarEjes(float angulo)
        {
            for (int i = 0; i < vertex.Length; i++)

            {
                Vertex vertexY = vertex[i];
                Vertex vertexX = vertex[i];
                Vertex vertexZ = vertex[i];

                vertex[i].x = vertexX.x;
                vertex[i].y = vertexY.y;
                vertex[i].z = vertexZ.z;
            }
        }

    }

}
