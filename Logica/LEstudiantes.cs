
using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEstudiantes : Librarys//Herencia
    {
        private List<TextBox> listTexBox;
        private List<Label> listLabel;
        private PictureBox image;
        private Bitmap _imageBitmap;
        private DataGridView _dataGridView;
        private NumericUpDown _numeroicUpDown;
        Paginador<Estudiante> _paginador;
        private string _accion= "insertar";
        //   private Librarys librarys;
        public LEstudiantes(List<TextBox> listTexBox, List<Label> listLabel, object[] objects)
        {
            this.listTexBox = listTexBox;
            this.listLabel = listLabel;
         //   librarys = new Librarys();
            image = (PictureBox)objects[0];
            _imageBitmap = (Bitmap)objects[1];
            _dataGridView = (DataGridView)objects[2];
            _numeroicUpDown = (NumericUpDown)objects[3];

            Restablecer();
        }

        public void Register()
        {

            if (listTexBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "Nid es requerido";
                listLabel[0].ForeColor = System.Drawing.Color.Red; ;
                listTexBox[0].Focus();

            }
            else
            {
                if (listTexBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "Nombre es requerido";
                    listLabel[1].ForeColor = System.Drawing.Color.Red; ;
                    listTexBox[1].Focus();

                }else
                {
                    if (listTexBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "Apellido es requerido";
                        listLabel[2].ForeColor = System.Drawing.Color.Red; ;
                        listTexBox[2].Focus();

                    }
                    else
                    {
                        if (listTexBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "Email es requerido";
                            listLabel[3].ForeColor = System.Drawing.Color.Red; ;
                            listTexBox[3].Focus();

                        }
                        else
                        {
                            if (textBoxEvent.comprobarFormatoEmail(listTexBox[3].Text))
                            {
                              var user = _Estudiantes.Where(s => s.email.Equals(listTexBox[3].Text)).ToList();
                                if(user.Count == 0)
                                {
                                    save();
                                    MessageBox.Show("Estudiante registrado");
                                }
                                else
                                {
                                    if (user[0].Id.Equals(_idEstudiante))
                                    {
                                        save();
                                    }
                                    else
                                    {
                                        listLabel[3].Text = "Email ya existe";
                                        listLabel[3].ForeColor = System.Drawing.Color.Red; ;
                                        listTexBox[3].Focus();
                                 
                                    }


                                  
                                }
                            }
                            else
                            {
                                listLabel[3].Text = "Email no valido";
                                listLabel[3].ForeColor = System.Drawing.Color.Red; ;
                                listTexBox[3].Focus();
                            }

                        }
                    }
                }
            }
        }
 private void save()
        {
            BeginTransactionAsync();
            try
            {


                var imageArray = uploadimage.ImageToByte(image.Image);
                switch(_accion)
                {
                    case "insert":
                        _Estudiantes.Value(s => s.nid, listTexBox[0].Text)
                    .Value(s => s.nombre, listTexBox[1].Text)
                    .Value(s => s.apellido, listTexBox[2].Text)
                    .Value(s => s.email, listTexBox[3].Text)
                    .Value(s => s.image, imageArray)
                    .Insert();
                        break;
                    case "update":
                        _Estudiantes.Where(s => s.Id.Equals(_idEstudiante))
              .Set(s => s.nid, listTexBox[0].Text)
              .Set(s => s.nombre, listTexBox[1].Text)
              .Set(s => s.apellido, listTexBox[2].Text)
              .Set(s => s.email, listTexBox[3].Text)
              .Set(s => s.image, imageArray)
              .Update();
                        break;
                    default:
                        break;
                }
                //var db = new Conexion();
                //db.Insert(new Estudiante
                //{
                //    nid= listTexBox[0].Text,
                //    nombre= listTexBox[1].Text,
                //    apellido= listTexBox[2].Text,
                //    email= listTexBox[3].Text,
                //});
                
           //     int data = Convert.ToInt16("k");
                CommitTransaction();
                Restablecer();
            }
            catch (Exception)
            {
                RollbackTransaction();

            }

        }
        private int _num_pagina = 1, _reg_por_pagina = 2;
        public void SearchEstudiantes(string campo)
        {
            List<Estudiante> query = new List<Estudiante>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if(campo.Equals(""))
            {
                query = _Estudiantes.ToList();
            }
            else
            {
                query = _Estudiantes.Where(s => s.nid.StartsWith(campo) || s.nombre.StartsWith(campo) || s.apellido.StartsWith(campo) || s.email.StartsWith(campo)).ToList();
            }
            if(0 < query.Count)
            {
                _dataGridView.DataSource= query.Select(s => new { 
                    s.Id, 
                    s.nid, 
                    s.nombre, 
                    s.apellido, 
                    s.email,
                    s.image
                }).Skip(inicio).Take(_reg_por_pagina).ToList();
                _dataGridView.Columns[0].Visible = false;
                _dataGridView.Columns[5].Visible = false; //ocultar columna imagen
                _dataGridView.Columns[1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                _dataGridView.Columns[3].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            else
            {
                _dataGridView.DataSource = query.Select(s => new {
                    s.Id,
                    s.nid,
                    s.nombre,
                    s.apellido,
                    s.email
                }).ToList();
            }
        
        }
        private int _idEstudiante;
        public void GetEstudiante()
        {
            _accion = "update";
            _idEstudiante = Convert.ToInt16(_dataGridView.CurrentRow.Cells[0].Value);
            listTexBox[0].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[1].Value);
            listTexBox[1].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[2].Value);
            listTexBox[2].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[3].Value);
            listTexBox[3].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[4].Value);
            try
            {
                byte[] imageArray = (byte[])_dataGridView.CurrentRow.Cells[5].Value;
                image.Image = uploadimage.byteArrayToImage(imageArray);
            }
            catch (Exception)
            {
image.Image = _imageBitmap;
            }
            
        }

        private List<Estudiante> listEstudiante;
        public void Paginador(string accion)
        {
        
            switch (accion)
            {
                case "Primero":
                    _num_pagina = _paginador.primero();
                    break;
                case "Anterior":
                    _num_pagina = _paginador.anterior();
                    break;
                case "Siguiente":
                    _num_pagina = _paginador.siguiente();
                    break;
                case "Ultimo":
                    _num_pagina = _paginador.ultimo();
                    break;
                default:
                    break;
            }
            SearchEstudiantes("");
        }
        public void Registro_Paginas()
        {
            _num_pagina= 1;
            _reg_por_pagina = (int)_numeroicUpDown.Value;
            var list = _Estudiantes.ToList();
            if (0 < list.Count)
            {
                _paginador = new Paginador<Estudiante>(list, listLabel[4], _reg_por_pagina);
                SearchEstudiantes("");
            }
        }

        public void Restablecer()
        {
            _accion = "insert";
            _idEstudiante = 0;
            image.Image = _imageBitmap;
            listLabel[0].Text = "N°Id";
            listLabel[1].Text = "Nombre";
            listLabel[2].Text = "Apellido";
            listLabel[3].Text = "Email";
            foreach (var item in listTexBox)
            {

                item.Text = "";
                item.ForeColor = System.Drawing.Color.LightSlateGray;
            }
            listEstudiante= _Estudiantes.ToList();
            if(0 <listEstudiante.Count )
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);

            }
            SearchEstudiantes("");
        }
        public void Eliminar()
        {
            if (_idEstudiante.Equals(0))
            {
                MessageBox.Show("Seleccione un estudiante");
            }else
            {
                               var result = MessageBox.Show("¿Esta seguro de eliminar el estudiante?", "Eliminar estudiante", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    _Estudiantes.Where(s => s.Id.Equals(_idEstudiante)).Delete();
                    MessageBox.Show("Estudiante eliminado");
                    Restablecer();
                }
            }
        }
    }
   
}
