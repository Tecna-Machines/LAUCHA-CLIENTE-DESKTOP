using LAUCHA.application.DTOs.EmpleadoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DAL.api.Empleado
{
    public class EmpleadoService
    {
        private readonly HttpClient _client;

        public EmpleadoService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<EmpleadoDTO>> ConsultarEmpleados()
        {
            List<EmpleadoDTO>? listaEmpleados = new List<EmpleadoDTO>();

            HttpResponseMessage response = await _client.GetAsync("https://localhost:7033/api/v1/Empleado");

            if (response.IsSuccessStatusCode)
            {
                // Aquí debes deserializar la respuesta del servidor a una lista de EmpleadoDTO
                var json = await response.Content.ReadAsStringAsync();
                listaEmpleados = JsonConvert.DeserializeObject<List<EmpleadoDTO>>(json);
            }

            return listaEmpleados;
        }

        public async Task<EmpleadoDTO> CrearEmpleadoNuevo(CrearEmpleadoDTO empleadoNuevo)
        {
            //convertir el objeto empleadoNuevo a JSON
            string json = JsonConvert.SerializeObject(empleadoNuevo);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            //solicitud POST a la API
            HttpResponseMessage response = await _client.PostAsync("https://localhost:7033/api/v1/Empleado", content);

            // Verificar si la solicitud fue exitosa
            if (response.IsSuccessStatusCode)
            {
                // Leer y deserializar la respuesta del servidor
                string responseData = await response.Content.ReadAsStringAsync();
                EmpleadoDTO nuevoEmpleado = JsonConvert.DeserializeObject<EmpleadoDTO>(responseData);

                return nuevoEmpleado;
            }
            else
            {
                throw new Exception($"Error al crear empleado: {response.ReasonPhrase}");
            }
        }
    }

}
