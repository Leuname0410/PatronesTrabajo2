
namespace Bridge
{
    class EmpleadoTiempoParcial : CategoriaEmpleado
    {
        public EmpleadoTiempoParcial(IEmpleado empleado) : base(empleado)
        { }   
        public override void VerCategoria()
        {
            Console.WriteLine("Empleado a Tiempo Parcial");
            _empleado.VerDetalleEmpleado();

        }
    }
}
