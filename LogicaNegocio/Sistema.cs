using System.Timers;

namespace LogicaNegocio
{
    public class Sistema
    {
        List<Cliente> _clientes = new List<Cliente>();
        List<Excursion> _excursiones = new List<Excursion>();
        List<Contrato> _contratos = new List<Contrato>();

        public void AgregarCliente(string cedula, string nombre, string tel)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                throw new Exception("La cedula no es valida. Ingrese de vuelta");
            }
            else if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("El nombre no es valido. Ingrese de vuelta");
            }
            else if (string.IsNullOrEmpty(tel))
            {
                throw new Exception("El telefono no es valido. Ingrese de vuelta");
            }


            Cliente cliente = new(cedula, nombre, tel);

            if (!_clientes.Contains(cliente))
            {
                _clientes.Add(cliente);
            }
        }

        public List<Contrato> ObtenerContrato(int idContrato)
        {
            List<Contrato> contratoEncontrado = null;
            foreach (Contrato contrato in _contratos)
            {
                if (contrato.Id == idContrato)
                {
                    contratoEncontrado.Add(contrato);
                }
            }

            return contratoEncontrado;
        }

        public void AltaContrato(double precio, int cantPasajeros, string idExcursion, string cedula)
        {
            if (precio <= 0)
            {
                throw new Exception("El precio no es valido. Ingrese de vuelta");
            }
            else if (cantPasajeros <= 0)
            {
                throw new Exception("La cantidad de pasajeros no es valida. Ingrese de vuelta");
            }
            else if (ObtenerExcursionPorID(idExcursion) == null)
            {
                throw new Exception("No existe una excursion con ese codigo");
            }

            Contrato contrato = new(precio, cantPasajeros, ObtenerExcursionPorID(idExcursion), ObtenerClientePorCedula(cedula));

            if (!_contratos.Contains(contrato))
            {
                _contratos.Add(contrato);
            }
        }
        
        public void PrecargaContratos()
        {
            AltaContrato(100, 2, "1", "55748025");
            AltaContrato(200, 3, "2", "55748026");
            AltaContrato(300, 4, "3", "55748027");
        }

        public void PrecargaClientes()
        {
            AgregarCliente("55748025", "Juan", "099999999");
            AgregarCliente("55748026", "Pedro", "099999998");
            AgregarCliente("55748027", "Maria", "099999997");
        }

        public double ObtenerCostoTotal(string cedula)
        {
            Cliente cliente = ObtenerClientePorCedula(cedula);
            double precioAcumulado = 0;

            foreach (Contrato contrato in _contratos)
            {
                if (contrato.Cliente == cliente)
                {
                    precioAcumulado += contrato.CostoContrato();
                }
            }

            return precioAcumulado;
        }

        public Excursion ObtenerExcursionPorID(string codigoExcursion)
        {
            Excursion excursionEncontrada = null;
            foreach (Excursion excursion in _excursiones)
            {
                if (excursion.Codigo == codigoExcursion)
                {
                    excursionEncontrada = excursion;
                }
            }

            return excursionEncontrada;
        }

        public Cliente ObtenerClientePorCedula(string cedula)
        {
            Cliente clienteEncontrado = null;
            foreach (Cliente cliente in _clientes)
            {
                if (cliente.Cedula == cedula)
                {
                    clienteEncontrado = cliente;
                }
            }

            return clienteEncontrado;
        }
        public List<Excursion> ObtenerExcursionesEntreFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Excursion> excursion = new List<Excursion>();
            int i = 0;
            while (i < _excursiones.Count)
            {
                if (_excursiones[i].Fecha >= fechaInicio && _excursiones[i].Fecha <= fechaFinal)
                {
                    excursion.Add(_excursiones[i]);
                }
                i++;
            }
            return excursion;
        }

        public void AltaExcursionNacional(string codigo, string descripcion, DateTime fecha, int cantDias, double costoDiario, int cantMaxima, int porcentaje)
        {
            Nacional excursion = new Nacional(codigo, descripcion, fecha, cantDias, costoDiario, cantMaxima, porcentaje);
            if (!_excursiones.Contains(excursion))
            {
                _excursiones.Add(excursion);
            }
        }

        public void PrecargaExcursionNacional()
        {
            AltaExcursionNacional("1", "Viaje corto", new DateTime(2024, 06, 01), 4, 10.99, 4, 10);
            AltaExcursionNacional("2", "Viaje corto", new DateTime(2024, 04, 07), 7, 20.99, 7, 5);
            AltaExcursionNacional("3", "Viaje Largo", new DateTime(2024, 06, 02), 6, 15.99, 6, 15);
        }

        public void AltaExcursionExtranjero(string codigo, string descripcion, DateTime fecha, int cantDias, double costoDiario, bool tienePasaje)
        {
            Extranjero excursion = new Extranjero(codigo, descripcion, fecha, cantDias, costoDiario, tienePasaje);
            if (!_excursiones.Contains(excursion))
            {
                _excursiones.Add(excursion);
            }
        }

        public void PrecargaExcursionExtranjero()
        {
            AltaExcursionExtranjero("4", "Viaje corto", new DateTime(2024, 06, 01), 4, 10.99, true);
            AltaExcursionExtranjero("5", "Viaje corto", new DateTime(2024, 04, 07), 7, 20.99, false);
            AltaExcursionExtranjero("6", "Viaje Largo", new DateTime(2024, 06, 02), 6, 15.99, false);
        }
    }
}
