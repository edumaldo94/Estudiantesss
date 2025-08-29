using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }//permite ingresar datos de tipo texto

            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }//permite no dar salto de linea cuando se oprime Enter

            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }//permite utilizar la tecla brackspace

            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; } //permite utilizar la tecla de espacio

            else { e.Handled = true; }
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }//permite ingresar datos de tipo number

            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }//permite no dar salto de linea cuando se oprime Enter

            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }//no permite ingresar datos de tipo texto

            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }//permite utilizar la tecla brackspace

            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; } //permite utilizar la tecla de espacio

            else { e.Handled = true; }
        }

        public bool comprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
