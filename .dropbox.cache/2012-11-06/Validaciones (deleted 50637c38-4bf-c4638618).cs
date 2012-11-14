using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rSunat.ReportesSunat.Presentacion
{
    public class Validaciones
    {

        public void SoloLetras(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if (char.IsLetter(letras)) //Solo letras
            {
                e.Handled = false; 
            }

            else if (char.IsControl(letras)) //Para retroceder(borrar)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }

        }


        public void SoloNumeros(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if (char.IsDigit(letras)) //Acepta solo NUMEROS
            {
                e.Handled = false;
            }

            else if (char.IsControl(letras))  //Para poder RETROCEDER (BORRAR)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }

       
 }

    }
}

