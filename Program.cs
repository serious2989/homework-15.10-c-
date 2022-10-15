int [] myarray = new int[8];

    for (int i = 0; i < myarray.Length; i++)

    {
       Console.Write($"Введите элемент массива с индексом {i}: ");
       myarray[1] = int.Parse(Console.ReadLine()); 
    }
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < myarray.Length; i++)
    {
        Console.WriteLine(myarray[i]);
    }
    Console.ReadLine();