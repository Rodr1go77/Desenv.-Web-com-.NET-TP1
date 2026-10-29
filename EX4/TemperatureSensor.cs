


namespace EX4
{
    internal class TemperatureSensor
    {

        public event Action<double>? TemperatureExceeded;

        public void ChecarTemperatura(double temperatura)
        {
            if (temperatura > 100)
            {
                TemperatureExceeded?.Invoke(temperatura);
            }
            else
            {
                Console.WriteLine($"Temperatura dentro do limite seguro: {temperatura}ºC");
            }
        }


    }
}
