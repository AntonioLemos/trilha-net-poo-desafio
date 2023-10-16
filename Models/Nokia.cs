namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                Console.WriteLine($"Instalando app: {nomeApp}. Aguarde.");
                Task.Delay(3000);
                Console.WriteLine($"App: {nomeApp} instalado com sucesso!");
                Console.WriteLine($"SO: Nokia.");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro! SO: Nokia.");

                throw new Exception(@$"Erro ao instalar app: {nomeApp}. 
                        Erro: {exception.Message}");

            }

        }
    }
}