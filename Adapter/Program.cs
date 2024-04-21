using Adapter;

ISistemaFacturacionInterna sistemaFacturacionInterna = new SistemaFacturacionInterna();
INuevoSistemaClientes nuevoSistemaClientes = new NuevoSistemaClientes();

// Utilizar un adaptador para que el sistema de facturación procese los datos en formato JSON
ISistemaFacturacionInterna adaptador = new JSONToXMLAdaptador(nuevoSistemaClientes);

// Simular los datos de cliente en el sistema de facturación interno
adaptador.ProcesarDatosCliente(nuevoSistemaClientes.GetDatosClienteJSON());