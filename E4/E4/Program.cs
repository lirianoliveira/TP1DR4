namespace E4
{
    public class TemperatureSensor
    {
        public event EventHandler<double> TemperatureExceeded;

        public void Monitorar(double temperatura)
        {
            if (temperatura > 100)
            {
                OnTemperatureExceeded(temperatura);

            }
        }

        protected virtual void OnTemperatureExceeded(double temperatura)
        {
            TemperatureExceeded?.Invoke(this, temperatura);
        }

        static void Main (string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += (sender, temp) =>
            {
                Console.WriteLine($"Temperatura execidade {temp}ºC");
            };
         Console.WriteLine("Informe a tempertura atual (Digite encerrar para sair): ");
            while(true)
            {
                Console.Write("Leitura do Sensor: ");
                string entradaDado = Console.ReadLine();

                if (entradaDado.ToLower() == "encerrar")
                {
                    break;
                }
              
                double leitura = Convert.ToDouble(entradaDado);
                sensor.Monitorar(leitura);


                
            }
        }
    }
}
