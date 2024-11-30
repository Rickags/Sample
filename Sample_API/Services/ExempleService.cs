namespace Sample_API.Services
{
    public class ExempleService : IExempleService//classe concreta
    {
        public void WriteExample()
        {
            Console.WriteLine("Método 1 sendo executado...");
            Task.Delay(2000).Wait();
            Console.WriteLine("Método 1 foi executado com sucesso.");
        }

        public void WriteName(string name)
        {
            Console.WriteLine("Método 2 sendo executado...");
            Task.Delay(4000).Wait();
            Console.WriteLine("Método 2 foi executado com sucesso.");
        }
    }
}
