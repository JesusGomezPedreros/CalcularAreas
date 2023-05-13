namespace CalcularAreas.Dominios
{
    public abstract class FigurasGeometricas
    {
        public abstract Task<double> CalcularArea();
    }
    public class Circulo : FigurasGeometricas
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override async Task<double> CalcularArea()
        {
            return await Task.FromResult(Math.PI * Math.Pow(radio, 2));
        }
    }

    public class Rectangulo : FigurasGeometricas
    {
        private double ancho;
        private double altura;

        public Rectangulo(double ancho, double altura)
        {
            this.ancho = ancho;
            this.altura = altura;
        }

        public override async Task<double> CalcularArea()
        {
            return await Task.FromResult(ancho * altura);
        }
    }
}
