using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// vamos a ocupar mas las siguientes 
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace juego_2
{
    internal class Bullet
    {
        public string direccion;
        public int Bulletleft;
        public int BulletTop;


        private int velocidad1 = 20;
        private PictureBox bullet = new PictureBox();
        private Timer BulletTimer = new Timer();

        // logica para las balas donde las privada solo se ocupan en este archivo llamado bullet viñeta y las publicas se pueden ocupar par el froms1 zombies

        public void MakeBullet(Form from) 
        { 

            bullet.BackColor = Color.White;
            bullet.Size = new Size(5,5);
            bullet.Tag = "bullet";
            bullet.Left = Bulletleft;
            bullet.Top = BulletTop;
            bullet.BringToFront();


            from.Controls.Add(bullet);

            BulletTimer.Interval = velocidad1;
            BulletTimer.Tick += new EventHandler(BulletTimerEvent);
            BulletTimer.Start ();

        }


        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direccion == "izquiera")
            {
                bullet.Left -= velocidad1;
            }

            if(direccion == "derecha")
            {
                bullet.Left += velocidad1;
            }

            if (direccion == " arriba ")
            {
                bullet.Top -= velocidad1;
            }

            if (direccion == "abajo")
            {
                bullet.Top += velocidad1;
            }

            // por si la bala no choca contra un zombie para que al chocar contra una pared desaparezca 

            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                BulletTimer.Stop();
                BulletTimer.Dispose ();
                bullet.Dispose ();
                BulletTimer = null;
                bullet = null;
            }
        }




    }
}
