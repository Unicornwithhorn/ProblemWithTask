// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько.
// Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.
// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа.
// Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.
int CreateNumber()
{
  int number = new Random().Next(2,500) *2; //[2, 499]*2
  return number;
}

bool PrimeNumber(int a)
{
  bool answer = true;
  for (int i=2; i<=a/2; i++)
  {
    if (a*1000/i==(a/i)*1000) answer = false;
  }
  return answer;
}

int number = CreateNumber();
for (int i = 0; i<=number/2;i+=1)
{
  if
   (PrimeNumber(i) == true && PrimeNumber(number - i) == true)
    {
      break;
    }
}

System.Console.WriteLine(number);
System.Console.WriteLine();
System.Console.WriteLine(i);
System.Console.WriteLine();
System.Console.WriteLine(number-i);