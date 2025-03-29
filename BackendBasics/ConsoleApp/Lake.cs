public class Lake
{
    public Lake()
    {

    }
    
    

    public string name; 
    public float Area;  
    public float Depthft;  
    public float Volume;
    public string Watercolor; 
    public string Location;

     public Lake(string n, float a, float d, float v, string c, string l)
    {
        name = n;
        Area = a;
        Depthft = d;
        Volume = v;
        Watercolor = c;
        Location = l;
    }

        //fields

         public void lakeInfo()
         {
            var Info =$"This is the {name} lake, covering an area of {Area}. It measures {Depthft}x{Volume} in dimensions. The water is {Watercolor} in color and the lake is located in {Location}.";
            Console.WriteLine(Info);

         }
    
    }
