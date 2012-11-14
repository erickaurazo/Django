using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Configuration;

namespace WinAutoComplete
{
    public partial class AutoCompleteComboBox : Form
    {
        public AutoCompleteComboBox()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //
            // Cargo los datos del combobox
            //
            comboBox1.DataSource = DataHelper.LoadDataTable();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id"; 

            //
            // cargo la lista de items para el autocomplete
            //
            comboBox1.AutoCompleteCustomSource = DataHelper.LoadAutoComplete();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
   
            
        }



    }
}
