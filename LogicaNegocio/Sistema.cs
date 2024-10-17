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
    }
}
