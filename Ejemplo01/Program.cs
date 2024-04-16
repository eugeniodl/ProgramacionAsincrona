Coffe cup = PourCoffe();
Console.WriteLine("Café está listo");

Task<Egg> eggsTask = FryEggsAsync(2);
Egg eggs = await eggsTask;
Console.WriteLine("Huevos están listos");

Task<Bacon> baconTask = FryBaconAsync(3);
Bacon bacon = await baconTask;
Console.WriteLine("Jamón está listo");

Task<Toast> toastTask = ToastBreadAsync(2);
Toast toast = await toastTask;
ApllyButter(toast);
ApplyJam(toast);


Console.WriteLine("Tostada está lista");

Juice oj = PourOj();
Console.WriteLine("Jugo de naranja está listo");
Console.WriteLine("¡Desayuno está listo!");


Juice PourOj()
{
    Console.WriteLine("Sirviendo jugo de naranja");
    return new Juice();
}


void ApplyJam(Toast toast)
{
    Console.WriteLine("Untando jalea en la tostada");
}

void ApllyButter(Toast toast)
{
    Console.WriteLine("Untando mantequilla en la tostada");
}

async Task<Toast> ToastBreadAsync(int slices)
{
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("Colocando un slice de jamón a la tostadora");
    }
    Console.WriteLine("Inicio tostando...");
    await Task.Delay(3000);
    Console.WriteLine("Remover del tostador");

    return new Toast();
}

Toast ToastBread(int slices)
{
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("Colocando un slice de jamón a la tostadora");
    }
    Console.WriteLine("Inicio tostando...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Remover del tostador");

    return new Toast();
}

async Task<Bacon> FryBaconAsync(int slices)
{
    Console.WriteLine($"colocando {slices} slices de jamón en el pan");
    Console.WriteLine("cocinando primer lado del jamón...");
    await Task.Delay(3000);
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("volteando un slice de jamón");
    }
    Console.WriteLine("cocinando el sengundo lado del jamón...");
    await Task.Delay(3000);
    Console.WriteLine("Sirviendo jamón en el plato");

    return new Bacon();
}


Bacon FryBacon(int slices)
{
    Console.WriteLine($"colocando {slices} slices de jamón en el pan");
    Console.WriteLine("cocinando primer lado del jamón...");
    Task.Delay(3000).Wait();
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("volteando un slice de jamón");
    }
    Console.WriteLine("cocinando el sengundo lado del jamón...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Sirviendo jamón en el plato");

    return new Bacon();
}

async Task<Egg> FryEggsAsync(int cantidad)
{
    Console.WriteLine("Calentando la sartén...");
    await Task.Delay(3000);
    Console.WriteLine($"rompiendo {cantidad} huevos");
    Console.WriteLine("cocinando los huevos...");
    await Task.Delay(3000);
    Console.WriteLine("Sirviendo los huevos en el plato");

    return new Egg();
}

Egg FryEggs(int cantidad)
{
    Console.WriteLine("Calentando la sartén...");
    Task.Delay(3000).Wait();
    Console.WriteLine($"rompiendo {cantidad} huevos");
    Console.WriteLine("cocinando los huevos...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Sirviendo los huevos en el plato");

    return new Egg();
}


Coffe PourCoffe()
{
    Console.WriteLine("Sirviendo café");
    return new Coffe();
}

internal class Coffe
{
}


internal class Juice
{
}


internal class Toast
{
}

internal class Bacon
{
}


internal class Egg
{
}