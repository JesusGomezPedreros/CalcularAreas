using CalcularAreas.Dominios;

namespace CalcularAreas.Servicios
{
    public class FigurasGeometricasServicios
    {
        public FigurasGeometricas CrearCirculo(double radio)
        {
            return new Circulo(radio);
        }
        public FigurasGeometricas CrearRectangulo(double ancho, double altura)
        {
            return new Rectangulo(ancho, altura);
        }
    }
}
