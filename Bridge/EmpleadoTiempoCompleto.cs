

namespace Bridge
{
   class EmpleadoTiempoCompleto : CategoriaEmpleado
    {
        public EmpleadoTiempoCompleto(IEmpleado empleado) : base(empleado)
        {
        }

        public override void VerCategoria()
        {
            Console.WriteLine("Empleado a Tiempo Completo");
            _empleado.VerDetalleEmpleado();
        }
    }
}
