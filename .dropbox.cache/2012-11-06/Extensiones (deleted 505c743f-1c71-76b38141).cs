using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public static class Extensiones
    {


        public static DataTable ToDataTable<T>(this List<T> items)
        {
            // Instancia del objeto a devolver
            DataTable returnValue = new DataTable();
            // Información del tipo de datos de los elementos del List
            Type itemsType = typeof(T);
            // Recorremos las propiedades para crear las columnas del datatable
            foreach (PropertyInfo prop in itemsType.GetProperties())
            {
                DataColumn column = new DataColumn(prop.Name);
                // Crearmos y agregamos una columna por cada propiedad de la entidad
                //FORMA 01
                //column.DataType = prop.PropertyType;
                //returnValue.Columns.Add(column);
                //FORMA 02 - ES MEJOR (CHRISTIAN)
                returnValue.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            int j;
            // ahora recorremos la colección para guardar los datos
            // en el DataTable
            foreach (T item in items)
            {
                j = 0;
                object[] newRow = new object[returnValue.Columns.Count];
                // Volvemos a recorrer las propiedades de cada item para
                // obtener su valor guardarlo en la fila de la tabla
                foreach (PropertyInfo prop in itemsType.GetProperties())
                {
                    newRow[j] = prop.GetValue(item, null);
                    j++;
                }
                returnValue.Rows.Add(newRow);
            }
            // Devolver el objeto creado
            return returnValue;
        }




        public static string ToDoublePresentation(this Double valor)
        {
            //Dim objCulture As Globalization.NumberFormatInfo = _	New Globalization.CultureInfo("ES-ES").NumberFormat
            System.Globalization.NumberFormatInfo objCulture =
            new System.Globalization.CultureInfo("ES-ES").NumberFormat;
            //Uno a uno cambiamos las propiedades de ese formato (en este caso estamos repitiendo valores por defecto para la demostración)
            objCulture.CurrencyDecimalDigits = 2;
            objCulture.CurrencyDecimalSeparator = ".";
            objCulture.CurrencyGroupSeparator = ",";
            objCulture.CurrencyNegativePattern = 1;
            objCulture.CurrencySymbol = "";

            string resultado = valor.ToString("C", objCulture);
            return resultado;
        }

        public static string ToInteger(this Double valor)
        {
            //Dim objCulture As Globalization.NumberFormatInfo = _	New Globalization.CultureInfo("ES-ES").NumberFormat
            System.Globalization.NumberFormatInfo objCulture =
                    new System.Globalization.CultureInfo("ES-ES").NumberFormat;
            //Uno a uno cambiamos las propiedades de ese formato (en este caso estamos repitiendo valores por defecto para la demostración)
            objCulture.CurrencyDecimalDigits = 0;
            objCulture.CurrencyDecimalSeparator = ".";
            objCulture.CurrencyGroupSeparator = ",";
            objCulture.CurrencyNegativePattern = 1;
            objCulture.CurrencySymbol = "";

            string resultado = valor.ToString("C", objCulture);
            return resultado.Trim();

        }

        public static string ToPresentationDate(this DateTime? fecha)
        {
            if (fecha != null)
            {
                string format = "{0:dd/MM/yyyy}";
                string retorn = string.Format(format, fecha);
                return retorn;
            }
            else
            {
                return "";
            }

        }

        /// <summary>
        /// Devuelve una cadena de fecha con formato dd/MM/yyyy
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static string ToPresentationDate(this DateTime fecha)
        {
            if (fecha != null)
            {
                string format = "{0:dd/MM/yyyy}";
                string retorn = string.Format(format, fecha);
                return retorn;
            }
            else
            {
                return "";
            }

        }

        /// <summary>
        /// Devuelve una cadena de fecha con formato dd/MM/yyyy HH:mm:ss
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static string ToPresentationDateTime(this DateTime fecha)
        {
            if (fecha != null)
            {
                string format = "{0:dd/MM/yyyy HH:mm:ss}";
                string retorn = string.Format(format, fecha);
                return retorn;
            }
            else
            {
                return "";
            }

        }

        /// <summary>
        /// Devuelve una cadena de fecha con formato yyyyyMMdd HH:mm:ss
        /// </summary>
        /// <param name="fecha">fecha que va a ser convertida</param>
        /// <returns></returns>
        public static string ToFormatDateTime(this DateTime fecha)
        {
            if (fecha != null)
            {
                string format = "{0:yyyyMMdd HH:mm:ss}";
                string retorn = string.Format(format, fecha);
                return retorn;
            }
            else
            {
                return "";
            }

        }

        /// <summary>
        /// Devuelve una cadena de fecha con formato yyyyyMMdd HH:mm:ss
        /// </summary>
        /// <param name="fecha">fecha que va a ser convertida</param>
        /// <returns></returns>
        public static string ToFormatDate(this DateTime fecha)
        {
            if (fecha != null)
            {
                string format = "{0:yyyyMMdd}";
                string retorn = string.Format(format, fecha);
                return retorn;
            }
            else
            {
                return "";
            }

        }

        public static string ToCopyInsertLeft(this string cadena, string caracter, int count)
        {
            string repetidos = string.Empty;
            if (cadena != string.Empty)
            {
                for (int i = 0; i < count; i++)
                {
                    repetidos += "0";
                }
                cadena = repetidos + cadena;
            }
            return cadena;
        }

        public static string ToCopyInsertRight(this string cadena, string caracter, int count)
        {
            string repetidos = string.Empty;
            if (cadena != string.Empty)
            {
                for (int i = 0; i < count; i++)
                {
                    repetidos += "0";
                }
                cadena = repetidos + cadena;
            }
            return cadena;
        }




    }
}
