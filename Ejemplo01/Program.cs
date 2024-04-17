Console.WriteLine("Preparando café");
await CalentarAguaAsync();
await BatirCafeAsync();
PrepararCafe();

async Task CalentarAguaAsync()
{
    Console.WriteLine("Calentando agua...");
    await Task.Delay(3000); // Simulación de calentar agua durante 3 segundos
    Console.WriteLine("Agua caliente lista");
}

async Task BatirCafeAsync()
{
    Console.WriteLine("Batiendo café...");
    await Task.Delay(2000); // Simulación de batir café durante 2 segundos
    Console.WriteLine("Café batido listo");
}

void PrepararCafe()
{
    Console.WriteLine("Vertiendo café en la taza...");
    Task.Delay(1000).Wait(); // Simulación de verter café durante 1 segundo
    Console.WriteLine("Café preparado");
}
