using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance:\t");

            // Create long variable to hold item number
            long itemNumber;

            // Get user input as string and assign to variable.
            string input;
            input = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            itemNumber = Convert.ToInt64(input);

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                // Assign appliance in list to foundAppliance variable
                {
                    foundAppliance = appliance;
                    // Break out of loop (since we found what need to)
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }
            // Otherwise (appliance was found)
            else
            {
                // Test found appliance is available
                if (foundAppliance.IsAvailable)
                {
                    // Checkout found appliance
                    foundAppliance.Checkout();

                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has heen checked out.");
                }
                // Otherwise (appliance isn't available)
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string brand = Console.ReadLine();


            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.Brand == brand)
                {
                    found.Add(appliance);
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");

            // Create variable to hold entered number of doors
            string input;
            int doors = 0;

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");

            // Get user input as string and assign to variable
            input = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            switch (input)
            {
                case "0":
                case "2":
                case "3":
                case "4":
                    doors = Convert.ToInt16(input);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid number of doors.");
                    break;
            }

            // Create list to hold found Appliance objects
            var found = new List<Appliance>();

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator refrigerator)
                {
                    if (doors == 0 || refrigerator.Doors == doors)
                    {
                        found.Add(refrigerator);
                    }
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            /// <summary>
            /// Dispaly Vacuums
            /// </summary>
            /// <remarks>Author: Carson Yang</remarks>
            /// <remarks>Date: 3 Feb 2024</remarks>
            /// 

            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");

            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");

            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            switch (userInput)
            {
                case "0":
                    grade = "Any";
                    break;
                case "1":
                    grade = "Residential";
                    break;
                case "2":
                    grade = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    // Return to calling (previous) method
                    // return;
                    return;
            }

            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");

            // Get user input as string
            // Create variable to hold voltage
            userInput = Console.ReadLine();
            int voltage;

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            switch (userInput)
            {
                case "0":
                    voltage = 0;
                    break;
                case "1":
                    voltage = 18;
                    break;
                case "2":
                    voltage = 24;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage

                    if ((grade == "Any" || grade == vacuum.Grade) && (voltage == 0 || voltage == vacuum.BatteryVoltage))
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                        // Display found appliances
                        // DisplayAppliancesFromList(found, 0);
                        DisplayAppliancesFromList(found, 0);
                    }
                }
            }
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();

            // Create character variable that holds room type
            char room_type;

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            switch (input)
            {
                case "0":
                    room_type = 'A';
                    break;
                case "1":
                    room_type = 'K';
                    break;
                case "2":
                    room_type = 'W';
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if (room_type == 'A' || microwave.RoomType == room_type)
                    {
                        found.Add(microwave);
                    }
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter the sound rating of the dishwasher:");

            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();

            // Create variable that holds sound rating
            string soundRating;

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            switch (userInput)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Qt";
                    break;
                case "2":
                    soundRating = "Qr";
                    break;
                case "3":
                    soundRating = "Qu";
                    break;
                case "4":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }
            // Create variable that holds list of found appliances
            var found = new List<Appliance>();
            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher
            foreach (var appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        found.Add(dishwasher);
                    }
                }
            }
            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");
            // Get user input as string and assign to appliance type variable
            string appliance_type = Console.ReadLine();

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");
            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Convert user input from string to int
            int num = Convert.ToInt16(input);

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                switch (appliance_type)
                {
                    case "0":
                        found.Add(appliance);
                        break;
                    case "1":
                        if (appliance is Refrigerator)
                        {
                            found.Add(appliance);
                        }
                        break;
                    case "2":
                        if (appliance is Vacuum)
                        {
                            found.Add(appliance);
                        }
                        break;
                    case "3":
                        if (appliance is Microwave)
                        {
                            found.Add(appliance);
                        }
                        break;
                    case "4":
                        if (appliance is Dishwasher)
                        {
                            found.Add(appliance);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        return;
                }
            }

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());
            found.Sort(new RandomComparer());
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            DisplayAppliancesFromList(found, num);
        }
    }
}
