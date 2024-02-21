using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MILIONERZY.Form1;

namespace MILIONERZY
{
    public partial class Form1 : Form
    {
        private List<Pytanie> pytania;
        private int PytanieIndex = 0;
        private int OdpowiedzIndex;
        public Form1()
        {
            InitializeComponent();
            DodajPytania();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            if (PytanieIndex > pytania.Count - 1)
            {
                MessageBox.Show($"Gratulacje, twoja wygrana to 1000000$");
                Close();
            }
            else
            {
                Pytanie pytanie1 = pytania[PytanieIndex];
                label1.Text = pytanie1.Text;
                button1.Text = "A: " + pytanie1.Odpowiedz[0];
                button2.Text = "B: " + pytanie1.Odpowiedz[1];
                button3.Text = "C: " + pytanie1.Odpowiedz[2];
                button4.Text = "D: " + pytanie1.Odpowiedz[3];
            }



        }
        public class Pytanie
        {
            public string Text;
            public List<string> Odpowiedz;
            public int PytanieIndex;

            public Pytanie(string Text, List<string> Odpowiedz, int PytanieIndex)
            {
                this.Text = Text;
                this.Odpowiedz = Odpowiedz;
                this.PytanieIndex = PytanieIndex;
            }
        }

        private void DodajPytania()
        {
            pytania = new List<Pytanie>
            {
                new Pytanie("Jaka jest stolica Francji?", new List<string> { "Berlin", "Paryż", "Londyn", "Madryt" }, 1),
                new Pytanie("Która planeta jest znana jako czerwona planeta?", new List<string> { "Mars", "Venus", "Jupiter", "Saturn" }, 0),
                new Pytanie("Jaki jest największy ssak na ziemi?", new List<string> { "Słoń", "Płetwal błękitny", "Żyrafa", "Goryl" }, 1),
                new Pytanie("W którym roku zakończyła się II wojna światowa?", new List<string> { "1943", "1945", "1950", "1939" }, 1),
                new Pytanie("Kto napisał 'Romeo i Julia'?", new List<string> { "Charles Dickens", "Jane Austen", "William Shakespeare", "Mark Twain" }, 2),
                new Pytanie("Który pierwiastek ma symbol 'O'?", new List<string> { "Oxygen", "Gold", "Silver", "Carbon" }, 0),
                new Pytanie("Jaka jest waulta używana w Japonii?", new List<string> { "Yen", "Won", "Ringgit", "Baht" }, 0),
                new Pytanie("Który kraj jest znany jako 'Kraj Kwitnącej Wiśni'?", new List<string> { "China", "Japan", "South Korea", "Vietnam" }, 1),
                new Pytanie("Kto namalował Mona Lisę?", new List<string> { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Claude Monet" }, 1),
                new Pytanie("Jaki jest największy ocean na Ziemi?", new List<string> { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" }, 3),
                new Pytanie("Jaka jest stolica Australii?", new List<string> { "Sydney", "Melbourne", "Canberra", "Perth" }, 2),
                new Pytanie("Który jest znany jako 'Ojciec informatyki''?", new List<string> { "Alan Turing", "Bill Gates", "Steve Jobs", "Ada Lovelace" }, 0)
            };

        }

        

        private void checkAnswer()
        {
            Pytanie pytanie1 = pytania[PytanieIndex];
            if (OdpowiedzIndex == pytanie1.PytanieIndex)
            {
                
                PytanieIndex += 1;
                listBox1.SelectedIndex = pytania.Count - PytanieIndex;

            }
            else
            {
                MessageBox.Show($"Niepoprawna odpowiedź, koniec gry! \n \n Twój wynik: {listBox1.Items[pytania.Count - PytanieIndex].ToString()} $ ");
                Close();
            }
        }

        private void DrawVotes(object sender, PaintEventArgs e)
        {

            Pytanie pytanie1 = pytania[PytanieIndex];
            int goodAnswer = pytanie1.PytanieIndex;

            Random random = new Random();

            int randomNumber1 = random.Next(0, 61);
            int randomNumber2 = random.Next(0, 61 - randomNumber1);
            int randomNumber3 = random.Next(0, 61 - randomNumber1 - randomNumber2);
            int randomNumber4 = 61 - randomNumber1 - randomNumber2 - randomNumber3;

            int h1 = randomNumber1;
            int h2 = randomNumber2;
            int h3 = randomNumber3;
            int h4 = randomNumber4;

            switch (goodAnswer)
            {
                case 0:
                    h1 += 40;
                    break;
                case 1:
                    h2 += 40;
                    break;
                case 2:
                    h3 += 40;
                    break;
                case 3:
                    h4 += 40;
                    break;
                default:
                    break;
            }


            Graphics g = e.Graphics;


            Pen pen = new Pen(Color.DodgerBlue, 2);


            int x1 = 50;
            int x2 = 200;
            int x3 = 350;
            int x4 = 500;

            int y = 100;

            int width = 100;

            h1 *= 5;
            h2 *= 5;
            h3 *= 5;
            h4 *= 5;


            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            int drawSpeed = 1000;

            for (int i = 0; i < drawSpeed; i++)
            {

                {
                    g.DrawRectangle(pen, x1, y, width, h1 * i / drawSpeed);
                    g.DrawRectangle(pen, x2, y, width, h2 * i / drawSpeed);
                    g.DrawRectangle(pen, x3, y, width, h3 * i / drawSpeed);
                    g.DrawRectangle(pen, x4, y, width, h4 * i / drawSpeed);


                    

                    g.DrawString("A", font, brush, new PointF(x1 + width / 2 - 5, y - 25));
                    g.DrawString($"{h1 / 5}%", font, brush, new PointF(x1 + width / 2 - 5, y + h1 + 5));
                    g.DrawString("B", font, brush, new PointF(x2 + width / 2 - 5, y - 25));
                    g.DrawString($"{h2 / 5}%", font, brush, new PointF(x2 + width / 2 - 5, y + h2 + 5));
                    g.DrawString("C", font, brush, new PointF(x3 + width / 2 - 5, y - 25));
                    g.DrawString($"{h3 / 5}%", font, brush, new PointF(x3 + width / 2 - 5, y + h3 + 5));
                    g.DrawString("D", font, brush, new PointF(x4 + width / 2 - 5, y - 25));
                    g.DrawString($"{h4 / 5}%", font, brush, new PointF(x4 + width / 2 - 5, y + h4 + 5));

                }

            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            OdpowiedzIndex = 0;
            checkAnswer();
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OdpowiedzIndex = 1;
            Pytanie pytanie1 = pytania[PytanieIndex];
            checkAnswer();
            Form1_Load(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdpowiedzIndex = 2;
            checkAnswer();
            Form1_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdpowiedzIndex = 3;
            checkAnswer();
            Form1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pytanie pytanie1 = pytania[PytanieIndex];
            int goodAnswer = pytanie1.PytanieIndex;

            switch (goodAnswer)
            {
                case 0:
                    button2.Visible = false;
                    button3.Visible = false;
                    break;
                case 1:
                    button1.Visible = false;
                    button3.Visible = false;
                    break;
                case 2:
                    button1.Visible = false;
                    button2.Visible = false;
                    break;
                case 3:
                    button2.Visible = false;
                    button3.Visible = false;
                    break;
                default:
                    break;
            }
            button5.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Gratulacje, wygrałeś: {listBox1.Items[pytania.Count - PytanieIndex].ToString()} $");
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form newForm = new Form();
            newForm.Text = "Głosowanie widowni";

            newForm.Size = new Size(650, 800);

            newForm.FormBorderStyle = FormBorderStyle.FixedSingle;

            newForm.Paint += DrawVotes;

            newForm.ShowDialog();

            button7.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
