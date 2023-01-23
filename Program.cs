using System;

namespace myDairy
{
    class Program : MenuDriven
    {
        static void Main(string[] args)
        {   
            //sorted list to store all contacts
            SortedList<string, Person> contactList = new SortedList<string, Person>();
            
            bool exit = false;

            while (!exit)
            {   
                Console.WriteLine("\n-----------------------");
                Console.WriteLine("WELCOME TO PHONE DAIRY:");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contact");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Update Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    //add contact functions
                    case 1:
                        Console.WriteLine("\n-----------------------");
                        Console.WriteLine("ADDING NEW CATEGORY:");
                        Console.WriteLine("-----------------------");
                        Console.Write("\n1. Colleague \n2. Relative  \n3. Technician \n4. Stranger \nENTER CATEGORY TYPE : ");
                        int contactType = Convert.ToInt32(Console.ReadLine());
                        switch (contactType)
                        {
                            case 1:
                                MenuDriven.AddColleague(contactList);
                                break;
                            case 2:
                                MenuDriven.AddRelative(contactList);
                                break;
                            case 3:
                                MenuDriven.AddTechnician(contactList);
                                break;
                            case 4:
                                MenuDriven.AddStranger(contactList);
                                break;
                            default:
                                Console.WriteLine("Invalid Category type!");
                                break;
                        }
                        break;

                    //view contacts functions
                    case 2:
                        Console.WriteLine("\n-----------------------");
                        Console.WriteLine("TO DISPLAY CONTACTS:");
                        Console.WriteLine("-----------------------");
                        Console.Write("\n1. All Category \n2. Colleague \n3. Relative  \n4. Technician \n5. Stranger \nENTER CATEGORY TYPE: ");
                        contactType = Convert.ToInt32(Console.ReadLine());
                        switch (contactType)
                        {
                            case 1:
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("ALL CATEGORY CONTACTS:");
                                Console.WriteLine("-----------------------");
                                MenuDriven.PrintContacts(contactList,0);
                                break;
                            case 2:
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("ALL COLLEAGUES CONTACTS:");
                                Console.WriteLine("-----------------------");
                                MenuDriven.PrintContacts(contactList,1);
                                break;
                            case 3:
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("ALL RELATIVES CONTACTS:");
                                Console.WriteLine("-----------------------");
                                MenuDriven.PrintContacts(contactList,2);
                                break;
                            case 4:
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("ALL TECHNICIANS CONTACTS:");
                                Console.WriteLine("-----------------------");
                                MenuDriven.PrintContacts(contactList,3);
                                break;
                            case 5:
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("ALL STRANGERS CONTACTS:");
                                Console.WriteLine("-----------------------");
                                MenuDriven.PrintContacts(contactList,4);
                                break;
                            default:
                                Console.WriteLine("Invalid Category type!");
                                break;
                        }
                        break;
                    
                    //search functions
                    case 3:
                        Console.WriteLine("\n-----------------------");
                        Console.WriteLine("TO SEARCH CONTACTS:");
                        Console.WriteLine("-----------------------");
                        Console.Write("\n1. All Category \n2. Colleague \n3. Relative  \n4. Technician \n5. Stranger \nENTER CATEGORY TYPE : ");
                        contactType = Convert.ToInt32(Console.ReadLine());
                        switch (contactType)
                        {
                            case 1:
                                Console.Write("\n\n1. Search By Name \n2. Search By Number \nEnter type: ");
                                int SearchType = Convert.ToInt32(Console.ReadLine());
                                switch (SearchType){
                                    case 1:
                                        //search with name in all contacts
                                        Console.Write("\nEnter Name to Search: ");
                                        string SearchName= Console.ReadLine();
                                        Person obj = MenuDriven.SearchByName(contactList,SearchName.ToLower());
                                        if(obj!=null){
                                            obj.Display();
                                            obj.Actions();
                                        }else{
                                            Console.WriteLine("NOT FOUND...");
                                        }
                                        break;
                                    case 2:
                                        //search with phone number in all contacts
                                        Console.Write("\nEnter Phone Number to Search: ");
                                        string PhoneNoSearch= Console.ReadLine();
                                        obj = MenuDriven.SearchByPhoneNumber(contactList,PhoneNoSearch);
                                        if(obj!=null){
                                            obj.Display();
                                            obj.Actions();
                                        }else{
                                            Console.WriteLine("NOT FOUND...");
                                        }
                                        break;
                                }
                                break;

                            case 2:
                                //search in colleagues
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("DYNAMIC SEARCH IN COLLEAGUES:");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("ENTER ANY ATTRIBUTE VALUE TO SEARCH: ");
                                string DynamicTarget = Console.ReadLine();
                                MenuDriven.DynamicSearch(contactList,DynamicTarget,1);
                                break;
                            case 3:
                                //search in relatives
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("DYNAMIC SEARCH IN RELATIVES:");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("ENTER ANY ATTRIBUTE VALUE TO SEARCH: ");
                                DynamicTarget = Console.ReadLine();
                                MenuDriven.DynamicSearch(contactList,DynamicTarget,2);
                                break;
                            case 4:
                                //search in technicians
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("DYNAMIC SEARCH IN TECHNICIANS:");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("ENTER ANY ATTRIBUTE VALUE TO SEARCH: ");
                                DynamicTarget = Console.ReadLine();
                                MenuDriven.DynamicSearch(contactList,DynamicTarget,3);
                                break;
                            case 5:
                                //search in strangers
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("DYNAMIC SEARCH IN STRANGERS:");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("ENTER ANY ATTRIBUTE VALUE TO SEARCH: ");
                                DynamicTarget = Console.ReadLine();
                                MenuDriven.DynamicSearch(contactList,DynamicTarget,4);
                                break;
                        }
                        break;
                    
                    //Update functions
                    case 4:
                        Console.WriteLine("\n-----------------------");
                        Console.WriteLine("TO UPDATE CONTACTS:");
                        Console.WriteLine("-----------------------");
                        Console.Write("\n\n1. Search & Update By Name: \n2. Search & Update By Number: \nEnter type: ");
                        int UpdateType = Convert.ToInt32(Console.ReadLine());
                        switch (UpdateType){
                            case 1:
                                //search with name in all contacts
                                Console.Write("\nEnter Name to Search: ");
                                string SearchName= Console.ReadLine();
                                Person obj = MenuDriven.SearchByName(contactList,SearchName);
                                if (obj != null){
                                    obj.Display();
                                    contactList.Remove(obj.Name);
                                }
                                else
                                    Console.WriteLine("No contact found with the given name.");
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("EDIT "+obj.Name+" DETAILS:");
                                Console.WriteLine("-----------------------");
                                Person UpdatedObject = obj.Update();
                                contactList.Add(UpdatedObject.Name ,UpdatedObject);
                                break;
                            case 2:
                                //search with phone number in all contacts
                                Console.Write("\nEnter Phone Number to Search: ");
                                string PhoneNoSearch= Console.ReadLine();
                                obj = MenuDriven.SearchByPhoneNumber(contactList,PhoneNoSearch);
                                if (obj != null){
                                    obj.Display();
                                    contactList.Remove(obj.Name);
                                }
                                else
                                    Console.WriteLine("No contact found with the given name.");
                                Console.WriteLine("\n-----------------------");
                                Console.WriteLine("EDIT "+obj.Name+" DETAILS:");
                                Console.WriteLine("-----------------------");
                                UpdatedObject = obj.Update();
                                contactList.Add(UpdatedObject.Name ,UpdatedObject);
                                break;
                        }
                        break;

                    //delete functions
                    case 5:
                        Console.WriteLine("\n-----------------------");
                        Console.WriteLine("TO DELETE CONTACTS:");
                        Console.WriteLine("-----------------------");
                        Console.Write("\n\n1. Search & Delete By Name: \n2. Search & Delete By Number: \nEnter type: ");
                        int DeleteType = Convert.ToInt32(Console.ReadLine());
                        switch (DeleteType){
                            case 1:
                                //search with name in all contacts
                                Console.Write("\nEnter Name to Search: ");
                                string SearchName= Console.ReadLine();
                                Person obj = MenuDriven.SearchByName(contactList,SearchName);
                                if (obj != null){
                                    obj.Display();
                                    contactList.Remove(obj.Name);
                                }
                                else
                                    Console.WriteLine("No contact found with the given name.");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("CONTACT DELETED");
                                break;
                            case 2:
                                //search with phone number in all contacts
                                Console.Write("\nEnter Phone Number to Search: ");
                                string PhoneNoSearch= Console.ReadLine();
                                obj = MenuDriven.SearchByPhoneNumber(contactList,PhoneNoSearch);
                                if (obj != null){
                                    obj.Display();
                                    contactList.Remove(obj.Name);
                                }
                                else
                                    Console.WriteLine("No contact found with the given name.");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("CONTACT DELETED");
                                break;
                        }
                        break;
                    
                    //exit code
                    case 6:
                        Console.WriteLine("Bye...");
                        exit = true;
                        break;
                    
                    //default
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}