namespace MachineManagement
{
    internal class UpdateMachineClass
    {
        public static void UpdateMachineFunc()
        {
        Console.WriteLine("---Menu: Cap nhat thong tin thiet bi---\n");
            string tiemkiemID;
            
            while (true)
            {
                Console.Write("Nhap ID may cua thiet bi can tim: ");
                string? checkIDInput = Console.ReadLine();
                if (string.IsNullOrEmpty(checkIDInput))
                {
                    Console.WriteLine("Ban chua nhap data thiet bi");
                    continue;
                }
                else
                {
                    tiemkiemID = checkIDInput;
                }
                break;
            }
            
            List<Machines> danhsachUpdate = DataListClass.TiemkiemThietBi(tiemkiemID);
            
            string updateInput;
            foreach (var machine in danhsachUpdate)
            {
                Console.WriteLine($"Ten thiet bi la: {machine.MachineName}");
                //Update thong tin
                Console.Write("Nhap ten moi (Hoac Enter de giu nguyen): ");
                updateInput = Console.ReadLine();    
                    
                if (updateInput != "")
                {
                    machine.MachineName = updateInput;
                }

                Console.WriteLine($"Loai thiet bi la: {machine.MachineType}");
                Console.Write("Nhap ten moi (Hoac Enter de giu nguyen): ");
                updateInput = Console.ReadLine(); if (updateInput != "")
                {
                    machine.MachineType = updateInput;
                }

                Console.WriteLine($"Nam san xuat: {machine.YearOfMachineManufacturers}");
                Console.Write("Nhap ten moi (Hoac Enter de giu nguyen): ");
                updateInput = Console.ReadLine(); 
                if (updateInput != "")
                {
                    machine.YearOfMachineManufacturers = int.Parse(updateInput);
                }

                Console.WriteLine($"Hang SAn Xuat thiet bi la: {machine.MachineManufacturers}");
                Console.Write("Nhap ten moi (Hoac Enter de giu nguyen): ");
                updateInput = Console.ReadLine(); 
                if (updateInput != "")
                {
                    machine.MachineManufacturers = updateInput;
                }

                Console.WriteLine($"Hang SAn Xuat thiet bi la: {machine.MachineStatus}");
                Console.Write("Nhap ten moi (Hoac Enter de giu nguyen): ");
                updateInput = Console.ReadLine();
                if (updateInput != "")
                {
                    machine.MachineStatus = updateInput;
                }
                break;
            }
        }
    }
}
