namespace MachineManagement
{
    public class SearchMachineClass
    {
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
            List<Machines> danhsachTim = DataListClass.TiemkiemThietBi(tiemkiemID);
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
                    Console.WriteLine($"|{machines.MachineID,-10}|{machines.MachineName,-20}|{machines.MachineType,-10}|{machines.YearOfMachineManufacturers,-6}|{machines.MachineManufacturers,-13}|{machines.MachineStatus,-10}|");
                }
            }
        }
    }
}
