using CarRacing.Core;
using CarRacing.Core.Contracts;
namespace CarRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
