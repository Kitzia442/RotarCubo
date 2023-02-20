using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotarCubo
{
    public class Vertex
    {
        public float x, y, z;

        /// <summary>
        /// constructor clase vertex
        /// </summary>
        /// <param name="x">eje en x</param> 
        /// <param name="y">eje en y</param>
        /// <param name="z"> eje en z</param>
        public Vertex(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }

        public PointF ConvertirAPunto() 
        {
            float pointFx = x * 500 / (500 - z);
            float pointFy = y * 500 / (500 - z);

            return new PointF(pointFx, pointFy); 
        }
    }
}
