namespace LogicaNegocio
{
    public class Sistema
    {
        List<Cliente> _clientes = new List<Cliente>();
        List<Excursion> _excursiones = new List<Excursion>();

        public void AgregarCliente(string cedula, string nombre, string tel)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                throw new Exception("La cedula no es valida. Ingrese de vuelta");
            } else if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("El nombre no es valido. Ingrese de vuelta");
            } else if (string.IsNullOrEmpty(tel))
            {
                throw new Exception("El telefono no es valido. Ingrese de vuelta");
            }


            Cliente cliente = new(cedula, nombre, tel);

            if (!_clientes.Contains(cliente))
            {
                _clientes.Add(cliente);
            }
        }

        private void AltaExcursionNacional(string codigo, string descripcion, DateTime fecha, int cantDias, double costoDiario, int cantMaxima, int porcentaje)
        {
            Nacional excursion = new Nacional(codigo, descripcion, fecha, cantDias, costoDiario, cantMaxima, porcentaje);
            if (!_excursiones.Contains(excursion))
            {
                _excursiones.Add(excursion);
            }
        }

        private void PrecargaExcursionNacional()
        {
            AltaExcursionNacional("1", "Viaje corto", new DateTime(2024,06, 01), 4, 10.99, 4 , 10);
            AltaExcursionNacional("2", "Viaje corto", new DateTime(2024, 04, 07), 7, 20.99, 7, 5);
            AltaExcursionNacional("3", "Viaje Largo", new DateTime(2024, 06, 02), 6, 15.99, 6, 15);
        }

        private void AltaExcursionExtranjero(string codigo, string descripcion, DateTime fecha, int cantDias, double costoDiario, bool tienePasaje)
        {
            Extranjero excursion = new Extranjero(codigo, descripcion, fecha, cantDias, costoDiario, tienePasaje);
            if (!_excursiones.Contains(excursion))
            {
                _excursiones.Add(excursion);
            }
        }

        private void PrecargaExcursionExtranjero()
        {
            AltaExcursionExtranjero("1", "Viaje corto", new DateTime(2024, 06, 01), 4, 10.99, true);
            AltaExcursionExtranjero("2", "Viaje corto", new DateTime(2024, 04, 07), 7, 20.99, false);
            AltaExcursionExtranjero("3", "Viaje Largo", new DateTime(2024, 06, 02), 6, 15.99, false);
        }
    }
}
