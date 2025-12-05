namespace MachineManagement
{

    public class MainMenu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Machine Management Console App");
            Console.WriteLine(new string ('-',10));
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
                        AddMachineClass.AddMachineMethod();
                        ExitfunctionClass.ExitMethod();
                        continue;

                    case 2:                                         //Reading List
                        Console.Clear();
                        PrintMenu();
                        ReadMachineClass.ReadMachineMethod();
                        ExitfunctionClass.ExitMethod();
                        continue;

                    case 3:                                          //Searching Data
                        Console.Clear();
                        PrintMenu();
                        SearchMachineClass.SearchMachineFunc();
                        ExitfunctionClass.ExitMethod();
                        continue;

                    case 4:                                          //Update Data                        
                        Console.Clear();
                        PrintMenu();
                        UpdateMachineClass.UpdateMachineFunc();
                        ExitfunctionClass.ExitMethod();
                        continue;
                    case 5:                                           //Delete Machine
                        Console.Clear();
                        PrintMenu();
                        DeleteMachineClass.DeleteMachineFunc();
                        ExitfunctionClass.ExitMethod();
                        continue;
                }
                break;
            }
        }
    }
}
