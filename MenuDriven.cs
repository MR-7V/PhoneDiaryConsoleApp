using System;

namespace myDairy
{
    class MenuDriven : Validate
    {
        //Adding functions
        protected static void AddColleague(SortedList<string, Person> contactList)
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();

            //validate phonenumber
            string phoneNumber = Validate.Validation();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();
            Console.Write("Enter company: ");
            string company = Console.ReadLine();
            //to vaildate email
            Console.Write("Enter personal email: ");
            string personalEmail = Console.ReadLine();
            string email = Validate.Validation(personalEmail);
            Console.Write("Enter location: ");
            string location = Console.ReadLine();
            contactList.Add(name.ToLower(), new Colleague(name.ToLower(), phoneNumber, role.ToLower(), company.ToLower(), email.ToLower(), location.ToLower()));
            Console.WriteLine("Colleague added successfully!");
        }

        protected static void AddRelative(SortedList<string, Person> contactList)
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();
            //validate phonenumber
            string phoneNumber = Validate.Validation();
            Console.Write("Enter relation: ");
            string relation = Console.ReadLine();
            //to vaildate email
            Console.Write("Enter personal email: ");
            string personalEmail = Console.ReadLine();
            personalEmail = Validate.Validation(personalEmail);
            Console.Write("Enter occupation: ");
            string occupation = Console.ReadLine();
            Console.Write("Enter home location: ");
            string homeLocation = Console.ReadLine();
            Console.Write("Enter date of birth: ");
            string dateOfBirth = Console.ReadLine();
            contactList.Add(name.ToLower(), new Relative(name.ToLower(), phoneNumber, relation.ToLower(), personalEmail.ToLower(), occupation.ToLower(), homeLocation.ToLower(), dateOfBirth.ToLower()));
            Console.WriteLine("Relative added successfully!");
        }

        protected static void AddTechnician(SortedList<string, Person> contactList)
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();
            //validate phonenumber
            string phoneNumber = Validation();
            Console.Write("Enter occupation: ");
            string occupation = Console.ReadLine();
            Console.Write("Enter location: ");
            string location = Console.ReadLine();
            contactList.Add(name.ToLower(), new Technician(name.ToLower(), phoneNumber, occupation.ToLower(), location.ToLower()));
            Console.WriteLine("Technician added successfully!");
        }

        protected static void AddStranger(SortedList<string, Person> contactList)
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();
            //validate phonenumber
            string phoneNumber = Validate.Validation();
            contactList.Add(name.ToLower(), new Stranger(name.ToLower(), phoneNumber));
            Console.WriteLine("Stranger added successfully!");
        }


        //viewing functions
        protected static void PrintContacts(SortedList<string, Person> contactList, int selector)
        {
            foreach (KeyValuePair<string, Person> contact in contactList)
            {   
                if (contact.Value is Colleague col && (selector==0 || selector==1) )
                {
                    /*Console.Write("\n");
                    Console.WriteLine("Name: " + contact.Value.Name);
                    Console.WriteLine("Phone Number: " + contact.Value.PhoneNumber);
                    Console.WriteLine("Category: " + col.Category);
                    Console.WriteLine("Role: " + col.Role);
                    Console.WriteLine("Company: " + col.Company);
                    Console.WriteLine("Email: " + col.WorkEmail);
                    Console.WriteLine("Location: " + col.WorkLocation);*/
                    col.Display();
                }
                else if (contact.Value is Relative rel && (selector==0 || selector==2))
                {
                    rel.Display();
                }
                else if (contact.Value is Technician tech && (selector==0 || selector==3))
                {
                    tech.Display();
                }
                else if (contact.Value is Stranger stra && (selector==0 || selector==4))
                {
                    stra.Display();
                }  
            } 
        }


        //search functions
        protected static Person SearchByName(SortedList<string, Person> contactList, string searchTerm) {
            Person result = null;
            // search by name
            if (contactList.ContainsKey(searchTerm.ToLower())) {
                try
                {
                    result = contactList[searchTerm];
                    Console.WriteLine(result.Category);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return result;
        }


        //search by number
        protected static Person SearchByPhoneNumber(SortedList<string, Person> contactList, string attribute) {
            Person result = null;
            foreach (KeyValuePair<string, Person> entry in contactList) {
                Person person = entry.Value;
                if (person.PhoneNumber == attribute.ToLower()) {
                    result = person;
                    break;
                }
            }
            return result;
        }


        //Dynamic search
        protected static void DynamicSearch(SortedList<string, Person> contactList, string target, int selector)
        {   
            int flag = 0;  //checker
            target = target.ToLower();
            switch(selector)
            {
                case 1:
                    foreach (KeyValuePair<string, Person> entry in contactList) {
                        Person person = entry.Value;
                        if (person is Colleague colleague) {
                            if (colleague.Name == target || colleague.PhoneNumber == target || colleague.Role == target || colleague.Company == target || colleague.WorkEmail == target || colleague.WorkLocation == target) {
                                colleague.Display();
                                colleague.Actions();
                                flag=1;  //if found any object
                            }
                        }
                    }
                    break;
                case 2:
                    foreach (KeyValuePair<string, Person> entry in contactList) {
                        Person person = entry.Value;
                        if (person is Relative relative) {
                            if (relative.Name == target || relative.PhoneNumber == target || relative.Relation == target || relative.PersonalEmail == target || relative.Occupation == target || relative.HomeLocation == target || relative.DateOfBirth == target)  {
                                relative.Display();
                                relative.Actions();
                                flag=1;
                            }
                        }
                    }
                    break;
                case 3:
                    foreach (KeyValuePair<string, Person> entry in contactList) {
                        Person person = entry.Value;
                        if (person is Technician technician) {
                            if (technician.Name == target || technician.PhoneNumber == target || technician.Occupation == target || technician.Location == target ) {
                                technician.Display();
                                technician.Actions();
                                flag=1;
                            }
                        }
                    }
                    break;
                case 4:
                    foreach (KeyValuePair<string, Person> entry in contactList) {
                        Person person = entry.Value;
                        if (person is Stranger stranger) {
                            if (stranger.Name == target || stranger.PhoneNumber == target ) {
                                stranger.Display();
                                stranger.Actions();
                                flag=1;
                            }
                        }
                    }
                    break;
            }
            if(flag==0){
                Console.WriteLine("NOT FOUND ANY CONTACT...");
            }
        }
    }
}



