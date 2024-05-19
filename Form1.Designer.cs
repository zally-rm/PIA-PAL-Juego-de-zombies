namespace juego_2
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
            this.txtscore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vidabarra = new System.Windows.Forms.ProgressBar();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.txtmuni = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.BackColor = System.Drawing.Color.Transparent;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.ForeColor = System.Drawing.Color.White;
            this.txtscore.Location = new System.Drawing.Point(275, 9);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(170, 31);
            this.txtscore.TabIndex = 1;
            this.txtscore.Text = "MUERTES:0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(619, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIDA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // vidabarra
            // 
            this.vidabarra.Location = new System.Drawing.Point(709, 17);
            this.vidabarra.Name = "vidabarra";
            this.vidabarra.Size = new System.Drawing.Size(203, 23);
            this.vidabarra.TabIndex = 3;
            this.vidabarra.Value = 100;
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Interval = 20;
            this.tiempo.Tick += new System.EventHandler(this.eventotiempo);
            // 
            // txtmuni
            // 
            this.txtmuni.AutoSize = true;
            this.txtmuni.BackColor = System.Drawing.Color.Transparent;
            this.txtmuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmuni.ForeColor = System.Drawing.Color.White;
            this.txtmuni.Location = new System.Drawing.Point(34, 9);
            this.txtmuni.Name = "txtmuni";
            this.txtmuni.Size = new System.Drawing.Size(176, 31);
            this.txtmuni.TabIndex = 5;
            this.txtmuni.Text = "MUNICION:0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::juego_2.Properties.Resources.up;
            this.pictureBox1.Location = new System.Drawing.Point(281, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 98);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::juego_2.Properties.Resources.MapaP;
            this.ClientSize = new System.Drawing.Size(924, 609);
            this.Controls.Add(this.txtmuni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vidabarra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtscore);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zombies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.llaveabajo);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.llavearriba);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar vidabarra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label txtmuni;
    }
}

