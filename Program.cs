// See https://aka.ms/new-console-template for more information
int ndig = 1000;
double phi = (1.0+Math.Sqrt(5.0))/2.0;
double log10Phi = Math.Log10(phi);
Int64 n = (Int64)(1+((ndig-1)+.5*Math.Log10(5))/log10Phi);
Console.WriteLine(n);

/*using System.Numerics;

BigInteger b1 = 0;
BigInteger b2;
BigInteger bLimit = BigInteger.Pow(10, 999);
int n = 1;
BigInteger b = 1;
while(b < bLimit){
    b2 = b1;
    b1 = b; 
    b = b1 + b2;
    n++;
}

Console.WriteLine(n);
Console.WriteLine(b);*/
