using System;
using System.Windows.Forms;

namespace Login_Form_Application
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void namecom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(idtext.Text, namecom.Text, tipecom.Text, quanitycom.Text, paytext.Text,
            telefonotext.Text, sexo.Text, correotext.Text, direciontext.Text);
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecom.Text = "";
            tipecom.Text = "";
            quanitycom.Text = "";
            paytext.Text = "";
            telefonotext.Text = "";
            sexo.Text = "";
            correotext.Text = "";
            direciontext.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("¿Estas seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void quanitycom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();

           
        }
    }
    }

