namespace LogicaNegocio
{
    public class Contrato
    {
        private double _precio;

        private static int s_UltimoId = 0;
        private int _id;
        private int _cantPasajeros;

        private Excursion _excursion;
        private Cliente _cliente;

        public Contrato(double precio, int cant, Excursion excursion, Cliente cliente)
        {
            this._id = s_UltimoId++;
            this._precio = precio;
            this._cantPasajeros = cant;
            this._excursion = excursion;
            this._cliente = cliente;
        }

        public int Id
        {
            get { return _id; }
        }

        public double Precio
        {
            get { return _precio;  }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
        }
    }
}
