namespace Proxy
{
    public class AutenticarEmpleadoProxy : IEmpleado
    {

        private readonly Empleado _empleado;
        private readonly string _usuario;
        private readonly string _password;

        public AutenticarEmpleadoProxy(string usuario, string password, string nombre, string posicion, int salario)
        {
            _empleado = new Empleado(nombre, posicion, salario);
            _usuario = usuario;
            _password = password;
        }

        public string Nombre => _empleado.Nombre;
        public string Posicion => _empleado.Posicion;
        public int Salario => _empleado.Salario;


        public void VerDetalleEmpleado()
        {
            if (Autenticado(_usuario, _password))
            {
                Console.WriteLine("Autenticación Exitosa. Has accedido a los detalles del Empleado.");
                _empleado.VerDetalleEmpleado();
            }
            else
            {
                Console.WriteLine("Autenticación Erronea. No puedes acceder a los detalles del Empleado.");
            }
        }

        private bool Autenticado(string usuario, string password)
        {
            return usuario == "admin" && password == "password";
        }
    }

}
