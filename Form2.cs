using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using static juego_2.TablaPuntuacionesForm;

namespace juego_2
{
    public partial class TablaPuntuacionesForm : Form
    {
        private SoundPlayer reproductorMusica; // para la musica en esta pantalla de score 

        public TablaPuntuacionesForm()
        {

            InitializeComponent();
        }




        string nombreUsuario = Inicio.nombreJugador;
        int score = Form1.score;
        string date = Convert.ToString(DateTime.Now);

        private List<Usuarios> CreacionArchivo()
        {
            var registro = new List<Usuarios>();
            string ruta = Application.StartupPath + @"\usuarios.csv";
            if (File.Exists(ruta))
            {

                System.IO.StreamReader archivo = new System.IO.StreamReader(ruta);
                string linea;
                archivo.ReadLine();
                while ((linea = archivo.ReadLine()) != null)
                {
                    string[] fila = linea.Split(',');
                    registro.Add(new Usuarios() { Name = fila[0], Score = Convert.ToInt16(fila[1]), Date = fila[2] });
                }
                archivo.Close();

            }
            else
            {
                TextWriter archivo = new StreamWriter(ruta);
                archivo.Close();
            }

            Usuarios personaActualizar = registro.Find(p => p.Name == nombreUsuario.ToUpper());

            if (personaActualizar != null)
            {
                if ( score > personaActualizar.Score)
                {
                    personaActualizar.Score = score;
                }
            } else
            {
                using (var writer = new StreamWriter(new FileStream(ruta, FileMode.Open), Encoding.UTF8))
                using (var csvwriter = new CsvWriter(writer, CultureInfo.CurrentCulture))
                {
                    registro.Add(new Usuarios() { Name = nombreUsuario.ToUpper(), Score = score, Date = date });
                    csvwriter.WriteRecords(registro);
                }
            }
            string score_ = Convert.ToString(score);
            score_final.Text = "SCORE: " + Convert.ToString(score);
            return registro;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // ruta de la muisca para esta pantalla
            string rutaMusica = "C:\\Users\\aleja\\Desktop\\NUEVOJUEGO\\muisca\\sondio_inicio.wav";
            try
            {
                reproductorMusica = new SoundPlayer(rutaMusica);
                reproductorMusica.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir la música: " + ex.Message);
            }

            var players = CreacionArchivo();

            var cuatroJugadores = players.OrderByDescending(p => p.Score).Take(4).ToList();


            top1Label.Text = cuatroJugadores[0].Name + " " + Convert.ToString(cuatroJugadores[0].Score);
            top2Label.Text = cuatroJugadores[1].Name + " " + Convert.ToString(cuatroJugadores[1].Score);
            top3Label.Text = cuatroJugadores[2].Name + " " + Convert.ToString(cuatroJugadores[2].Score);
            top4Label.Text = cuatroJugadores[3].Name + " " + Convert.ToString(cuatroJugadores[3].Score);
        }

        public class Usuarios
        {
            public string Name { get; set; }
            public int Score { get; set; }
            public string Date { get; set; }
        }



        private void botonRegresar_Click(object sender, EventArgs e)
        {


            reproductorMusica.Stop();
            Inicio pantallaMuerte = new Inicio();
            pantallaMuerte.Show();

            this.Close();    // se cambió de this.Hide() a this.Close()
        }


        private void score_final_Click(object sender, EventArgs e)
        {
            
        }
    }

}
