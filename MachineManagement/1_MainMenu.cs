namespace MachineManagement
{

    public class MainMenu
    {
        public static void PrintMenu()
        {
            Console.Title = "Quan Ly Thiet Bi";
            Console.WriteLine(new string ('=', 30));
            Console.WriteLine("Machine Management Console App");
            Console.WriteLine(new string ('=',30));
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
                        return;
                        
                    case 1:                                         //Adding Machine
                        Console.Clear();
                        PrintMenu();
                        MachinesManger.AddMachineMethod();
                        ExitMethod();
                        continue;

                    case 2:                                         //Reading List
                        Console.Clear();
                        PrintMenu();
                        MachinesManger.ReadMachineMethod();
                        ExitMethod();
                        continue;

                    case 3:                                          //Searching Data
                        Console.Clear();
                        PrintMenu();
                        MachinesManger.SearchMachineFunc();
                        ExitMethod();
                        continue;

                    case 4:                                          //Update Data                        
                        Console.Clear();
                        PrintMenu();
                        MachinesManger.UpdateMachineFunc();
                        ExitMethod();
                        continue;
                    case 5:                                           //Delete Machine
                        Console.Clear();
                        PrintMenu();
                        MachinesManger.DeleteMachineFunc();
                        ExitMethod();
                        continue;
                }
                break;
            }
        }
        public static void ExitMethod()
        {
            bool exitFunc = false;
            while (true)
            {
                Console.Write("\nBack to main menu, press number 0: ");
                string? input = Console.ReadLine();

                // Validate numeric input
                if (!int.TryParse(input, out int exitNum))
                {
                    Console.WriteLine("\nInvalid input. Please enter the number 0.");
                    continue;
                }
                if (exitNum == 0)
                {
                    exitFunc = true;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong key. You must enter 0 to go back to the main menu.");
                }
            }
        }
    }
}
