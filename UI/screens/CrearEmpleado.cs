using APLICATION.controllers;
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
    public partial class CrearEmpleado : Form
    {
        private EmpleadoController _empleadoController;

        public CrearEmpleado()
        {
            InitializeComponent();
            _empleadoController = new();
        }

        private async void ClickBtnCrearEmpleado(object sender, EventArgs e)
        {
            CrearEmpleadoDTO nuevoEmpleado = new CrearEmpleadoDTO
            {
                Nombre = nameInput.Text,
                Apellido = apellidoInput.Text,
                Dni = dniInput.Text,
                FechaNacimiento = fechaNac.Value,
                FechaIngreso = fechaIngreso.Value
            };

            // Llama al método para crear un nuevo empleado
            var nuevoEmpleadoCreado = await _empleadoController.CrearEmpleado(nuevoEmpleado);

            // Si la creación fue exitosa y se recibió un nuevo empleado
            if (nuevoEmpleadoCreado != null)
            {
                // Asigna el nuevo empleado al DataGridView
                dataGridEmpleado.DataSource = new List<EmpleadoDTO> { nuevoEmpleadoCreado };
            }
        }
    }
}
