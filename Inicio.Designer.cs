namespace juego_2
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textbox_nombre = new System.Windows.Forms.TextBox();
            this.label_advertencia_nombre = new System.Windows.Forms.Label();
            this.btn_listo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Street Threat", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(209, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 195);
            this.label1.TabIndex = 0;
            this.label1.Text = "SURVIVAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_jugar
            // 
            this.btn_jugar.BackColor = System.Drawing.Color.Transparent;
            this.btn_jugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jugar.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jugar.ForeColor = System.Drawing.Color.White;
            this.btn_jugar.Location = new System.Drawing.Point(405, 285);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(137, 41);
            this.btn_jugar.TabIndex = 1;
            this.btn_jugar.Text = "> JUGAR";
            this.btn_jugar.UseVisualStyleBackColor = false;
            this.btn_jugar.Click += new System.EventHandler(this.capturarNombre);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.White;
            this.label_nombre.Location = new System.Drawing.Point(328, 355);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(301, 30);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre de jugador:";
            this.label_nombre.Visible = false;
            this.label_nombre.Click += new System.EventHandler(this.label_nombre_Click);
            // 
            // textbox_nombre
            // 
            this.textbox_nombre.BackColor = System.Drawing.Color.DimGray;
            this.textbox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_nombre.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_nombre.ForeColor = System.Drawing.Color.White;
            this.textbox_nombre.Location = new System.Drawing.Point(371, 403);
            this.textbox_nombre.Name = "textbox_nombre";
            this.textbox_nombre.Size = new System.Drawing.Size(206, 31);
            this.textbox_nombre.TabIndex = 3;
            this.textbox_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_nombre.Visible = false;
            // 
            // label_advertencia_nombre
            // 
            this.label_advertencia_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_advertencia_nombre.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_advertencia_nombre.ForeColor = System.Drawing.Color.White;
            this.label_advertencia_nombre.Location = new System.Drawing.Point(306, 515);
            this.label_advertencia_nombre.Name = "label_advertencia_nombre";
            this.label_advertencia_nombre.Size = new System.Drawing.Size(352, 58);
            this.label_advertencia_nombre.TabIndex = 4;
            this.label_advertencia_nombre.Text = "_______________________";
            this.label_advertencia_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_advertencia_nombre.Visible = false;
            // 
            // btn_listo
            // 
            this.btn_listo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_listo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listo.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listo.ForeColor = System.Drawing.Color.White;
            this.btn_listo.Location = new System.Drawing.Point(388, 458);
            this.btn_listo.Name = "btn_listo";
            this.btn_listo.Size = new System.Drawing.Size(172, 41);
            this.btn_listo.TabIndex = 5;
            this.btn_listo.Text = "> ¡LISTO!";
            this.btn_listo.UseVisualStyleBackColor = false;
            this.btn_listo.Visible = false;
            this.btn_listo.Click += new System.EventHandler(this.btn_listo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::juego_2.Properties.Resources.fondo_inicio_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 609);
            this.Controls.Add(this.btn_listo);
            this.Controls.Add(this.label_advertencia_nombre);
            this.Controls.Add(this.textbox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.btn_jugar);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textbox_nombre;
        private System.Windows.Forms.Label label_advertencia_nombre;
        private System.Windows.Forms.Button btn_listo;
    }
}