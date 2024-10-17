namespace LogicaNegocio
{
    public class Cliente
    {
        private string _cedula;
        private string _nombre;
        private string _tel;

        public Cliente(string cedula, string nombre, string tel)
        {
            this._cedula = cedula;
            this._nombre = nombre;
            this._tel = tel;
        }
    }
}
