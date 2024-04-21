namespace Bridge
{
    public class EmpleadoPorContrato : IEmpleado
    {
        public string Nombre { get; }
        public string Posicion { get; }
        public int Salario { get; }


        public EmpleadoPorContrato(string nombre, string posicion, int salario)
        {
            Nombre = nombre;
            Posicion = posicion;
            Salario = salario;
        }

        public void VerDetalleEmpleado()
        {
            Console.WriteLine($"Nombre: {Nombre}, Posición: {Posicion}, Salario: {Salario}");
        }
    }
}