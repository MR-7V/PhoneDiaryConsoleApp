namespace myDairy
{
    class Colleague : Person
    {
        public string Role { get; set; }
        public string Company { get; set; }
        public string WorkEmail { get; set; }
        public string WorkLocation { get; set; }

        public Colleague(string name, string phoneNumber, string role, string company, string workEmail, string workLocation) 
            : base(name, phoneNumber, "Colleague")
        {
            Role = role;
            Company = company;
            WorkEmail = workEmail;
            WorkLocation = workLocation;
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
            Console.WriteLine("Role: " + this.Role);
            Console.WriteLine("Company: " + this.Company);
            Console.WriteLine("Email: " + this.WorkEmail);
            Console.WriteLine("Location: " + this.WorkLocation);
        }

        public override Person Update(){
            Console.Write("\nEnter name: ");
            this.Name = Console.ReadLine().ToLower();
            Console.Write("Enter phone number: ");
            this.PhoneNumber = Console.ReadLine();
            Console.Write("Enter role: ");
            this.Role = Console.ReadLine();
            Console.Write("Enter company: ");
            this.Company = Console.ReadLine();
            Console.Write("Enter email: ");
            this.WorkEmail = Console.ReadLine();
            Console.Write("Enter location: ");
            this.WorkLocation = Console.ReadLine();
            Console.WriteLine("Colleague updated successfully!");
            return this;
        }

        public override void Actions(){
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("Select Action for "+this.Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Call \n2. Message \n3. Wish \n4. Cancel Action");
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









/*
        private string role;
        private string company;
        private string workEmail;
        private string workLocation;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string WorkEmail
        {
            get { return workEmail; }
            set { workEmail = value; }
        }

        public string WorkLocation
        {
            get { return workLocation; }
            set { workLocation = value; }
        }
*/