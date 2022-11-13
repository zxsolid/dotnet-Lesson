// 27. Принимает на вход число и выдает сумму цифр в числе.

Console.Clear();

int getSumNumbers(int x){
int sumNums=0;
while (x>0){
    sumNums+=x%10;
    x/=10;
}

return sumNums;
}

Console.WriteLine("Введите число для подсчета суммы чисел в нем");
Console.WriteLine(getSumNumbers(int.Parse(Console.ReadLine()!)));