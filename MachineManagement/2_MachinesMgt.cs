namespace MachineManagement
{
    public  class MachinesManger
    {
        //Noi luu tru data vao List, Phai luu vao Class ko phai Method
        public static List<Machines> Thietbi = new();
        

        // Vùng nhớ tạm thời đẻ lưu data theo điều kiện tìm kiếm/ Đúng ko anh
        public static List<Machines> TiemkiemMachines(string idTimkiem)
        {
            List<Machines> listTimkiem = new List<Machines>();
            string idTimkiemupper = idTimkiem.ToUpper();

            foreach (Machines machine in Thietbi)
            {
                if (machine.MachineID.Contains(idTimkiemupper) || machine.MachineType.Contains(idTimkiemupper))
                {
                    listTimkiem.Add(machine);
                }
            }
            return listTimkiem;
        }

        public static void AddMachineMethod()
        {
            //var db = new SqliteDataAccess();
            while (true)
            {
                Console.Clear();
                MainMenu.PrintMenu();
                Console.WriteLine("---Menu: Them thiet bi moi---\n");
                Machines objnewMachine = new Machines(); //Tao object

                //Nhap ma thiet bi
                while (true)
                {
                    Console.Write("Nhap ma Thiet Bi: ");
                    string? inputID = Console.ReadLine();
                    bool kiemtraID = false;
                    foreach (var machine in MachinesManger.Thietbi)
                    {
                        if (machine.MachineID.ToUpper() == inputID.ToUpper())
                        {
                            kiemtraID = true;
                            break;
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
                objnewMachine.MachineType = Console.ReadLine();

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
                objnewMachine.MachineBrand = Console.ReadLine();

                Console.Write("Trang thai hien tai cua may: ");
                objnewMachine.MachineStatus = Console.ReadLine();

                //Luu data vao List
                MachinesManger.Thietbi.Add(objnewMachine);
                //db.InsertMachine(objnewMachine);
                Console.WriteLine("Them moi thiet bi thanh cong!");
                Console.WriteLine($"Da nhap duoc {MachinesManger.Thietbi.Count}" + " may vao DB \n");

                //Loop 1
                Console.WriteLine("Bam 'Y' de them tiep, Bam 'F' de hoan tat");
                string userInput = Console.ReadLine().ToUpper();
                if (userInput != "Y")
                {
                    break;
                }
            }
        }
        public static void ReadMachineMethod()
        {
            Console.WriteLine("---Menu: Danh Sach Thiet Bi---");
            Console.WriteLine($"|{"Machine ID",-5}|{"Ten Thiet Bi",-20}|{"Loai",-10}|{"Nam SX",5}|{"Hang San Xuat",-10}|{"Trang Thai",-10}|");
            Console.WriteLine(new string('-', 76));
            foreach (var thietbi in MachinesManger.Thietbi)
            {
                Console.WriteLine($"|{thietbi.MachineID,-10}|{thietbi.MachineName,-20}|{thietbi.MachineType,-10}|{thietbi.YearOfMachineManufacturers,-6}|{thietbi.MachineBrand,-13}|{thietbi.MachineStatus,-10}|");
            }
        }
        public static void SearchMachineFunc()
        {
            string tiemkiemID;
            while (true)
            {
                Console.WriteLine("---Menu: Tim kiem thiet bi---\n");
                Console.Write("Nhap ID hoac Loai may cua thiet bi can tim: ");
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
            List<Machines> danhsachTim = MachinesManger.TiemkiemMachines(tiemkiemID);
            if (danhsachTim.Count == 0)
            {
                Console.WriteLine($"Khong co du lieu cho ID {tiemkiemID} ");
            }
            else
            {
                Console.WriteLine("\nDanh sach thiet bi duoc tim thay la:");
                Console.WriteLine($"|{"Machine ID",-5}|{"Ten Thiet Bi",-20}|{"Loai",-10}|{"Nam SX",5}|{"Hang San Xuat",-10}|{"Trang Thai",-10}|");
                Console.WriteLine(new string('-', 76));
                foreach (var machines in danhsachTim)
                {
                    Console.WriteLine($"|{machines.MachineID,-10}|{machines.MachineName,-20}|{machines.MachineType,-10}|{machines.YearOfMachineManufacturers,-6}|{machines.MachineBrand,-13}|{machines.MachineStatus,-10}|");
                }
            }
        }
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

            List<Machines> danhsachUpdate = MachinesManger.TiemkiemMachines(tiemkiemID);

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

                Console.WriteLine($"Hang san Xuat thiet bi la: {machine.MachineBrand}");
                Console.Write("Nhap ten moi (Hoac Enter de giu nguyen): ");
                updateInput = Console.ReadLine();
                if (updateInput != "")
                {
                    machine.MachineBrand = updateInput;
                }

                Console.WriteLine($"Trang thai cua thiet bi la: {machine.MachineStatus}");
                Console.Write("Nhap ten moi (Hoac Enter de giu nguyen): ");
                updateInput = Console.ReadLine();
                if (updateInput != "")
                {
                    machine.MachineStatus = updateInput;
                }
                Console.WriteLine($"Da cap nhat thong tin thanh cong cho thiet bi ID {tiemkiemID}");
                break;
            }
        }
        public static void DeleteMachineFunc()
        {
            Console.WriteLine("---Menu: Xoa thiet bi---\n");
            string? timkiemID;
            while (true)
            {
                Console.WriteLine("Nhap ma thiet bi can xoa");
                string? IDChecking = Console.ReadLine();
                if (String.IsNullOrEmpty(IDChecking))
                {
                    Console.WriteLine("Ban chua nhap data thiet bi");
                    continue;
                }
                else
                {
                    timkiemID = IDChecking;
                }
                break;
            }

            List<Machines> Xoathietbi = MachinesManger.TiemkiemMachines(timkiemID);

            Console.Write($"Xac nhan xoa thiet bi ID:{timkiemID} Y/N: ");
            string? x = Console.ReadLine();
            if (x == "Y" || x == "y")
            {
                foreach (Machines machines in MachinesManger.Thietbi)
                {
                    MachinesManger.Thietbi.Remove(machines);
                    Console.WriteLine($"Da xoa thiet bi ID {timkiemID}");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Da huy bo viec xoa thiet bi");
            }
        }
    }
}