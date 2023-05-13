using CalcularAreas.Errores;
using CalcularAreas.Servicios;

namespace CalcularAreas.Presentacion
{
    class Program
    {
        private readonly ManejoErrores _errores;
        public Program(ManejoErrores manejoErrores)
        {
            _errores = manejoErrores;
        }
        static async Task Main(string[] args)
        {
            var error = String.Empty;
            bool salir = false;
            FigurasGeometricasServicios figuraServicios = new FigurasGeometricasServicios();
            var manejoErrores = new ManejoErrores();
            var programa = new Program(manejoErrores);
            while (!salir)
            {
                int valor = 0;
                Console.WriteLine("");
                Console.WriteLine("Seleccione una figura geométrica:");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Cerrar");

                try
                {
                    valor = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    error = programa._errores.ManejoErroresValor();
                    Console.WriteLine(error);
                }
                switch (valor)
                {
                    case 1:
                        Console.WriteLine("Ingrese el radio del círculo:");
                        double radio = 0;
                        try
                        {
                            radio = double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            error = programa._errores.ManejoErroresValor();
                            Console.WriteLine(error);
                        }
                        if (error == "")
                        {
                            var CrearCirculo = figuraServicios.CrearCirculo(radio);
                            double areaCirculo = await CrearCirculo.CalcularArea();
                            Console.WriteLine("El area el circulo es: " + areaCirculo);
                        }


                        break;
                    case 2:
                        double baseRectangulo = 0;
                        double alturaRectangulo = 0;
                        try
                        {
                            Console.WriteLine("Ingrese la base del rectángulo:");
                            baseRectangulo = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del rectángulo:");
                            alturaRectangulo = double.Parse(Console.ReadLine());

                        }
                        catch (Exception)
                        {
                            error = programa._errores.ManejoErroresValor();
                            Console.WriteLine(error);
                        }
                        if (error == "")
                        {
                            var crearRectangulo = figuraServicios.CrearRectangulo(baseRectangulo, alturaRectangulo);
                            double areaRectangulo = await crearRectangulo.CalcularArea();
                            Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
                        }


                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Selección inválida.");
                        break;
                }
            }

            Environment.Exit(0);
        }
    }
}
