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
    public partial class Form1 : Form
    {
        private SoundPlayer reproductorMusica; // muisca de doom
        bool juegoTerminado = false;
        bool veizquierda, vederecha, vearriba, veabajo, gameOver;
        string alfrente = "arriba";
        int jugadorsalud = 100;
        int velocidad = 10;
        int municion = 10;
        int velocidadzombie = 3;
        Random randNum = new Random();
        public static int score;
        List<PictureBox> listazombie = new List<PictureBox>(); // al crear esta lista al eliminar un zombie este se elimina y se vuelve a agregar a la lista para que vuelva a reaparecer


        // la variable pictureBox1 es el jugador player solo que no se lo cambie 

        public Form1()
        {
            this.BackgroundImage = Properties.Resources.MapaP;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormClosing += Form1_FormClosing; // Suscribir al evento FormClosing
            InitializeComponent();
            restaurarjuego();
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detener la reproducción de la música
            if (reproductorMusica != null)
            {
                reproductorMusica.Stop();
                reproductorMusica.Dispose();
            }

            // Finalizar la aplicación
            Application.Exit();
        }


        private string nombreJugador; // Definición del campo nombreJugador
        public Form1(string nombreJugador)
        {
            InitializeComponent();
            this.nombreJugador = nombreJugador; // Asignar el nombre del jugador recibido al campo nombreJugador
            restaurarjuego();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            string rutaMusica = "C:\\Users\\aleja\\Desktop\\NUEVOJUEGO\\muisca\\musica_doom.wav";
            try
            {
                reproductorMusica = new SoundPlayer(rutaMusica);
                reproductorMusica.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir la música: " + ex.Message);
            }

        }
        private TablaPuntuacionesForm pantallaPuntuaciones;
        private void eventotiempo(object sender, EventArgs e)
        {
            // musica para que al momento de morir el jugador deje de sonar la muisica 

            if (jugadorsalud > 0)
            {
                vidabarra.Value = jugadorsalud;

                // Mostrar una gota de vida extra si la salud del jugador es menor o igual a 40
                if (jugadorsalud <= 30 && aparicionesVidaExtra == 0)
                {
                    Dropvidaextra();
                    aparicionesVidaExtra++;
                }
                else if (jugadorsalud > 30)
                {
                    // Reiniciar la variable de apariciones si la salud del jugador es mayor que 40
                    aparicionesVidaExtra = 0;
                }
            }
            else
            {
                // El juego ha terminado
                gameOver = true;
                pictureBox1.Image = Properties.Resources.dead;
                tiempo.Stop();
                // Detener la reproducción de la música
                reproductorMusica.Stop();
                // Agregar la puntuación del jugador a la lista de puntuaciones
                TablaPuntuacionesForm pantallaMuerte = new TablaPuntuacionesForm();
                pantallaMuerte.Show();
                this.Close();
            }


            txtmuni.Text = "municion :" + municion;
            txtscore.Text = "muertes: " + score;

            if(veizquierda == true && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= velocidad;
            }


            if(vederecha == true && pictureBox1.Left + pictureBox1.Width < this.ClientSize.Width)
            {
                pictureBox1.Left += velocidad;
            }

            if(vearriba == true && pictureBox1.Top > 45)
            {
                pictureBox1.Top -= velocidad;
            }

            if(veabajo == true && pictureBox1.Top + pictureBox1.Height < this.ClientSize.Height)
            {
                pictureBox1.Top += velocidad;
            }



            

            // al momento de agarrar el dorp de municon que desaparezca y se sueme a la municion que te queda
            foreach(Control x in this.Controls)
            {
                // drop de vida extra para que se aumente y desaparezca 

                if (x is PictureBox && (string)x.Tag == "vidaextra")
                {
                    if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                    {
                        // Eliminar el objeto de vida extra del formulario
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();

                        // Aumentar la salud del jugador
                        jugadorsalud += 31;
                    }

                }

                //drop de municion para que aumente y desaarezca 

                    if (x is PictureBox && (string)x.Tag == "municion")
                {
                    if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        municion += 5;
                    }
                }
                // para que el zombie siga al jugador si el jugador va arriba el zombie va arriba y asi con las 4 direcciones
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                    {
                        jugadorsalud -= 1;
                    }



                    if (x.Left > pictureBox1.Left)
                    {
                        x.Left -= velocidadzombie;
                        ((PictureBox)x).Image = Properties.Resources.zleft; // zleft,zright y las otras 2 son el nombre de las imagenes de zombies
                    }

                    if (x.Left < pictureBox1.Left)
                    {
                        x.Left += velocidadzombie;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > pictureBox1.Top)
                    {
                        x.Top -= velocidadzombie;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < pictureBox1.Top)
                    {
                        x.Top += velocidadzombie;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach(Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            listazombie.Remove(((PictureBox)x));
                            creacionzombies();
                        }
                    }
                }


            }// foreach

        }

        private void MostrarTablaPuntuaciones()
        {
            // Instanciar y mostrar el formulario de tabla de puntuaciones
            TablaPuntuacionesForm tablaPuntuacionesForm = new TablaPuntuacionesForm();
            tablaPuntuacionesForm.ShowDialog();
        }





        private void llaveabajo(object sender, KeyEventArgs e)
        {
            if(gameOver == true)
            {
                return;
            }




            if (e.KeyCode == Keys.Left)
            {
                veizquierda = true;
                alfrente = "izquiera";      // ahora cuando le demos a la izquiera la varaible alfrente se combierte en izquiera
                pictureBox1.Image = Properties.Resources.left;
            }


            if (e.KeyCode == Keys.Right)
            {
                vederecha = true;
                alfrente = "derecha";  // ahora cuando le demos a la derecha la variable al frente se combierte en derecha 
                pictureBox1.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                vearriba = true;
                alfrente = "arriba"; // ahora cuando le demos para arriba la variable alfrente se cambia a arriba
                pictureBox1.Image = Properties.Resources.up;
            }


            if (e.KeyCode == Keys.Down)
            {
                veabajo = true; // ahora cuando le damos abajo la variable al frente se cambia para arriba 
                alfrente = "abajo";
                pictureBox1.Image = Properties.Resources.down;
            }
        }

        private void llavearriba(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                veizquierda = false;

            }


            if (e.KeyCode == Keys.Right)
            {
                vederecha = false;

            }

            if (e.KeyCode == Keys.Up)
            {
                vearriba = false;

            }

            if (e.KeyCode == Keys.Down)
            {
                veabajo = false;
            }


            // para las balas aqui primero se busca la tecla de espacio dentro de los () como arriba se busa primero las teclas arrriba, abajo, izquiera y derecha 
            if (e.KeyCode == Keys.Space && municion > 0  && gameOver == false)
            {
                municion--;
                disparo(alfrente);

                if (municion < 1)
                {
                    Dropmuunicion();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                restaurarjuego();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void disparo(string direccion)
        {
            Bullet disparobullet = new Bullet();
            disparobullet.direccion = direccion;
            disparobullet.Bulletleft =pictureBox1.Left + (pictureBox1.Width / 2);
            disparobullet.BulletTop = pictureBox1.Top + (pictureBox1.Height / 2);
            disparobullet.MakeBullet(this);

        }

        private void creacionzombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0,900);
            zombie.Top = randNum.Next(0, 800);
            zombie.BackColor = Color.Transparent;
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            listazombie.Add(zombie);  // ocupamos la lista que creamos arriba para añadir a zombies
            this.Controls.Add(zombie);
            pictureBox1.BringToFront();
        }



        private void Dropmuunicion()
        {
            PictureBox municion = new PictureBox();
            municion.Image = Properties.Resources.ammo_Image;
            municion.SizeMode = PictureBoxSizeMode.AutoSize;
            municion.Left =randNum.Next(10, this.ClientSize.Width - municion.Width);
            municion.Top = randNum.Next(60,this.ClientSize.Height - municion.Height);
            municion.Tag = "municion";
            municion.BackColor = Color.Transparent;
            this.Controls.Add(municion);

            municion.BringToFront();
            pictureBox1.BringToFront();
        }

        private int aparicionesVidaExtra = 0;
        private void Dropvidaextra()
        {
            
           
                PictureBox vidaExtra = new PictureBox();
                vidaExtra.Image = Properties.Resources.vidaextraaaa;
                vidaExtra.SizeMode = PictureBoxSizeMode.AutoSize;
                vidaExtra.Left = randNum.Next(10, this.ClientSize.Width - vidaExtra.Width);
                vidaExtra.Top = randNum.Next(60, this.ClientSize.Height - vidaExtra.Height);
                vidaExtra.Tag = "vidaextra";
                vidaExtra.BackColor = Color.Transparent;
                this.Controls.Add(vidaExtra);

                vidaExtra.BringToFront();
                pictureBox1.BringToFront();

            

        }
        private void restaurarjuego()
        {
            pictureBox1.Image = Properties.Resources.up;
            foreach(PictureBox i in listazombie)
            {
                this.Controls.Remove(i);
            }
            listazombie.Clear();
            //para que aparezcan por el mapa 4 zombies
            for(int i = 0; i < 4; i++)
            {
                creacionzombies();
            }

                        // cada vez que reinice una partida aparezcan 2 drops de vida extr

            vearriba = false;
            veabajo = false;
            veizquierda = false;
            vederecha = false;
            gameOver = false;
            jugadorsalud = 100;
            score = 0;
            municion = 10;

            tiempo.Start();

        }










    }
}
