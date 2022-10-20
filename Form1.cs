using System.DirectoryServices;
using System.Windows.Forms;

namespace kamehujek
{
    public partial class Form1 : Form
    {

        Random rd = new Random();
        int los = 0;
        int gra = 0;
        int odp = 0;
        int proby = 0;
        int przedzial = 10;
        
        public Form1()
        {
        
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tries.Text = Convert.ToString(proby);
            if (los == 0)
            {
                MessageBox.Show("Rozpocz¹³eœ grê") ;
                if(radioButton1.Checked)
                { przedzial = 10; }
                else if (radioButton2.Checked)
                { przedzial = 100; }
                else if (radioButton3.Checked)
                { przedzial = 1500; }
                else if (radioButton4.Checked)
                { przedzial = 5000; }
                los = rd.Next(1, przedzial);
                gra = 1;
                proby = 0;
            }
            else if (los != 0)
            {
                MessageBox.Show("Gra zosta³a zrestartowana");
                if (radioButton1.Checked)
                { przedzial = 10; }
                else if (radioButton2.Checked)
                { przedzial = 100; }
                else if (radioButton3.Checked)
                { przedzial = 1500; }
                else if (radioButton4.Checked)
                { przedzial = 5000; }
                los = rd.Next(1, przedzial);
                gra = 1;
                proby = 0;
            }
        }

        private void odpowiedz_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gra == 0)
            {
                MessageBox.Show("Gra nie zosta³a rozpoczêta");
            }
            if (gra == 1)
            {

                odp = Convert.ToInt32(odpowiedz.Text);
                if(odp == los)
                { MessageBox.Show("Wygra³eœ, odpowiedŸ to: " + los + " zgadywa³eœ " + proby + " razy");}
                else if(odp >los)
                { wiadomosc.Text = "Twoja liczba jest za du¿a";
                    proby++;
                }
                else if (odp < los)
                { wiadomosc.Text = "Twoja liczba jest za ma³a";
                    proby++;
                }
                tries.Text = Convert.ToString(proby);
            }


        }

        private void wiadomosc_Click(object sender, EventArgs e)
        {

        }

        private void tries_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Podpowiedzi w³¹czone";
                wiadomosc.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Podpowiedzi wy³¹czone";
                wiadomosc.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}