//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN)
  {
    
    int num = Convert.ToString(numberN).Length;
    int count = 0;
    int result = 0;

    for (int i = 0; i < num; i++)

    {
      count = numberN - numberN % 10;
      result = result + (numberN - count);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр : " + sumNumber);