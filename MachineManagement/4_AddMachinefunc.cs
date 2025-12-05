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

                //Nhap ma thiet bi
                while (true)
                {
                    Console.Write("Nhap ma Thiet Bi: ");
                    string? inputID = Console.ReadLine();
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
                        objnewMachine.MachineID = inputID.ToUpper();
                        break;
                    }
                }
                Console.Write("Nhap ten Thiet Bi: ");
                objnewMachine.MachineName = Console.ReadLine();

                Console.Write("Nhap kieu Thiet Bi: ");
                string? machinestyleInput = Console.ReadLine();
                objnewMachine.MachineType = machinestyleInput.ToUpper();

                while (true) 
                { 
                    int Namsx = 0;
                    Console.Write("Nhap nam san xuat: ");
                    string? StringNamsx = Console.ReadLine();

                    if (string.IsNullOrEmpty(StringNamsx))
                    {
                        Console.WriteLine("Nam san xuat ko the de trong");
                        continue;
                    }

                    bool isNumber = int.TryParse(StringNamsx, out Namsx);
                    if (isNumber == false)
                    {
                        Console.WriteLine("Nam san xuat pha la so, Vi du: 2020");
                        continue;
                    }
                    else
                    {
                         objnewMachine.YearOfMachineManufacturers = Namsx;
                    }
                        break;
                }
                Console.Write("Nhap Hang san xuat: ");
                objnewMachine.MachineManufacturers = Console.ReadLine();

                Console.Write("Trang thai hien tai cua may: ");
                objnewMachine.MachineStatus = Console.ReadLine();

                //Luu data vao List
                DataListClass.Thietbi.Add(objnewMachine); 
                Console.WriteLine("Them moi thiet bi thanh cong!");
                Console.WriteLine($"Da nhap duoc {DataListClass.Thietbi.Count}"+" may vao DB \n");
                
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
