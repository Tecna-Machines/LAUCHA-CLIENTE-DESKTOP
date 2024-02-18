using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.screens;

namespace UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ClickBtnCrearEmp(object sender, EventArgs e)
        {
            CrearEmpleado formEmpleado = new();
            formEmpleado.Show();
        }

        private void ClickBtnConsultar(object sender, EventArgs e)
        {
            VerEmpleados empleadosForm = new();
            empleadosForm.Show();
        }
    }
}
