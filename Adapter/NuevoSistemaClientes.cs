
namespace Adapter
{
    public class NuevoSistemaClientes : INuevoSistemaClientes
    {
        public string GetDatosClienteJSON()
        {
            string DatosClienteJSON = "{\"nombre\": \"Laura Castillo\", \"correo\": \"laura@correo.com\", \"telefono\": \"123654987\"}";
            Console.WriteLine("");
            return DatosClienteJSON;
        }
    }
}
