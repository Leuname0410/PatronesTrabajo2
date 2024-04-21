namespace Bridge
{
    public class EmpleadoRegular : IEmpleado
    {
        public string Nombre { get; }
        public string Posicion { get; }
        public int Salario { get; }


        public EmpleadoRegular(string nombre, string posicion, int salario)
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
