namespace myDairy
{
    class Stranger : Person
    {
        public Stranger(string name, string phoneNumber) 
            : base(name, phoneNumber, "Stranger")
        {}

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

        public void SendIntroductoryMessage()
        {
            Console.WriteLine("Introductory message sent to " + Name);
        }

        public override void Display(){
            Console.Write("\n");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Phone Number: " + this.PhoneNumber);
            Console.WriteLine("Category: " + this.Category);
        }

        public override Person Update(){
            Console.Write("\nEnter name: ");
            this.Name = Console.ReadLine().ToLower();
            Console.Write("Enter phone number: ");
            this.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Stranger updated successfully!");
            return this;
        }

        public override void Actions(){
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("Select Action for "+this.Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Call \n2. Message \n3. Wish \n4. SendIntroductoryMessage \n5. Cancel Action");
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
                    this.SendIntroductoryMessage();
                    break;
                case 5:
                    break;
            }
        }
    }
}