namespace myDairy
{
    class Relative : Person
    {
        public string Relation { get; set; }
        public string PersonalEmail { get; set; }
        public string Occupation { get; set; }
        public string HomeLocation { get; set; }
        public string DateOfBirth { get; set; }

        public Relative(string name, string phoneNumber, string relation, string personalEmail, string occupation, string homeLocation, string dateOfBirth)
            : base(name, phoneNumber, "Relative")
        {
            Relation = relation;
            PersonalEmail = personalEmail;
            Occupation = occupation;
            HomeLocation = homeLocation;
            DateOfBirth = dateOfBirth;
        }

        public override void Call()
        {
            Console.WriteLine("Calling " + Name + " at " + PhoneNumber);
        }

        public override void Message()
        {
            Console.WriteLine("Sending message to " + Name + " at " + PhoneNumber);
        }

        public override void Wish()
        {
            Console.WriteLine("Wishing " + Name + " a happy day");
        }

        public override void Display(){
            Console.Write("\n");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Phone Number: " + this.PhoneNumber);
            Console.WriteLine("Category: " + this.Category);
            Console.WriteLine("Relation: " + this.Relation);
            Console.WriteLine("Personal Email: " + this.PersonalEmail);
            Console.WriteLine("Occupation: " + this.Occupation);
            Console.WriteLine("Home Location: " + this.HomeLocation);
            Console.WriteLine("Date of Birth: " + this.DateOfBirth);
        }

        public override Person Update(){
            Console.Write("\nEnter name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter phone number: ");
            this.PhoneNumber = Console.ReadLine();
            Console.Write("Enter relation: ");
            this.Relation = Console.ReadLine();
            Console.Write("Enter personal email: ");
            this.PersonalEmail = Console.ReadLine();
            Console.Write("Enter occupation: ");
            this.Occupation = Console.ReadLine();
            Console.Write("Enter home location: ");
            this.HomeLocation = Console.ReadLine();
            Console.Write("Enter date of birth: ");
            this.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Relative updated successfully!");
            return this;
        }

        public override void Actions(){
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("Select Action for "+this.Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Call \n2. Message \n3. Wish \n4.Cancel Action");
            int choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    this.Call();
                    break;
                case 2:
                    this.Message();
                    break;
                case 3:
                    this.Wish();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
