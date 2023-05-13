using CalcularAreas.Dominios;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public async Task TestCalcularArea()
        {
            double radio = 2;
            var circulo = new Circulo(radio);

            double area = await circulo.CalcularArea();

            double expectedArea = Math.PI * Math.Pow(radio, 2);
            Assert.AreEqual(expectedArea, area);
            
            Assert.Pass();
        }
        [Test]
        public async Task TestCalcularAreaRectangulo()
        {
           
            double ancho = 3;
            double altura = 4;
            var rectangulo = new Rectangulo(ancho, altura);

            double area = await rectangulo.CalcularArea();

            double expectedArea = ancho * altura;
            Assert.AreEqual(expectedArea, area);
        }
    }
}