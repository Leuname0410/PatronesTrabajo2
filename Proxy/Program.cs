
using Proxy;

Console.WriteLine("");
IEmpleado auntenicarEmpleadoProxy = new AutenticarEmpleadoProxy("admin", "password", "Maria Rodriguez", "Diseñadora", 2800000);
auntenicarEmpleadoProxy.VerDetalleEmpleado();

Console.WriteLine("");
Console.WriteLine("El siguiente mensaje muestra el error de la autenticación:");
IEmpleado auntenicarEmpleadoProxyError = new AutenticarEmpleadoProxy("admin", "pass", "Maria Rodriguez", "Diseñadora", 2800000);
auntenicarEmpleadoProxyError.VerDetalleEmpleado();