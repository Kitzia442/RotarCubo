namespace RotarCubo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rotationX = new System.Windows.Forms.Button();
            this.rotationY = new System.Windows.Forms.Button();
            this.rotationZ = new System.Windows.Forms.Button();
            this.AllAxis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(43, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 399);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rotationX
            // 
            this.rotationX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rotationX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationX.ForeColor = System.Drawing.Color.BlueViolet;
            this.rotationX.Location = new System.Drawing.Point(655, 92);
            this.rotationX.Name = "rotationX";
            this.rotationX.Size = new System.Drawing.Size(96, 28);
            this.rotationX.TabIndex = 1;
            this.rotationX.Text = "Rotation in X";
            this.rotationX.UseVisualStyleBackColor = false;
            this.rotationX.Click += new System.EventHandler(this.rotationX_Click);
            // 
            // rotationY
            // 
            this.rotationY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationY.Location = new System.Drawing.Point(655, 142);
            this.rotationY.Name = "rotationY";
            this.rotationY.Size = new System.Drawing.Size(96, 27);
            this.rotationY.TabIndex = 2;
            this.rotationY.Text = "Rotation in Y";
            this.rotationY.UseVisualStyleBackColor = true;
            this.rotationY.Click += new System.EventHandler(this.rotationY_Click);
            // 
            // rotationZ
            // 
            this.rotationZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationZ.Location = new System.Drawing.Point(655, 188);
            this.rotationZ.Name = "rotationZ";
            this.rotationZ.Size = new System.Drawing.Size(96, 26);
            this.rotationZ.TabIndex = 3;
            this.rotationZ.Text = "Rotation in Z";
            this.rotationZ.UseVisualStyleBackColor = true;
            this.rotationZ.Click += new System.EventHandler(this.rotationZ_Click);
            // 
            // AllAxis
            // 
            this.AllAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllAxis.Location = new System.Drawing.Point(655, 239);
            this.AllAxis.Name = "AllAxis";
            this.AllAxis.Size = new System.Drawing.Size(96, 27);
            this.AllAxis.TabIndex = 4;
            this.AllAxis.Text = "All axis";
            this.AllAxis.UseVisualStyleBackColor = true;
            this.AllAxis.Click += new System.EventHandler(this.rotationAxis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllAxis);
            this.Controls.Add(this.rotationZ);
            this.Controls.Add(this.rotationY);
            this.Controls.Add(this.rotationX);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button rotationX;
        private System.Windows.Forms.Button rotationY;
        private System.Windows.Forms.Button rotationZ;
        private System.Windows.Forms.Button AllAxis;
    }
}

