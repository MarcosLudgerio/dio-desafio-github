int[] arrayInt = new int[3];

arrayInt[0] = 6;
arrayInt[1] = 7;
arrayInt[2] = 5;

System.Console.WriteLine("Varrendo array pelo for");
for (int i = 0; i < arrayInt.Length; i++)
{
    System.Console.WriteLine(arrayInt[i]);
}

System.Console.WriteLine("Varrendo array com foreach");
foreach (var item in arrayInt)
{
    System.Console.WriteLine(item);
}
