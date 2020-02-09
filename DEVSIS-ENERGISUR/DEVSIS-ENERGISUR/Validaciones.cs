using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    class Validaciones
    {
        public void Nombres(KeyPressEventArgs evento)
        {
            try
            {
                if (Char.IsLetter(evento.KeyChar)) //Permite solo usar las teclas de letras
                {
                    evento.Handled = false;
                }
                else if (Char.IsControl(evento.KeyChar)) //Permite que se use la tecla para borrar
                {
                    evento.Handled = false;
                }
                else if (Char.IsSeparator(evento.KeyChar)) //Permite que se use la barra espaciadora
                {
                    evento.Handled = false;
                }
                else
                {
                    evento.Handled = true;
                }
            }
            catch (Exception e)
            {

            }
        }
        public void Numeros(KeyPressEventArgs evento)
        {
            try
            {
                if (Char.IsNumber(evento.KeyChar)) //Permite solo usar las teclas de números
                {
                    evento.Handled = false;
                }
                else if (Char.IsControl(evento.KeyChar)) //Permite que se use la tecla para borrar
                {
                    evento.Handled = false;
                }
                else
                {
                    evento.Handled = true;
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
