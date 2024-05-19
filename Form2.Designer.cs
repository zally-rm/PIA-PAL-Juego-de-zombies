namespace juego_2
{
    partial class TablaPuntuacionesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaPuntuacionesForm));
            this.botonRegresar = new System.Windows.Forms.Button();
            this.labelMuerte = new System.Windows.Forms.Label();
            this.score_final = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.top1Label = new System.Windows.Forms.Label();
            this.top2Label = new System.Windows.Forms.Label();
            this.top3Label = new System.Windows.Forms.Label();
            this.top4Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRegresar
            // 
            this.botonRegresar.BackColor = System.Drawing.Color.Maroon;
            this.botonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegresar.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegresar.ForeColor = System.Drawing.Color.White;
            this.botonRegresar.Location = new System.Drawing.Point(393, 547);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(5);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(152, 37);
            this.botonRegresar.TabIndex = 1;
            this.botonRegresar.Text = "> Inicio";
            this.botonRegresar.UseVisualStyleBackColor = false;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // labelMuerte
            // 
            this.labelMuerte.AutoSize = true;
            this.labelMuerte.BackColor = System.Drawing.Color.Transparent;
            this.labelMuerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuerte.ForeColor = System.Drawing.Color.Transparent;
            this.labelMuerte.Location = new System.Drawing.Point(102, 60);
            this.labelMuerte.Name = "labelMuerte";
            this.labelMuerte.Size = new System.Drawing.Size(738, 108);
            this.labelMuerte.TabIndex = 2;
            this.labelMuerte.Text = "¡HAS MUERTO!";
            // 
            // score_final
            // 
            this.score_final.AutoSize = true;
            this.score_final.BackColor = System.Drawing.Color.Transparent;
            this.score_final.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_final.ForeColor = System.Drawing.Color.White;
            this.score_final.Location = new System.Drawing.Point(378, 184);
            this.score_final.Name = "score_final";
            this.score_final.Size = new System.Drawing.Size(167, 36);
            this.score_final.TabIndex = 3;
            this.score_final.Text = "SCORE: 0";
            this.score_final.Click += new System.EventHandler(this.score_final_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1015, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::juego_2.Properties.Resources.marcador_remove;
            this.pictureBox2.Location = new System.Drawing.Point(303, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // top1Label
            // 
            this.top1Label.AutoSize = true;
            this.top1Label.BackColor = System.Drawing.Color.Transparent;
            this.top1Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top1Label.ForeColor = System.Drawing.Color.White;
            this.top1Label.Location = new System.Drawing.Point(339, 334);
            this.top1Label.Name = "top1Label";
            this.top1Label.Size = new System.Drawing.Size(96, 27);
            this.top1Label.TabIndex = 9;
            this.top1Label.Text = "label1";
            // 
            // top2Label
            // 
            this.top2Label.AutoSize = true;
            this.top2Label.BackColor = System.Drawing.Color.Transparent;
            this.top2Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top2Label.ForeColor = System.Drawing.Color.White;
            this.top2Label.Location = new System.Drawing.Point(339, 386);
            this.top2Label.Name = "top2Label";
            this.top2Label.Size = new System.Drawing.Size(96, 27);
            this.top2Label.TabIndex = 10;
            this.top2Label.Text = "label1";
            // 
            // top3Label
            // 
            this.top3Label.AutoSize = true;
            this.top3Label.BackColor = System.Drawing.Color.Transparent;
            this.top3Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3Label.ForeColor = System.Drawing.Color.White;
            this.top3Label.Location = new System.Drawing.Point(339, 446);
            this.top3Label.Name = "top3Label";
            this.top3Label.Size = new System.Drawing.Size(96, 27);
            this.top3Label.TabIndex = 11;
            this.top3Label.Text = "label1";
            // 
            // top4Label
            // 
            this.top4Label.AutoSize = true;
            this.top4Label.BackColor = System.Drawing.Color.Transparent;
            this.top4Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top4Label.ForeColor = System.Drawing.Color.White;
            this.top4Label.Location = new System.Drawing.Point(339, 500);
            this.top4Label.Name = "top4Label";
            this.top4Label.Size = new System.Drawing.Size(96, 27);
            this.top4Label.TabIndex = 12;
            this.top4Label.Text = "label1";
            // 
            // TablaPuntuacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 609);
            this.Controls.Add(this.top4Label);
            this.Controls.Add(this.top3Label);
            this.Controls.Add(this.top2Label);
            this.Controls.Add(this.top1Label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score_final);
            this.Controls.Add(this.labelMuerte);
            this.Controls.Add(this.botonRegresar);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TablaPuntuacionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.Label labelMuerte;
        private System.Windows.Forms.Label score_final;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label top1Label;
        private System.Windows.Forms.Label top2Label;
        private System.Windows.Forms.Label top3Label;
        private System.Windows.Forms.Label top4Label;
    }
}