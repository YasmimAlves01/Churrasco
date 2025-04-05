double adultB, adultNB, crianca, carne, acomp, cerv, refri, agua;


Console.WriteLine("Bem-vindo ao Churrasco Feliz \n");
Console.WriteLine("Por favor preencha os dados abaixo:\n");

Console.Write("Por favor digite quantos adultos consumidores de alcool vão: ");
adultB = Convert.ToInt32(Console.ReadLine()!);

Console.Write("\nPor favor digite quantos adultos não consumidores de alcool vão: ");
adultNB = Convert.ToInt32(Console.ReadLine()!);

Console.Write("\nPor favor digite quantas crianças vão: ");
crianca = Convert.ToInt32(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("--- Churrasco ---");

Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultB}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adultNB}");
Console.WriteLine($"Crianças........................................: {crianca}  \n");

carne = ((adultNB + adultB) * 0.4) + (crianca * 0.2); 

acomp = (adultNB + adultB + crianca) * 0.2;

cerv = adultB * 2;

refri = (adultNB + crianca) * 0.5;

agua = (adultNB + adultB + crianca) * 0.4;

Console.WriteLine($"Carne.............: {carne:F1}Kg");
Console.WriteLine($"Acompanhamentos...: {acomp:F1}Kg");
Console.WriteLine($"Cerveja...........: {cerv:F1}L");
Console.WriteLine($"Refrigerante......: {refri:F1}L");
Console.WriteLine($"Água..............: {agua:F1}L");
