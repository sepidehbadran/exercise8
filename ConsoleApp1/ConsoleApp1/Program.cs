// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static  void main ( string[] args )
{
    List <int> num2 = new List<int> { 1,2,4,8,16,64};
    List <int> num1 = new List<int> { 1,2,4,8,16,64};
   num2.Reverse();
    for (int i = 0; i < num2.Count; i++)
    {
        Console.WriteLine(Convert.ToString(num1[i])) ;


    }
}
        