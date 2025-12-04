namespace MachineManagement
{
    public static class AddMachineClass
    {
        public static void AddMachineMethod()
        {
            while (true)
            {
                Console.Clear();
                MainMenu.PrintMenu();
                Console.WriteLine("---Menu: Them thiet bi moi---\n");

                Machines objnewMachine = new(); //Tao object

                while (true)
                {
                    Console.Write("Nhap ma Thiet Bi: ");
                    string inputID = Console.ReadLine();
                    bool kiemtraID = false;
                    foreach(var machine in DataListClass.Thietbi)
                    {
                        if(machine.MachineID == inputID)
                        {
                            kiemtraID = true;
                            break ;
                        }
                    }
                    if (kiemtraID == true)
                    {
                        Console.WriteLine($"Ooop! Ma Thiet Bi ID: {inputID} da ton tai, Vui long thu lai");
                    }
                    else
                    {
                        objnewMachine.MachineID = inputID;
                        break;
                    }
                }
                Console.Write("Nhap ten Thiet Bi: ");
                objnewMachine.MachineName = Console.ReadLine();
                Console.Write("Nhap kieu Thiet Bi: ");
                objnewMachine.MachineType = Console.ReadLine();
                Console.Write("Nhap nam san xuat: ");
                objnewMachine.YearOfMachineManufacturers =int.Parse(Console.ReadLine());
                Console.Write("Nhap Hang san xuat: ");
                objnewMachine.MachineManufacturers = Console.ReadLine();
                Console.Write("Trang thai hien tai cua may: ");
                objnewMachine.MachineStatus = Console.ReadLine();

                //Luu data vao List
                DataListClass.Thietbi.Add(objnewMachine); 
                Console.WriteLine("Them moi thiet bi thanh cong!");
                Console.WriteLine($"Da nhap duoc {DataListClass.Thietbi.Count}"+" may vao DB");
                
                //Loop 1
                Console.WriteLine("Bam 'Y' de them tiep, Bam 'F' de hoan tat");
                string userInput = Console.ReadLine().ToUpper();
                if (userInput != "Y")
                {
                    break;
                }
            }
        }
    }
}
