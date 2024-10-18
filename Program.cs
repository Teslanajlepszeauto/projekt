namespace projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bmi = 0;
            float wzrost = 0;
            float waga = 0;

            Console.WriteLine("PODAJ MASĘ CIAŁA (Kg)");
             waga =float.Parse(Console.ReadLine());

            Console.WriteLine("PODAJ WZROST (m)");
             wzrost = float.Parse(Console.ReadLine());



            bmi =waga / (wzrost * wzrost);

            Console.WriteLine(bmi);

            if (bmi < 16)
            {
                Console.WriteLine("wyglodzenie");
                    
            }
            else
            if (bmi < 18)
            {
                Console.WriteLine("niedowaga");

            }
            if (bmi < 25)
            {
                Console.WriteLine("optimum");

            }
            else
            if (bmi < 30)
            {
                Console.WriteLine("nadwaga");

            }
            else   
            if (bmi < 35)
            {
                Console.WriteLine("otyłość 1 st.");

            }
            else
            if (bmi < 39)
            {
                Console.WriteLine("otyłość 2st.");

            }
            else
            if (bmi > 39)
            {
                Console.WriteLine("otyłość 3st.");

            }
        }
    }
}
