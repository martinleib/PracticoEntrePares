namespace LogicaNegocio
{
    public class Nacional:Excursion
    {
        private int _cantMaxima;
        private int _porcentaje;
        public Nacional(string codigo, string descripcion, DateTime fecha, int cantDias, double costoDiario, int cantMaxima, int porcentaje) : base(codigo, descripcion, fecha, cantDias, costoDiario)
        {
            this._cantMaxima = cantMaxima;
            this._porcentaje = porcentaje;
        }

        public override double CalcularCostoExcursion(int cantPasajeros)
        {
            double precio = _cantDias * _costoDiario * cantPasajeros;
            if (cantPasajeros > 2)
            {
                precio = precio - (precio * _porcentaje / 100);
            }
            return precio;
        }

    }
}
