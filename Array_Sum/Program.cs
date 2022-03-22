string mystring = Console.ReadLine();

int[] myarray = new int[mystring.Length];

int i = 0;
int sum = 0;

while (i < mystring.Length)
{
    myarray[i] = int.Parse(mystring[i].ToString());
    i++;
}

foreach (int num in myarray)
{
    Console.Write(num + ", ");
}

Array.ForEach(myarray, b => sum += b);


Console.WriteLine(sum);