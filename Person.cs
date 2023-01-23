namespace myDairy{
    abstract class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Category { get; set; }

        public Person(string name, string phoneNumber, string category)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Category = category;
        }

        public abstract void Call();
        public abstract void Message();
        public abstract void Wish();
        public abstract void Display();
        public abstract Person Update();
        public abstract void Actions();
    }
}