﻿namespace LogicaNegocio
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
    }
}
