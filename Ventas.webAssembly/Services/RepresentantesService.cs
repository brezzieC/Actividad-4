using Ventas.BlazorEntities;

namespace Ventas.webAssembly.Services
{
    public class RepresentantesService
    {
        public List<oVentas> listaRep;
        public RepresentantesService()
        {
            listaRep = new List<oVentas>
            {
                new oVentas { IdEmpleado = 1, Nombre = "Juan Perez", Edad = 30, Cargo = "Vendedor", FechaContrato = new DateTime(2020, 1, 15), Cuota = 5000, Ventas = 10 },
                new oVentas { IdEmpleado = 2, Nombre = "Maria Gomez", Edad = 25, Cargo = "Vendedor", FechaContrato = new DateTime(2019, 3, 22), Cuota = 7000, Ventas = 15 },
                new oVentas { IdEmpleado = 3, Nombre = "Carlos Lopez", Edad = 28, Cargo = "Vendedor", FechaContrato = new DateTime(2021, 6, 10), Cuota = 6000, Ventas = 8 },
                new oVentas { IdEmpleado = 4, Nombre = "Ana Martinez", Edad = 32, Cargo = "Vendedor", FechaContrato = new DateTime(2018, 11, 5), Cuota = 8000, Ventas = 20 },
                new oVentas { IdEmpleado = 5, Nombre = "Luis Rodriguez", Edad = 29, Cargo = "Vendedor", FechaContrato = new DateTime(2020, 7, 30), Cuota = 5500, Ventas = 12 }
            };
        }
        public List<oVentas> GetRepresentantes()
        {
            return listaRep;
        }
        public oVentas ObtenerRepresentante(int id)
        {
            var representante = listaRep.FirstOrDefault(r => r.IdEmpleado == id);
            if (representante != null)
            {
                return representante;
            }
            else
            {
                return new oVentas();
            }
        }
        public void EliminarRepresentante(int id)
        {
            var representante = listaRep.FirstOrDefault(r => r.IdEmpleado == id);
            if (representante != null)
            {
                listaRep.Remove(representante);
            }
        }
        public void AgregarRepresentante(oVentas nuevoRepresentante)
        {
            listaRep.Add(nuevoRepresentante);
        }
        public void ActualizarRepresentante(oVentas actualizarRep, int id)
        {
            var actualizar = listaRep.FirstOrDefault(r => r.IdEmpleado == id);
            if (actualizar != null)
            {
                actualizar.Nombre = actualizarRep.Nombre;
                actualizar.Edad = actualizarRep.Edad;
                actualizar.Cargo = actualizarRep.Cargo;
                actualizar.FechaContrato = actualizarRep.FechaContrato;
                actualizar.Cuota = actualizarRep.Cuota;
                actualizar.Ventas = actualizarRep.Ventas;
            }
        }
    }
}
