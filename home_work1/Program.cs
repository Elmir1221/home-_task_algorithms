//n - ededinin faktorialini hesablayin.

long n = 25;
long result= 1;

while (n> 0)
{
    result = result * n;
     
    n--;
}

Console.WriteLine(result);