using LogicaNegocio;
using System.ComponentModel.Design;

namespace InterfazUsuario
{
    internal class Program
    {
        static Sistema miSistema = new Sistema();

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool salio = false;
            while (!salio)
            {
                Console.WriteLine("1- Agregar Cliente");
                int.TryParse(Console.ReadLine(), out int ingreso);

                switch (ingreso)
                {
                    case 1:
                        AltaCliente();
                        break;
                    case 0:
                        salio = true;
                        break;
                }
            }
        }

        static void AltaCliente()
        {
            try { 
                Console.WriteLine("Ingrese nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese cedula");
                string cedula = Console.ReadLine();
                Console.WriteLine("Ingrese telefono");
                string telefono = Console.ReadLine();
                miSistema.AgregarCliente(cedula, nombre, telefono);
                Console.WriteLine("Cliente creado de manera exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
