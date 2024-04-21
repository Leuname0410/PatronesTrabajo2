namespace Proxy
{
    public class Empleado : IEmpleado
    {
        public string Nombre { get; }
        public string Posicion { get; }
        public int Salario { get; }

        public Empleado(string nombre, string posicion, int salario) 
        { 
            Nombre = nombre; 
            Posicion = posicion; 
            Salario = salario; 
        }

        public void VerDetalleEmpleado()
        {
            Console.WriteLine($"Nombre: {Nombre}, Posicion: {Posicion}, Salario: {Salario}");
        }
    }
}
