using System;

class Program
{
    static void Main(string[] args)
    {
        // Calcular el Mayor de Tres Números
        try
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            int num3 = int.Parse(Console.ReadLine());

            int max = Math.Max(Math.Max(num1, num2), num3);
            Console.WriteLine($"El mayor número es: {max}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido.");
        }

        // Validar Edad para Ingresar a un Club
        try
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al club.");
            }
            else
            {
                Console.WriteLine("Lo siento, debes tener al menos 18 años para ingresar al club.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido para la edad.");
        }

        // Calcular el Precio Final de un Producto

        try
        {
            Console.WriteLine("Ingrese el precio original del producto:");
            double precioOriginal = double.Parse(Console.ReadLine());

            double precioFinal;

            if (precioOriginal > 100)
            {
                precioFinal = precioOriginal * 0.9; // Aplicar descuento del 10%
            }
            else
            {
                precioFinal = precioOriginal;
            }

            Console.WriteLine($"El precio final del producto es: {precioFinal}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un precio válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        {
            Console.WriteLine("Error: Ingrese un precio válido.");
        }

        // Validar Usuario y Contraseña
        try
        {
            Console.WriteLine("Ingrese el nombre de usuario:");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña:");
            string contraseña = Console.ReadLine();

            if (usuario == "usuario" && contraseña == "contraseña")
            {
                Console.WriteLine("Acceso concedido.");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Ocurrió un problema al intentar acceder.");
        }

        // Determinar si un Número es Par o Impar
        try
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido.");
        }

        // Mostrar un Mensaje de Aprobación o Rechazo de Préstamo
        try
        {
            Console.WriteLine("Ingrese el monto del préstamo:");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            if (monto < 5000 || edad > 60)
            {
                Console.WriteLine("Préstamo aprobado.");
            }
            else
            {
                Console.WriteLine("Préstamo rechazado.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un monto o una edad válida.");
        }

        // Calcular el Área de una Figura Geométrica
        try
        {
            Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
            string tipo = Console.ReadLine().ToLower();

            double area = 0;

            switch (tipo)
            {
                case "triangulo":
                    Console.WriteLine("Ingrese la base del triángulo:");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo:");
                    double alturaTriangulo = double.Parse(Console.ReadLine());
                    area = (baseTriangulo * alturaTriangulo) / 2;
                    break;
                case "cuadrado":
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double ladoCuadrado = double.Parse(Console.ReadLine());
                    area = ladoCuadrado * ladoCuadrado;
                    break;
                case "circulo":
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radioCirculo = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radioCirculo, 2);
                    break;
                default:
                    Console.WriteLine("Figura no reconocida.");
                    break;
            }

            Console.WriteLine($"El área de la figura es: {area}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido.");
        }
        // Convertir un Número de Letra a Número
        try
        {
            Console.WriteLine("Ingrese un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco):");
            string numeroLetra = Console.ReadLine().ToLower();

            int numero;

            switch (numeroLetra)
            {
                case "uno":
                    numero = 1;
                    break;
                case "dos":
                    numero = 2;
                    break;
                case "tres":
                    numero = 3;
                    break;
                case "cuatro":
                    numero = 4;
                    break;
                case "cinco":
                    numero = 5;
                    break;
                default:
                    throw new Exception("Número no válido.");
            }

            Console.WriteLine($"El número en dígito es: {numero}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Mostrar el Día de la Semana a partir de un Número
        try
        {
            Console.WriteLine("Ingrese un número del 1 al 7:");
            int numeroDia = int.Parse(Console.ReadLine());

            string dia;

            switch (numeroDia)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miércoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    throw new Exception("Número no válido.");
            }

            Console.WriteLine($"El día de la semana es: {dia}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Calcular el Importe a Pagar por un Servicio
        try
        {
            Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
            string tipoServicio = Console.ReadLine().ToLower();

            double importe;

            switch (tipoServicio)
            {
                case "lavado de auto":
                    importe = 50;
                    break;
                case "cambio de aceite":
                    importe = 100;
                    break;
                case "revisión mecánica":
                    importe = 200;
                    break;
                default:
                    throw new Exception("Servicio no válido.");
            }

            Console.WriteLine($"El importe a pagar por el servicio es: {importe}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Mostrar un Mensaje de Bienvenida en Diferentes Idiomas
        try
        {
            Console.WriteLine("Ingrese su idioma de preferencia (español, inglés, francés):");
            string idioma = Console.ReadLine().ToLower();

            string mensajeBienvenida;

            switch (idioma)
            {
                case "español":
                    mensajeBienvenida = "¡Bienvenido!";
                    break;
                case "inglés":
                    mensajeBienvenida = "Welcome!";
                    break;
                case "francés":
                    mensajeBienvenida = "Bienvenue!";
                    break;
                default:
                    throw new Exception("Idioma no válido.");
            }

            Console.WriteLine(mensajeBienvenida);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

              // Evaluar la Calificación de un Examen
        try
        {
            Console.WriteLine("Ingrese la calificación del examen:");
            int calificacion = int.Parse(Console.ReadLine());

            string desempeño;

            if (calificacion >= 0 && calificacion <= 100)
            {
                switch (calificacion)
                {
                    case int n when (n >= 90 && n <= 100):
                        desempeño = "Sobresaliente";
                        break;
                    case int n when (n >= 80 && n <= 89):
                        desempeño = "Notable";
                        break;
                    case int n when (n >= 70 && n <= 79):
                        desempeño = "Aprobatoria";
                        break;
                    case int n when (n >= 60 && n <= 69):
                        desempeño = "No aprobatoria";
                        break;
                    case int n when (n >= 27 && n <= 59):
                        desempeño = "No tiene derecho a examen";
                        break;
                    case int n when (n >= 0 && n <= 26):
                        desempeño = "No llega a zona minima";
                        break;
                    default:
                        desempeño = "Fuera de rango";
                        break;
                }

                Console.WriteLine($"Desempeño: {desempeño}");
            }
            else
            {
                throw new Exception("Calificación fuera de rango.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese una calificación válida (número entero).");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
    

