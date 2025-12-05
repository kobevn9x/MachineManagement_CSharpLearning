namespace MachineManagement
{
    public class ReadMachineClass
    {
        public static void ReadMachineMethod()
        {
            Console.WriteLine("---Menu: Danh Sach Thiet Bi---");
            Console.WriteLine($"|{"Machine ID",-5}|{"Ten Thiet Bi",-20}|{"Loai",-10}|{"Nam SX", 5}|{"Hang San Xuat", -10}|{"Trang Thai",-10}|");
            Console.WriteLine(new string('-', 76));
            foreach (var thietbi in DataListClass.Thietbi)
            {
                Console.WriteLine($"|{thietbi.MachineID,-10}|{thietbi.MachineName,-20}|{thietbi.MachineType,-10}|{thietbi.YearOfMachineManufacturers,-6}|{thietbi.MachineManufacturers,-13}|{thietbi.MachineStatus,-10}|");
            }
        }
    }
}
