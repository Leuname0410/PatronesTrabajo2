using Bridge;

IEmpleado empleado1 = new EmpleadoRegular("Alex Mendoza", "Director", 5000000);
IEmpleado empleado2 = new EmpleadoPorContrato("Milena Caro", "Desarrollador", 4000000);

// Categoria por empleados
CategoriaEmpleado empleadoTiempoCompleto = new EmpleadoTiempoCompleto(empleado1);
CategoriaEmpleado empleadoTiempoParcial = new EmpleadoTiempoParcial(empleado2);


// Ver detalles de los empleados según la categoría.
empleadoTiempoCompleto.VerCategoria();
Console.WriteLine();
empleadoTiempoParcial.VerCategoria();
    