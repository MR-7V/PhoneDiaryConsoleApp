using System.Text.RegularExpressions;

namespace myDairy
{
    class Validate{
        //validates and take correct phonenumber
        public static string Validation(){
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Regex phoneNumberRegex = new Regex(@"^[0-9]+$");
            while (!phoneNumberRegex.IsMatch(phoneNumber)) {
                Console.WriteLine("Invalid phone number. Please enter a valid phone number.");
                Console.Write("Enter phone number: ");
                phoneNumber = Console.ReadLine();
            }
            return phoneNumber;
        }

        //validates and take correct email address
        public static string Validation(string personalEmail){
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            while (!emailRegex.IsMatch(personalEmail)) {
                Console.WriteLine("Invalid email format. Please enter a valid email.");
                Console.Write("Enter email: ");
                personalEmail = Console.ReadLine();
            }
            return personalEmail;
        }
    }
}