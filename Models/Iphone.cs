namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
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
                Console.WriteLine($"SO: Iphone.");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro! SO: Iphone.");

                throw new Exception(@$"Erro ao instalar app: {nomeApp}. 
                        Erro: {exception.Message}");

            }

        }
    }
}