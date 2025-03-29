public class GlacierLake : Lake
{

    public string Name;
    public double Area;//in sq km
    public double Depth;//meters
    public double WaterTemperature;//celsius
    public string Ecosystem;//eg.flora and fauna


    public GlacierLake(string n, double a,double d,double w,string eco)
    {
        Name = n;
        Area = a;
        Depth = d;
        WaterTemperature = w;
        Ecosystem = eco;

    }
    
    
        
//fields



public void DisplayGlacierFeatures()
{
    var glacier = $"Here we have extra features in{Name} whose area and depth are {Area}x{Depth}.Here water temperature is {WaterTemperature} and the ecosystem{Ecosystem}";
    Console.WriteLine(glacier);
}
}
