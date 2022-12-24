// вид1 
// void Method()
// {
   //  Console.WriteLine("автор..");
// }
// Method();



// вид 2
 //void Method2(string msg)
 //{
   // Console.WriteLine(msg);
 //}
 //Method2("текст сообщения");

 // вид 21
//  void Method21(string msg, int count)
 //{
   // int i = 0;
    //while(i < count)
    //{
      //  Console.WriteLine(msg);
        // i++;
    // }
 // }
 // Method21("text", 6);
 // Method21(count:4, msg:"ничего не понятно");

 // вид3
 // int Method3()
 //{
   // return DateTime.Now.Year;
 // }
// int Year = Method3();
// Console.WriteLine(Year);
 

//  //вид4
//  string Method4(int count, string text)
//  {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
//  }
//  string res = Method4(10, "z");
//  Console.WriteLine(res);

 
//  //вид4
//  string Method4(int count, string text)
//  {
    
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
//  }
//  string res = Method4(10, "zaraza");
//  Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{
      for(int j = 2; j<= 10; j++)
      {
        Console.WriteLine($"{i}*{j} = {i*j}");
      }
       Console.WriteLine();
}