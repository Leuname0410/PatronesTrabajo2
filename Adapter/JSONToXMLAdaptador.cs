using Newtonsoft.Json;

namespace Adapter
{
    public class JSONToXMLAdaptador : ISistemaFacturacionInterna
    {
        private readonly INuevoSistemaClientes _nuevoSistemaClientes;

        public JSONToXMLAdaptador(INuevoSistemaClientes nuevoSistemaClientes)
        {
            _nuevoSistemaClientes = nuevoSistemaClientes;
        }

        public void ProcesarDatosCliente(string DAtosCliente)
        {
            Console.WriteLine("Adaptando los datos de cliente de JSON a XML...");
            
            try
            {
                // Convertir los datos del cliente de JSON a XML
                string DatosClienteJSON = _nuevoSistemaClientes.GetDatosClienteJSON();
                string DatosClienteXML = JsonConvert.DeserializeXmlNode(DatosClienteJSON, "Cliente").OuterXml;

                // Imprimir los datos del cliente en formato XML
                Console.WriteLine("...Datos adaptados correctamente...");

                Console.WriteLine("...Datos del cliente en formato XML:");
                Console.WriteLine(DatosClienteXML);
             
                Console.WriteLine("...Datos del cliente procesados correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir los datos del cliente de JSON a XML:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}