using DAL.api.Empleado;
using LAUCHA.application.DTOs.EmpleadoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.controllers
{
    public class EmpleadoController
    {
        private readonly HttpClient httpClient;
        private readonly EmpleadoService _empleadoService;

        public EmpleadoController()
        {
            this.httpClient = new HttpClient();
            _empleadoService = new EmpleadoService(this.httpClient);
        }

        public async Task<List<EmpleadoDTO>> ConseguirEmpleados()
        {
            return await _empleadoService.ConsultarEmpleados();
        }

        public async Task<EmpleadoDTO> CrearEmpleado(CrearEmpleadoDTO empleado)
        {
            return await _empleadoService.CrearEmpleadoNuevo(empleado);
        }
    }
}
