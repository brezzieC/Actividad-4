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
                new oVentas { IdEmpleado = 1, Nombre = "Armando Casas", Edad = 20, Cargo = "Jefe", FechaContrato = new DateTime(2020, 1, 15), Cuota = 10, Ventas = 1, idJefe= 1, idSucursales=1 },
                new oVentas { IdEmpleado = 2, Nombre = "Nombre 1", Edad = 28, Cargo = "Vendedor", FechaContrato = new DateTime(2019, 3, 22), Cuota = 10, Ventas = 50, idJefe= 1, idSucursales=2 },
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
            var numMax = listaRep.Select(r => r.IdEmpleado).Max() + 1;
            nuevoRepresentante.IdEmpleado = numMax;
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
