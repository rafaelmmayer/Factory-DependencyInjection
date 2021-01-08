using System;

namespace Factory_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var objeto = ObjetoFactory.Create();
            objeto.algumaCoisa();
        }
    }
}
