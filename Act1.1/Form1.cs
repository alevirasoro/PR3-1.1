using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (txtApe.Text == "")
                txtApe.BackColor = Color.Red;
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            if (txtDirec.Text == "")
                txtDirec.BackColor = Color.Red;
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            txtRes.AppendText("Apellido y Nombre: " + txtApe.Text + " " + txtNombre.Text + Environment.NewLine);
            txtRes.AppendText("Edad: " + txtEdad.Text + Environment.NewLine);
            txtRes.AppendText("Direccion: " + txtDirec.Text);
           // txtRes.Text = "Edad: " + txtEdad.Text + "\n";
           // txtRes.Text = "Direccion: " + txtDirec.Text + "\n";
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
