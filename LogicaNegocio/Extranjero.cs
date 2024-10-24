namespace LogicaNegocio
{
    public class Extranjero:Excursion
    {
        private bool _tienePasaje;
        private static double s_seguro;

        public Extranjero(string codigo, string descripcion, DateTime fecha, int cantDias, double costoDiario, bool tienePasaje):base(codigo, descripcion, fecha, cantDias, costoDiario)
        {
            this._tienePasaje = tienePasaje;
        }

        public override double CalcularCostoExcursion(int cantPasajeros)
        {
            double precio = +_cantDias * _costoDiario * cantPasajeros;
            return precio + (s_seguro * _cantDias);
        }

        public double Seguro
        {
            get { return s_seguro; }
            set { s_seguro = value; }
        }
    }
}
