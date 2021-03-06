using Datos2.Acceso;
using Datos2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tarea_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox.Text, ClavetextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }
            else if (!usuario.EstadoActivo)
            {
                MessageBox.Show("Usuario Inactivo");
                return;
            }

            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
            this.Hide();


        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
