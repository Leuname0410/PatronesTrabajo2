

namespace Bridge
{
       abstract class CategoriaEmpleado
    {
        protected IEmpleado _empleado;

        public CategoriaEmpleado(IEmpleado empleado)
        {
            this._empleado = empleado;
        }
        public abstract void VerCategoria();
    }
}
