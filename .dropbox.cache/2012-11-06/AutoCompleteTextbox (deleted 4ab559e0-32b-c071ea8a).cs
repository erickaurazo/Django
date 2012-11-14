using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAutoComplete
{
    public partial class AutoCompleteTextbox : Form
    {
        public AutoCompleteTextbox()
        {
            InitializeComponent();
        }

        private void AutoCompleteTextbox_Load(object sender, EventArgs e)
        {
 
            //
            // cargo la lista de items para el autocomplete
            //
            textBox1.AutoCompleteCustomSource = DataHelper.LoadAutoComplete();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
