using System;
using System.Windows.Forms;
namespace FormSaludo_G4_2022_I
{
    partial class FormSaludo
    {
        public FormSaludo()
        {
            InicializarComponentes();
        }

        private void btnAceptar_Click(object sender, EventArgs e  )
        {
            MessageBox.Show("Hola " + txtbNombre.Text  );
        }

    }
}
