using DesafioPOO.Models;

Console.WriteLine("Smartphone nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone("123456", "Modelo 2", "2222222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
