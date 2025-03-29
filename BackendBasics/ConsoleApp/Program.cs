// See https://aka.ms/new-console-template for more information
//values:Numbers,Booleans,Texts,Dates
// char gender ='F';
// string name ="laxmi gharti";
// Console.WriteLine("Hello, World!");
// Console.WriteLine(name);


// Console.WriteLine("Your full name:");
// string? fullName = Console.ReadLine();
// string nameInupper=fullName.ToUpper();
// Console.WriteLine(nameInupper);

// var firstFriend ="Maria";
//var secondFriend ="sage";

// //My My friends are maria and sage
//string displayText = "My friend are " + firstFriend + "and" + secondFriend;
//Console.WriteLine(displayText);
//Console.Writeline($"My friend are{})

//string interpolation

//var x = 46 % 5;//modulo operator

//var y = 2342553;
//if(y % 2== 0)
//{
//Console.WriteLine($"{y} is even");

//}
//else
//{
//Console.WriteLine($"{y} is odd");
//}


//can divide{r},{quotient} times and it's perfectly divisible by it."
//var r = 23456;
//int divider = 13;
//find if r is perfectly divisible by 13
//var result = r % 13 == 0 ? $"{r} is divisible by 13" : $"{r} is not divisible by 13";
//Console.WriteLine(result);

//var result = r % divider == 0 ? $"{r} is divisible by (divider)" : $"{r} is not divisible by (divider)";
//Console.WriteLine(result);
//output 13 can divide 23456, 34 times.But it's not  perfectly divisible by it.


//var quotient = r / divider;
//var result1 = r % 13 == 0 
//? $"{divider} can divide{r},{quotient} times and it's perfectly divisible by it." 
//: $"{divider} can divide{r},{quotient} times and it's  not perfectly divisible by it." ;
//Console.WriteLine(result1);

//Looping
// for(int i = 1; i <=100; i++)
// {
//     if(i % 2 == 0)
//     Console.Write($"{i} ");
// }

//print all numbers between 1-1000 which are divisible by 5 and 7
//for(int i = 1; i <=1000; i++)
//{
//if(i % 5 == 0 & i % 7 == 0)
//Console.Write($"{i} ");
//}
//int sum = 0;
//for(int i = 1; i <= 20; i++)
//{
//if (i % 3 == 0)
//{
//sum += i; 
//}
// }

//Console.WriteLine($"The sum of all integers from 1 to 20 that are divisible by 3 is: {sum}");
//}
//}



//var r1 =new Room1();
//r1.paintcolor= "blue";
//r1.floor = 3;
//r1.lengthft = 15.5;
//r1.widthft = 12.4;
//r1.heightft =8;
//r1.DisplayInfo();

//var r2 =new Room1("pink",4,16.5,14.4,9);
//r2.DisplayInfo();

//var r3 = HotelRoom();


//var r3 =new Room1();
//var r4 =new Room1();
//var r5 =new Room1();

// using System.Reflection.Metadata;

// var l1 = new Lake();
// l1.name= "Phoksundo Lake";
// l1.Area = 29;
// l1.Depthft = 446;
// l1.Volume = 398;
// l1.Watercolor = "blue";
// l1.Location = "Dolpa district";
// l1.lakeInfo();

var l2 = new Lake("BEGNAS",3,33,29,"greenish","Pokhara ");
l2.lakeInfo();

 var l3= new GlacierLake("Tsho Rolpa",1.68,140,2.5,"Supports cold water fish and Algae.");
 l3.DisplayGlacierFeatures();