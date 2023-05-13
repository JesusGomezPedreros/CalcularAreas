namespace CalcularAreas.Dominios
{
    public abstract class FigurasGeometricas
    {
        public abstract Task<double> CalcularArea();
    }
    public class Circulo : FigurasGeometricas
    {
        private double radio;
        // Constructor de la clase Circulo, que recibe el radio como parámetro
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        // Implementación del método CalcularArea de la clase Circulo
        public override async Task<double> CalcularArea()
        {
            return await Task.FromResult(Math.PI * Math.Pow(radio, 2));
        }
    }

    public class Rectangulo : FigurasGeometricas
    {
        private double ancho;
        private double altura;
        // Constructor de la clase Rectangulo, que recibe la base y altura como parámetros
        public Rectangulo(double ancho, double altura)
        {
            this.ancho = ancho;
            this.altura = altura;
        }
        // Implementación del método CalcularArea de la clase Rectangulo
        public override async Task<double> CalcularArea()
        {
            return await Task.FromResult(ancho * altura);
        }
    }
}
