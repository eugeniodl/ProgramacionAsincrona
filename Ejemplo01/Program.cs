Coffe coffe = PourCoffe();
Console.WriteLine("Café está listo");

Task<Egg> eggTask = FryEggsAsync(2);
Egg egg = await eggTask;
Console.WriteLine("Huevos están listos");

Task<Bacon> baconTask = FryBaconAsync(3);
Bacon bacon = await baconTask;
Console.WriteLine("Jamón está listo");

Task<Toast> toastTask = ToastBreadAsync(2);
Toast toast = await toastTask;
ApplyButter(toast);
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
    Console.WriteLine("Aplicando jalea a la tostada");
}

void ApplyButter(Toast toast)
{
    Console.WriteLine("Aplicando mantequilla a la tostada");
}

#region Métodos Asíncronos
async Task<Egg> FryEggsAsync(int howMany)
{
    Console.WriteLine("Calentando el sartén...");
    await Task.Delay(3000);
    Console.WriteLine($"rompiendo {howMany} huevos");
    Console.WriteLine("cocinando los huevos...");
    await Task.Delay(3000);
    Console.WriteLine("Sirviendo los huevos al plato");
    return new Egg();
}

async Task<Bacon> FryBaconAsync(int slices)
{
    Console.WriteLine($"colocando {slices} slices de jamón en el pan");
    Console.WriteLine("cocinando el primer lado del jamón...");
    await Task.Delay(3000);
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("volteando un slice de jamón");
    }
    Console.WriteLine("cocinando el segundo lado del jamón...");
    await Task.Delay(3000);
    Console.WriteLine("Sirviendo jamón al plato");
    return new Bacon();
}

async Task<Toast> ToastBreadAsync(int slices)
{
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("Colocando slice de pan a la tostadora");
    }
    Console.WriteLine("Tostando pan...");
    await Task.Delay(3000);
    Console.WriteLine("Removiendo pan del tostador");

    return new Toast();
} 
#endregion


#region Métodos Síncronos

Toast ToastBread(int slices)
{
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("Colocando slice de pan a la tostadora");
    }
    Console.WriteLine("Tostando pan...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Removiendo pan del tostador");

    return new Toast();
}

Bacon FryBacon(int slices)
{
    Console.WriteLine($"colocando {slices} slices de jamón en el pan");
    Console.WriteLine("cocinando el primer lado del jamón...");
    Task.Delay(3000).Wait();
    for (int slice = 0; slice < slices; slice++)
    {
        Console.WriteLine("volteando un slice de jamón");
    }
    Console.WriteLine("cocinando el segundo lado del jamón...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Sirviendo jamón al plato");
    return new Bacon();
}

Egg FryEggs(int howMany)
{
    Console.WriteLine("Calentando el sartén...");
    Task.Delay(3000).Wait();
    Console.WriteLine($"rompiendo {howMany} huevos");
    Console.WriteLine("cocinando los huevos...");
    Task.Delay(3000).Wait();
    Console.WriteLine("Sirviendo los huevos al plato");
    return new Egg();
}

#endregion
Coffe PourCoffe()
{
    Console.WriteLine("Sirviendo café");
    return new Coffe();
}

internal class Coffe
{
}

internal class Egg
{
}

internal class Bacon
{
}

internal class Toast
{
}

internal class Juice
{
}