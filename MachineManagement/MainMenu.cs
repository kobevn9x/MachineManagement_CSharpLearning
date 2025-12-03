namespace MachineManagement
{

    public class MainMenu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Machine Management Console App");
            Console.WriteLine("===============================\n");
        }
        static void MainMenuFunc()
        {
            Console.WriteLine("1. Adding machine");
            Console.WriteLine("2. List Machines");
            Console.WriteLine("3. Searching Machine");
            Console.WriteLine("4. Update Machine Information");
            Console.WriteLine("5. Delete Machine");
            Console.WriteLine("0. Exit");
            //Console.WriteLine();
            Console.WriteLine("===============================\n");

            Console.Write("Select menu funtion: ");
        }
        public static void Main()
        {

            //Creator variables
            int selectMenu;
            bool exitFunc = false;

            while (true)
            {
                //Main Menu
                PrintMenu();
                MainMenuFunc();

                selectMenu = Convert.ToInt32(Console.ReadLine());

                switch (selectMenu)
                {
                    case 0:

                        Console.Clear();
                        exitFunc = false;
                        return;

                    case 1:
                        Console.Clear();
                        PrintMenu();
                        AddMachinefunc.AddMchine();
                        //Return Menu
                        while (true)
                        {
                            Console.Write("Back to main menu, press number 0: ");
                            string? input = Console.ReadLine();

                            // Validate numeric input
                            if (!int.TryParse(input, out int exitNum))
                            {
                                Console.WriteLine("Invalid input. Please enter the number 0.");
                                continue;
                            }

                            // Validate correct value
                            if (exitNum == 0)
                            {
                                exitFunc = true;
                                Console.Clear();
                                break; // exit this loop
                            }
                            else
                            {
                                Console.WriteLine("Wrong key. You must enter 0 to go back to the main menu.");
                            }
                        }
                        continue;

                    case 2:
                        Console.Clear();
                        PrintMenu();
                        /*
                         Add code
                         */


                        //Return Menu
                        while (true)
                        {
                            Console.Write("Back to main menu, press number 0: ");
                            string input = Console.ReadLine();

                            // Validate numeric input
                            if (!int.TryParse(input, out int exitNum))
                            {
                                Console.WriteLine("Invalid input. Please enter the number 0.");
                                continue;
                            }

                            // Validate correct value
                            if (exitNum == 0)
                            {
                                exitFunc = true;
                                Console.Clear();
                                break; // exit this loop
                            }
                            else
                            {
                                Console.WriteLine("Wrong key. You must enter 0 to go back to the main menu.");
                            }
                        }
                        continue;
                    case 3:
                        Console.Clear();
                        PrintMenu();
                        /*
                         Add code
                         */


                        //Return Menu
                        while (true)
                        {
                            Console.Write("Back to main menu, press number 0: ");
                            string input = Console.ReadLine();

                            // Validate numeric input
                            if (!int.TryParse(input, out int exitNum))
                            {
                                Console.WriteLine("Invalid input. Please enter the number 0.");
                                continue;
                            }

                            // Validate correct value
                            if (exitNum == 0)
                            {
                                exitFunc = true;
                                Console.Clear();
                                break; // exit this loop
                            }
                            else
                            {
                                Console.WriteLine("Wrong key. You must enter 0 to go back to the main menu.");
                            }
                        }
                        continue;
                    case 4:
                        Console.Clear();
                        PrintMenu();
                        /*
                         Add code
                         */


                        //Return Menu
                        while (true)
                        {
                            Console.Write("Back to main menu, press number 0: ");
                            string input = Console.ReadLine();

                            // Validate numeric input
                            if (!int.TryParse(input, out int exitNum))
                            {
                                Console.WriteLine("Invalid input. Please enter the number 0.");
                                continue;
                            }

                            // Validate correct value
                            if (exitNum == 0)
                            {
                                exitFunc = true;
                                Console.Clear();
                                break; // exit this loop
                            }
                            else
                            {
                                Console.WriteLine("Wrong key. You must enter 0 to go back to the main menu.");
                            }
                        }
                        continue;
                    case 5:
                        Console.Clear();
                        PrintMenu();
                        /*
                         Add code
                         */


                        //Return Menu
                        while (true)
                        {
                            Console.Write("Back to main menu, press number 0: ");
                            string input = Console.ReadLine();

                            // Validate numeric input
                            if (!int.TryParse(input, out int exitNum))
                            {
                                Console.WriteLine("Invalid input. Please enter the number 0.");
                                continue;
                            }

                            // Validate correct value
                            if (exitNum == 0)
                            {
                                exitFunc = true;
                                Console.Clear();
                                break; // exit this loop
                            }
                            else
                            {
                                Console.WriteLine("Wrong key. You must enter 0 to go back to the main menu.");
                            }
                        }
                        continue;
                }
                Console.WriteLine("Bye!, See you again!");
                Console.ReadKey();
                break;
            }
        }
    }
}
