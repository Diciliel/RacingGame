using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using RacingGame.Properties;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kazanilanPuan = 0;
        int yolHizi = 5;
        int PlayerHizi = 8; // Player

        bool solYon = false;
        bool sagYon = false;

        int arabaHizi = 6; // Diger arabalar

        Random rnd = new Random();

        public void GameStart()
        {
            btn_start.Enabled = false; // Oyun baslayinca button pasifleşir, basilamaz.
            explosion.Visible = false; // Patlama efekti surekli gorunmesin diye.

            kazanilanPuan = 0; // Oyun her basladiginda score sifirlanir.
            lbl_HS.Text = Settings2.Default.highScore.ToString();

            player.Left = 160; // Araba soldan 160 px uzakta baslar.
            player.Top = 350; 

            picBox_car1.Left = 120;
            picBox_car1.Top = 30;

            picBox_car2.Left = 320;
            picBox_car2.Top = 70;

            //explosion.Left = 165;
            //explosion.Top = 294;

            solYon = false;
            sagYon = false;


            timer1.Start();
            sesAc();
        }

        private void araba1Degis()
        {
            int sira = rnd.Next(1,7); // Resources klasorundeki gorsellerden random secilen gelir.
            switch (sira)
            {
                case 1:
                    picBox_car1.Image = Properties.Resources.araba2;
                    arabaHizi = 8;
                    break;
                case 2:
                    picBox_car1.Image = Properties.Resources.araba3;
                    arabaHizi = 8;
                    break;
                case 3:
                    picBox_car1.Image = Properties.Resources.araba6;
                    break;
                case 4:
                    picBox_car1.Image = Properties.Resources.araba7;
                    break;
                case 5:
                    picBox_car1.Image= Properties.Resources.araba8;
                    break;
                case 6:
                    picBox_car1.Image= Properties.Resources.araba9;
                    break;
                default: // Default secili olan gelir.
                    break;
            }
        }

        private void araba2Degis()
        {
            int sira = rnd.Next(1, 7); // Resources klasorundeki gorsellerden random secilen gelir.
            switch (sira)
            {
                case 1:
                    picBox_car2.Image = Properties.Resources.araba2;
                    arabaHizi= 8;
                    break;
                case 2:
                    picBox_car2.Image = Properties.Resources.araba3;
                    arabaHizi = 8;
                    break;
                case 3:
                    picBox_car2.Image = Properties.Resources.araba4;
                    break;
                case 4:
                    picBox_car2.Image = Properties.Resources.araba6;
                    break;
                case 5:
                    picBox_car2.Image = Properties.Resources.araba7;
                    break;
                case 6:
                    picBox_car1.Image = Properties.Resources.araba9;
                    break;
                default: // Default secili olan gelir.
                    break;
            }
        }

        private void GameOver()
        { 
            timer1.Stop();
            
            if (Convert.ToInt32(lbl_score.Text) > Convert.ToInt32(Settings2.Default.highScore.ToString()))
            { 
                Settings2.Default.highScore = lbl_score.Text;
            }
            
            btn_start.Enabled = true;
            explosion.Visible = true;
            player.Controls.Add(explosion); // Carpma efekti arabayi takip eder, uzerinde belirir.
            explosion.Location = new Point(7, -5);
            explosion.BringToFront(); // Efekt gorseli onde kalacak
            explosion.BackColor = Color.Transparent;
            MessageBox.Show("Hepi Topu Bu Kadar Puan: " + lbl_score.Text, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameStart();
        }
        private void sesAc()
        { 
            SoundPlayer ses = new SoundPlayer();
            string sesYol = Application.StartupPath + "\\race-track.wav";
            ses.SoundLocation = sesYol;
            ses.Play();
        }

        private void vurmaSesi() 
        {
            SoundPlayer vurma = new SoundPlayer();
            string vurmasesi = Application.StartupPath + "\\hit.wav";
            vurma.SoundLocation = vurmasesi;
            vurma.Play();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // Klavyeye basildiginda calisan fonksiyon
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                solYon = true;
            }
            if (e.KeyCode == Keys.Right && player.Left + player.Width < panel1.Width)
            {
                sagYon = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) // Klavyeye basmayi birakinca calisan fonksiyon
        {
            if (e.KeyCode == Keys.Left)
            {
                solYon = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagYon = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanilanPuan++; // Oyun baslayinca puan surekli artar.
            lbl_score.Text= kazanilanPuan.ToString();  // score textine yazar.

            picBox_road.Top += yolHizi; // Yol yukarindan yol hizi (5px) kadar kayar.

            if (picBox_road.Top > 200) // Yol görselinin yenilenmesi icin.
            { 
                picBox_road.Top = -105; 
            }

            if (solYon) // Araba, hizi kadar sag veya sola gidecek.
            {
                player.Left -= arabaHizi;
            }
            if (sagYon) 
            {
                player.Left += arabaHizi;
            }

            if (player.Left < 1) // Player oyun ekraninin disina cikamayacak.
            {
                solYon = false;
            }
            else if (player.Left + player.Width > 500)
            {
                sagYon = false;
            }

            picBox_car1.Top += arabaHizi; // Diger arabalar da hareket edecek.
            picBox_car2.Top += arabaHizi;

            if (picBox_car1.Top > panel1.Height) // Ilerledikce random yeni araba gelecek.
            {
                araba1Degis();
                picBox_car1.Left = rnd.Next(50, 180);
                picBox_car1.Top = rnd.Next(40, 80)* -1; // Yeni araba ekranin disindan belirecek.
            }

            if (picBox_car2.Top > panel1.Height) // Ilerledikce random yeni araba gelecek.
            {
                araba2Degis();
                picBox_car2.Left = rnd.Next(200, 450);
                picBox_car2.Top = rnd.Next(100,150) * -1; // Yeni araba ekranin disindan belirecek.
            }

            if (Convert.ToInt32(lbl_score.Text) == 500) 
            {   
                yolHizi = 8; 
                arabaHizi = 11; 
                PlayerHizi = 15; 
            }

            if (player.Bounds.IntersectsWith(picBox_car1.Bounds)|| player.Bounds.IntersectsWith(picBox_car2.Bounds)) // Arabalarin carpismasini kontrol eder. Ayni konumdalar mi?
            {
                vurmaSesi();
                GameOver();             
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GameStart();
        }
    }
}
