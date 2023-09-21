using SingletondesignPattern.Model;

namespace SingletondesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServices d1 = DataServices.GetInstance();
            d1.DoProcess();

            DataServices d2 = DataServices.GetInstance();
            d2.DoProcess();

        }
    }
}