namespace Ejemplo01
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Preparando café");
            await CalentarAguaAsync();
            await BatirCafeAsync();
            await PrepararCafeAsync();
        }

        private static async Task CalentarAguaAsync()
        {
            Console.WriteLine("Calentando agua...");
            await Task.Delay(3000); // Simulación de calentar agua durante 3 segundos
            Console.WriteLine("Agua caliente lista");
        }

        private static async Task BatirCafeAsync()
        {
            Console.WriteLine("Batiendo café...");
            await Task.Delay(2000); // Simulación de batir café durante 2 segundos
            Console.WriteLine("Café batido listo");
        }

        private static async Task PrepararCafeAsync()
        {
            Console.WriteLine("Vertiendo café en la taza...");
            await Task.Delay(1000); // Simulación de verter café durante 1 segundo
            Console.WriteLine("Café preparado");
        }
    }
}