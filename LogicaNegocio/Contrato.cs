namespace LogicaNegocio
{
    public class Contrato
    {
        private double _precio;
        private int _cantPasajeros;
        private Excursion _excursion;

        public Contrato(double precio, int cant, Excursion excursion)
        {
            this._precio = precio;
            this._cantPasajeros = cant;
            this._excursion = excursion;
        }
    }
}
