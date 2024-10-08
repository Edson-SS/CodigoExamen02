using CodigoExamen02.Clases;
using CodigoExamen02.Interfaces;


void QuintaParte()
{
    int opcion = 0;
    int opcionPuesto = 0;
    int idEmpleado = 0;
    decimal SumaTotalSueldo = 0;
    List<IEmpleado> empleados = new List<IEmpleado>();

    do
    {
        Console.WriteLine("Menu ================");
        Console.WriteLine("1. Ingresar Empleado");
        Console.WriteLine("2. Mostrar Listado");
        Console.WriteLine("3. Salir");
        opcion = Convert.ToInt32(Console.ReadLine());
        if (opcion == 1)
        {
            Console.WriteLine("Seleccione Empleado ================");
            Console.WriteLine("1. Gerente");
            Console.WriteLine("2. Gerente de RRHH");
            Console.WriteLine("3. Desarrollador");
            Console.WriteLine("4. Consultor Externo");
            Console.WriteLine("5. Salir");
            opcionPuesto = Convert.ToInt32(Console.ReadLine());
            if (opcionPuesto < 5 && opcionPuesto >= 1)
            {
                idEmpleado++;
                empleados.Add(CrearEmpleado(opcionPuesto, idEmpleado));
            }
            else if (opcionPuesto > 5 || opcionPuesto < 1)
            {
                Console.WriteLine("Seleccione una opcion correcta ================");
            }
            else
            {
                Console.WriteLine($"Saliendo ===");
            }

        }
        else if (opcion == 2)
        {
            foreach (var empleado in empleados)
            {
                empleado.MostrarDetalle();
                if (empleado is ISueldoBonificable empleadoBonificable)
                {
                    empleadoBonificable.CalcularBonificacion();
                }
                if (empleado is IDescuentoImpuesto empleadoDescontable)
                {
                    empleadoDescontable.DescontarSueldo();
                }
                SumaTotalSueldo = SumaTotalSueldo + empleado.CalcularSueldo();
                Console.WriteLine($"Sueldo: {empleado.CalcularSueldo()}");
            }

            Console.WriteLine($"Resumen ================");
            Console.WriteLine($"Numero de Empleados: {idEmpleado} ");
            Console.WriteLine($"Suma Total de sueldos al mes: {SumaTotalSueldo} ");
            SumaTotalSueldo = 0;
        }
        else if (opcion > 3 || opcion < 1)
        {
            Console.WriteLine("Seleccione una opcion correcta ================");
        }
    } while (opcion != 3);
    {
        Console.WriteLine($"Saliendo ===");
    }
}

EmpleadoBase CrearEmpleado (int opcionPuesto, int idEmpleado)
{
    Console.WriteLine($"Ingrese Nombre ================");
    String nombre = Convert.ToString(Console.ReadLine());
    switch (opcionPuesto)
    {
        case 1:
            Gerente gerente = new Gerente()
            {
                Nombre = nombre,
                IdEmpleado = idEmpleado,
                Puesto = "Gerente"
            };
            return gerente;
            break;
        case 2:
            GerenteRRHH gerenteRRHH = new GerenteRRHH()
            {
                Nombre = nombre,
                IdEmpleado = 2,
                Puesto = "Gerente RRHH"
            };
            return gerenteRRHH;
            break;
        case 3:
            Desarrollador desarrollador = new Desarrollador()
            {
                Nombre = nombre,
                IdEmpleado = 2,
                Puesto = "Desarrollador"
            };
            return desarrollador;
            break;
        case 4:
            ConsultorExterno consultorExterno = new ConsultorExterno()
            {
                Nombre = nombre,
                IdEmpleado = 2,
                Puesto = "Consultor Externo"
            };
            return consultorExterno;
            break;
        default:
            break;
    }
    return new Gerente();
}

void SegundaParte()
{
    List<IEmpleado> empleados = new List<IEmpleado>();
    Gerente gerente = new Gerente()
    {
        Nombre = "Edson Sosa",
        IdEmpleado = 1,
        Puesto = "Gerente Desarrollo"
    };
    Desarrollador desarrollador = new Desarrollador()
    {
        Nombre = "Jair Saavedra",
        IdEmpleado = 2,
        Puesto = "Desarrollador Junior"
    };
    GerenteRRHH gerenteRRHH = new GerenteRRHH()
    {
        Nombre = "Jennifer V",
        IdEmpleado = 3,
        Puesto = "Gerente RRHH"
    };
    ConsultorExterno consultorExterno = new ConsultorExterno()
    {
        Nombre = "Carol B",
        IdEmpleado = 4,
        Puesto = "Consultor Externo"
    };
    empleados.Add(gerente);
    empleados.Add(desarrollador);
    empleados.Add(gerenteRRHH);
    empleados.Add(consultorExterno);

    foreach (var empleado in empleados)
    {
        empleado.MostrarDetalle();
        if (empleado is ISueldoBonificable empleadoBonificable)
        {
            empleadoBonificable.CalcularBonificacion();
        }
        if (empleado is IDescuentoImpuesto empleadoDescontable)
        {
            empleadoDescontable.DescontarSueldo();
        }
        Console.WriteLine($"Sueldo: {empleado.CalcularSueldo()}");
    }
}

void PrimeraParte()
{
    List<IEmpleado> empleados = new List<IEmpleado>();
    Gerente gerente = new Gerente()
    {
        Nombre = "Edson Sosa",
        IdEmpleado = 1,
        Puesto = "Gerente Desarrollo"
    };
    Desarrollador desarrollador = new Desarrollador()
    {
        Nombre = "Jair Saavedra",
        IdEmpleado = 2,
        Puesto = "Desarrollador Junior"
    };
    empleados.Add(gerente);
    empleados.Add(desarrollador);

    foreach (var empleado in empleados)
    {
        empleado.MostrarDetalle();
        if (empleado is ISueldoBonificable empleadoBonificable)
        {
            empleadoBonificable.CalcularBonificacion();
        }
        if (empleado is IDescuentoImpuesto empleadoDescontable)
        {
            empleadoDescontable.DescontarSueldo();
        }
        Console.WriteLine($"Sueldo: {empleado.CalcularSueldo()}");
    }
}


QuintaParte();