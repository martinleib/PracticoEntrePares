﻿namespace LogicaNegocio
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
    }
}