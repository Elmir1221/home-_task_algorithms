//Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sumOfEvenNumbers = 0;


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sumOfEvenNumbers += numbers[i];
    }
}

int squareOfSum = sumOfEvenNumbers * sumOfEvenNumbers;

Console.WriteLine($"Cevab: {squareOfSum}");
