using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_2
{
    public partial class Inicio : Form
    {
        private SoundPlayer player;
        public Inicio()
        {
            this.FormClosing += Inicio_FormClosing; // Suscribir al evento FormClosing
            InitializeComponent();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detener la reproducción de la música
            if (player != null)
            {
                player.Stop();
                player.Dispose();
            }

            // Finalizar la aplicación
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            string rutaMusica = "C:\\Users\\aleja\\Desktop\\NUEVOJUEGO\\muisca\\sondio_inicio.wav";
            // NO borrar esto
            try
            {
                // Inicializa el reproductor de sonido
                player = new SoundPlayer(rutaMusica);

                // Reproduce la música de fondo de forma continua
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir la música: " + ex.Message);
            }
        }

        public static string nombreJugador;

        private bool ValidarNombreJugador()
        {
            nombreJugador = textbox_nombre.Text;

            if (nombreJugador.Length > 10)
            {
                label_advertencia_nombre.Text = "¡Tu nombre es muy largo! Escoge uno más corto";
                label_advertencia_nombre.Visible = true;
                return false;
            }
            else if (string.IsNullOrEmpty(nombreJugador) || string.IsNullOrWhiteSpace(nombreJugador))
            {
                label_advertencia_nombre.Text = "¡Tienes que ingresar un nombre!";
                label_advertencia_nombre.Visible = true;
                return false;
            }
            else
            {
                label_advertencia_nombre.Visible = false;
                return true;
            }
        }

        private void capturarNombre(object sender, EventArgs e)
        {
            label_nombre.Visible = true;
            textbox_nombre.Visible = true;
            btn_listo.Visible = true;

        }
        private void btn_listo_Click(object sender, EventArgs e)
        {
            if (ValidarNombreJugador())
            {
                // Detener la reproducción de la música
                player.Stop();

                // Mostrar la pantalla de juego (Form1)
                Form1 pantallaJuego = new Form1(textbox_nombre.Text);
                pantallaJuego.Show();

                // Cerrar la pantalla actual (Inicio)
                this.Dispose(); // Esto cierra la ventana actual sin abrir una nueva instancia
            }
        }

        private void label_nombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
