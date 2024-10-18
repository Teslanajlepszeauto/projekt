namespace projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float waga = GetValidInput("PODAJ MASĘ CIAŁA (Kg)", "Błędna wartość. Podaj poprawną masę ciała w kg (liczba większa od 0):");
            float wzrost = GetValidInput("PODAJ WZROST (m)", "Błędna wartość. Podaj poprawny wzrost w metrach (liczba większa od 0):");

            float bmi = CalculateBMI(waga, wzrost);
            Console.WriteLine($"Twoje BMI wynosi: {bmi:F2}");

            Console.WriteLine(GetBMICategory(bmi));
        }

        // Method to get valid input from user
        static float GetValidInput(string prompt, string errorMessage)
        {
            float value;
            Console.WriteLine(prompt);
            while (!float.TryParse(Console.ReadLine(), out value) || value <= 0)
                Console.WriteLine(errorMessage);
            return value;
        }

        // Method to calculate BMI
        static float CalculateBMI(float waga, float wzrost) => waga / (wzrost * wzrost);

        // Method to determine BMI category
        static string GetBMICategory(float bmi)
        {
            if (bmi < 16) return "Wygłodzenie";
            if (bmi < 18.5) return "Niedowaga";
            if (bmi < 25) return "Optimum";
            if (bmi < 30) return "Nadwaga";
            if (bmi < 35) return "Otyłość 1 stopnia";
            if (bmi < 40) return "Otyłość 2 stopnia";
            return "Otyłość 3 stopnia";
        }
    }
}

