using System;

namespace BillingSystem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Billing System 1";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Patient patient1 = new Patient();
            patient1.Name = "Ioannis Terzakis";
            patient1.Age = 19;
            patient1.AddTreatment(150.00);
            patient1.AddTreatment(100.00);

            Console.WriteLine("Patient " + patient1.Name + " has had " + patient1.Treatments + " treatments and current bill is £" + patient1.Amount);
            Console.WriteLine();

            patient1.PayBill();
            Console.WriteLine();

            Console.WriteLine(" Patient " + patient1.Name + " has had " + patient1.Treatments + " treatments and current bill is £" + patient1.Amount);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            InsuredPatient patient2 = new InsuredPatient();
            patient2.Name = "Mark Zuckerberg";
            patient2.Age = 36;
            patient2.BillCovered = 100;
            patient2.AddTreatment(82.00);

            Console.WriteLine("Patient " + patient2.Name + " has had " + patient2.Treatments + " treatments and current bill is £" + patient2.Amount);
            Console.WriteLine();

            patient2.ChargeInsurance();
            Console.WriteLine();

            patient2.PayBill();
            Console.WriteLine();

            Console.WriteLine(" Patient " + patient2.Name + " has had " + patient2.Treatments + " treatments and current bill is £" + patient2.Amount);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
