using System;
using System.Drawing;
using System.Windows.Forms;
namespace FormSaludo_G4_2022_I
{
    partial class FormSaludo:Form
    {
        private Label lbNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;

            
        private void InicializarComponentes()
        {
            this.Text = "FormSaludo";
            this.Size = new Size(400, 300);

            //Inicializar o Instanciar Atributo lbNombre
            lbNombre = new Label();
            lbNombre.Text = "Introduce tu nombre";
            lbNombre.Location = new Point(50,50 );
            lbNombre.Size = new Size(150, 40);

            //Inicializar o Instanciar Atributo txtbNombre
            txtbNombre = new TextBox();
            txtbNombre.Location = new Point(200,50);
            txtbNombre.Size = new Size(120, 40);

            //Inicializar o Instanciar Atributo btnAceptar
            btnAceptar = new Button();
            btnAceptar.Location = new Point(150,120);
            btnAceptar.Size = new Size(150, 50);
            btnAceptar.Text = "Aceptar";
            btnAceptar.Click += new EventHandler(btnAceptar_Click);

            this.Controls.Add(lbNombre);
            this.Controls.Add(txtbNombre);
            this.Controls.Add(btnAceptar);


        }
       
    }
}
