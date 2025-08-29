using Logica;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantess
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiante;
        //private Librarys librarys;
        public Form1()
        {
            InitializeComponent();
            //librarys = new Librarys();
            var listTexBox = new List<TextBox>();
            listTexBox.Add(textBnId);
            listTexBox.Add(textBname);
            listTexBox.Add(textBlastName);
            listTexBox.Add(textBemail);
            var listLabel = new List<Label>();
            listLabel.Add(labelNid);
            listLabel.Add(labelName);
            listLabel.Add(labelLastName);
            listLabel.Add(labelEmail);
            listLabel.Add(labelPaginas);
            Object[] objects = { pictureBoxImage,
                Properties.
                Resources.images1, 
                dataGridView1,
            numericUpDown1};
            estudiante = new LEstudiantes(listTexBox, listLabel, objects);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadimage.CargarImagen(pictureBoxImage);

        }

        private void textBnId_TextChanged(object sender, EventArgs e)
        {
            if (textBnId.Text.Equals(""))
            {
                labelNid.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                labelNid.ForeColor = System.Drawing.Color.Green;
                labelNid.Text = "N°Id";
            }
        }

        private void textBnId_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.numberKeyPress(e);
        }

        private void textBname_TextChanged(object sender, EventArgs e)
        {
            if (textBname.Text.Equals(""))
            {
                labelName.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                labelName.ForeColor = System.Drawing.Color.Green;
                labelName.Text = "Nombre";
            }

        }

        private void textBname_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void textBlastName_TextChanged(object sender, EventArgs e)
        {

            if (textBlastName.Text.Equals(""))
            {
                labelLastName.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                labelLastName.ForeColor = System.Drawing.Color.Green;
                labelLastName.Text = "Apellido";
            }
        }

        private void textBlastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void textBemail_TextChanged(object sender, EventArgs e)
        {
            if (textBemail.Text.Equals(""))
            {
                labelEmail.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                labelEmail.ForeColor = System.Drawing.Color.Green;
                labelEmail.Text = "Email";
            }

        }

        private void textBemail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            estudiante.Register();
        }

        private void txtBSearch_TextChanged(object sender, EventArgs e)
        {
            estudiante.SearchEstudiantes(txtBSearch.Text);
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Primero");
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Anterior");
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Siguiente");
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Ultimo");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            estudiante.Registro_Paginas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                estudiante.GetEstudiante();
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                estudiante.GetEstudiante();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            estudiante.Restablecer();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            estudiante.Eliminar();
        }
    }
}
