using APLICATION.controllers;
using DAL.api.Empleado;
using LAUCHA.application.DTOs.EmpleadoDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.screens
{
    public partial class VerEmpleados : Form
    {
        private EmpleadoController _empleadoController;
        public VerEmpleados()
        {
            InitializeComponent();
            _empleadoController = new();
        }

        private async void ClickBtnConsultar(object sender, EventArgs e)
        {
           List<EmpleadoDTO> lista = await _empleadoController.ConseguirEmpleados();
           
            dataEmpleados.DataSource = lista;
             
        }

        private void VerEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
