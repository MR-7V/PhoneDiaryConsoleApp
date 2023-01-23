namespace myDairy
{
    class Technician : Person
    {
        public string Occupation { get; set; }
        public string Location { get; set; }

        public Technician(string name, string phoneNumber, string occupation, string location) 
            : base(name, phoneNumber, "Technician")
        {
            Occupation = occupation;
            Location = location;
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

        public void ScheduleAppointment()
        {
            Console.WriteLine("Appointment scheduled with " + Name );
        }

        public void ConfirmAppointment()
        {
            Console.WriteLine("Appointment confirmed with " + Name);
        }

        public override void Display(){
            Console.Write("\n");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Phone Number: " + this.PhoneNumber);
            Console.WriteLine("Category: " + this.Category);
            Console.WriteLine("Occupation: " + this.Occupation);
            Console.WriteLine("Location: " + this.Location);
        }

        public override Person Update(){
            Console.Write("\nEnter name: ");
            this.Name = Console.ReadLine().ToLower();
            Console.Write("Enter phone number: ");
            this.PhoneNumber = Console.ReadLine();
            Console.Write("Enter occupation: ");
            this.Occupation = Console.ReadLine();
            Console.Write("Enter location: ");
            this.Location = Console.ReadLine();
            Console.WriteLine("Technician updated successfully!");
            return this;
        }

        public override void Actions(){
            Console.WriteLine("Select Action for "+this.Name);
            Console.WriteLine("1. Call \n2. Message \n3. Wish \n4. ScheduleAppointment \n5. ConfirmAppointment");
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
                    this.ScheduleAppointment();
                    break;
                case 5:
                    this.ConfirmAppointment();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
                    
            }
        }
    }
}