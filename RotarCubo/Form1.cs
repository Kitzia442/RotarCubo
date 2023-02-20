using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotarCubo
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        float[,] RotacionX, RotacionY, RotacionZ;
        Figure figure;
        Scene scene;
        bool rotarX = false;
        bool rotarY = false;
        bool rotarZ = false;
        bool rotarEjes = false;
        float anguloX=0,  anguloY=0, anguloZ=0; 

       

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            figure= new Figure();
            scene = new Scene(figure);

            
        }

        private void rotationX_Click(object sender, EventArgs e)
        {
            figure = new Figure(); 
            rotarX = true;
            rotarY = false;
            rotarZ = false;
            rotarEjes = false;
        }

        private void rotationY_Click(object sender, EventArgs e)
        {
            rotarX = false;
            rotarY = true;
            rotarZ = false;
            rotarEjes = false;
        }

        private void rotationZ_Click(object sender, EventArgs e)
        {
            rotarX = false;
            rotarY = false;
            rotarZ = true;
            rotarEjes = false;
        }

        private void rotationAxis_Click(object sender, EventArgs e)
        {
            rotarX = false;
            rotarY = false;
            rotarZ = false;
            rotarEjes = true;
        }

        public void Draw(Vertex eje1, Vertex eje2)
        {

            g.DrawLine(Pens.BlueViolet, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            g.DrawLine(Pens.BlueViolet, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);

            PointF primerEje = eje1.ConvertirAPunto();
            PointF segundoEje = eje2.ConvertirAPunto();

            PointF primerEje11, segundoEje22;

            int sizeX = (pictureBox1.Width / 2);
            int sizeY = (pictureBox1.Height / 2);

            primerEje11 = new PointF(sizeX + primerEje.X, sizeY - primerEje.Y);
            segundoEje22 = new PointF(sizeX + segundoEje.X, sizeY - segundoEje.Y);

            g.DrawLine(Pens.DeepPink, primerEje11, segundoEje22);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (anguloX == 0 & anguloY == 0 & anguloZ == 0)
            {
                anguloX += 100f / 100f;
                anguloY += 5f / 100f;
                anguloZ += 5f / 100f;
            }

            if (rotarX)
            {
                figure.rotarEnX(anguloX);
            
            }
            

            if (rotarY)
            {
                figure.rotarEnY(anguloY);
            }

            if(rotarZ)
            {
                figure.rotarEnZ(anguloZ);
            }

            if(rotarEjes)
            {
                figure.rotarEnX(anguloX);
                figure.rotarEnY(anguloY);
                figure.rotarEnZ(anguloZ);    
            }

            g.Clear(Color.Transparent);

            Draw(figure.vertex[0], figure.vertex[1]);
            Draw(figure.vertex[1], figure.vertex[2]);
            Draw(figure.vertex[2], figure.vertex[3]);
            Draw(figure.vertex[3], figure.vertex[0]);
            Draw(figure.vertex[4], figure.vertex[5]);
            Draw(figure.vertex[5], figure.vertex[6]);
            Draw(figure.vertex[6], figure.vertex[7]);
            Draw(figure.vertex[7], figure.vertex[4]);
            Draw(figure.vertex[7], figure.vertex[0]);
            Draw(figure.vertex[6], figure.vertex[1]);
            Draw(figure.vertex[5], figure.vertex[2]);
            Draw(figure.vertex[4], figure.vertex[3]);

            pictureBox1.Invalidate();
        }
    }
}
