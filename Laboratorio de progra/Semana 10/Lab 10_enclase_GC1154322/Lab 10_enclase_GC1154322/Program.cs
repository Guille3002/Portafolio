// See https://aka.ms/new-console-template for more information


Circulo circulo = new Circulo();
Console.Write("Ingrese un radio: ");
circulo.radio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Perímetro: " + circulo.ObtenerPerimetro());
Console.WriteLine("Área: " + circulo.ObtenerArea());
Console.WriteLine("Volumen: " + circulo.ObtenerVolumen());

class Circulo
{
    public double radio;
    public double ObtenerPerimetro()
    {
        return 2 * Math.PI * radio;
    }
    public double ObtenerArea()
    {
        return Math.PI * radio * radio;
    }
    public double ObtenerVolumen()
    {
        return 4 * radio * radio * radio/3;
    }

}
