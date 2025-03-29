public class Room1
{
   public Room1()
   {
      
   }
  
   public Room1(string c, byte f,double l,double w,double h)
   {
      paintcolor = c;
      floor = f;
      lengthft = l;
      widthft = w;
      heightft = h;

   }

   //fields
   public double widthft;
   public double lengthft;
   public double heightft;
   public string paintcolor;
   public byte floor;

   public void DisplayInfo()
   {
      var info = $"Hey guys, we have a room in the floor {floor} which is painted {paintcolor}.It's Dimension is {lengthft}x{heightft}x{widthft}";
      Console.WriteLine(info);
   }



}