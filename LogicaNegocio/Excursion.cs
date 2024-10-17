namespace LogicaNegocio
{
    public abstract class Excursion
    {
        protected string _codigo;
        protected string _descripcion;
        protected DateTime _fecha;
        protected int _cantDias;
        protected double _costoDiario;

        public Excursion(string codigo, string descripcion, DateTime fecha, int cantDias, double costoDiario)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._fecha = fecha;
            this._cantDias = cantDias;
            this._costoDiario = costoDiario;
        }

        public string Codigo
        {
            get { return _codigo; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
        }

        public override string ToString()
        {
            return $"Codigo: {_codigo}, Descripcion {_descripcion}, Fecha {_fecha}, Cantidad de dias {_cantDias}";
        }
    }
}
