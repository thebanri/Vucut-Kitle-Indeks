using System.Drawing.Text;

namespace WinFormsApp3
{

    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        private bool kapatac = false;

        public Form1()
        {
            InitializeComponent();
        }

        


        private void label1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textbox2click(object sender, EventArgs e)
        {
            if (textBox2.ReadOnly == true)
            {
                MessageBox.Show("Önce Boyunuzu Giriniz");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "0";
                if (textBox2.Text == "0")
                {
                    textBox2.SelectAll();
                }
                
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                
                if (double.TryParse(textBox1.Text, out double boy) && double.TryParse(textBox2.Text, out double kilo))
                {
                    
                    double boytrans = boy / 100 * boy / 100;
                    double indeks = kilo / boytrans;
                    string formatliIndex = indeks.ToString("0.00");
                    label3.Text = formatliIndex;
                }
                else
                {
                    label3.Text = "Geçersiz giriþ";
                }
            }

        
        }


        private void label3_TextChanged(object sender, EventArgs e)
        {
            form2.Tag = this;
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Location.X + 400, this.Location.Y);
            if(kapatac == false && double.Parse(label3.Text) >= 10)
            {
                form2.Show(this);
                kapatac = true;

                if (double.Parse(label3.Text) >= 10 && double.Parse(label3.Text) <= 18)
                {
                    form2.PictureBoxDegis(form2.pictureBox1);
                }

                else if (double.Parse(label3.Text) > 18 && double.Parse(label3.Text) <= 25)
                {
                    form2.PictureBoxDegis(form2.pictureBox2);
                }
                else if (double.Parse(label3.Text) > 25 && double.Parse(label3.Text) <= 30)
                {
                    form2.PictureBoxDegis(form2.pictureBox3);
                }
                else if (double.Parse(label3.Text) > 30 && double.Parse(label3.Text) <= 40)
                {
                    form2.PictureBoxDegis(form2.pictureBox4);
                }
                else if (double.Parse(label3.Text) > 40 && double.Parse(label3.Text) <= 60)
                {
                    form2.PictureBoxDegis(form2.pictureBox5);
                    
                }
                

            }
            
           
            
        }
    }
}
