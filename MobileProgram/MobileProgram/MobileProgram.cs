using System;

namespace MobileProgram
{
    class MobileProgram
    {
        static void Main(string[] args)
        {
            Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");

            Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: "
                + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: "
                + jimMobile.getBalance());

            Console.ReadLine();

            jimMobile.setAccType("PAYG");
            jimMobile.setDevice("iPhone 6S");
            jimMobile.setNumber("07713334466");
            jimMobile.setBalance(15.50);

            Console.WriteLine();
            Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: "
                + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: "
                + jimMobile.getBalance());

            Console.ReadLine();

            Console.WriteLine();
            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);
            
            Console.ReadLine();

            jimMobile.setAccType("Monthly");
            jimMobile.setDevice("Samsung Galaxy S10");
            jimMobile.setNumber("62548521565");
            jimMobile.setBalance(30.70);

            Console.WriteLine();
            Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: "
                + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: "
                + jimMobile.getBalance());

            Console.ReadLine();

            Console.WriteLine();
            jimMobile.addCredit(20.0);
            jimMobile.makeCall(200);
            jimMobile.sendText(135);

            Console.ReadLine();
        }
    }
}
