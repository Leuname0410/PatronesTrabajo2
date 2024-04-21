namespace Adapter
{
    public class SistemaFacturacionInterna : ISistemaFacturacionInterna
    {
        public void ProcesarDatosCliente(string DAtosCliente)
        {
            Console.WriteLine("Datos deL Cliente en formato XML: ");
            Console.WriteLine("");
            Console.WriteLine("Datos deL Cliente procesados correctamente: ");
        }
    }
}