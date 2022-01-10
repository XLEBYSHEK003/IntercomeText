using System;
using Exiled.API.Features;

namespace IntercomeText
{
    public class Plugin : Plugin<Config>
    {

        public override string Name { get; } = "Intercome Text";

        public override string Author { get; } = "XLEBYSHEK";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 2);

        public override void OnEnabled()
        {
            Server.RunCommand(Config.StartedIntercomeText , null); 
            // Вместо "Работает?" Я хотел бы впихнуть из Config "Itext", знаю всё хреново идёт, но я учусь. 
            // При старте раунда должна выполняться команда, которая отправляет в интерком текст.
            // Я не нашёл в Exiled, что отвечает за надпись в интеркоме, но нашёл команду в RA - icomtext (вроде так)
            // Выглядит следующим образом - icomtext текст.
            // Ладно, позже к нему вернусь как мозг куплю.
        }


    }
        

}


    
