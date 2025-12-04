namespace MachineManagement
{
    public class ReadMachineClass
    {
        public static void ReadMachineMethod()
        {
            foreach (var thietbi in DataListClass.Thietbi)
            {
                Console.WriteLine();
                Console.WriteLine($"ID: {thietbi.MachineID} | Ten Thiet Bi: {thietbi.MachineName} | Loai Thiet Bi: {thietbi.MachineType} | Nam San Xuat: {thietbi.YearOfMachineManufacturers} | Hang san xuat: {thietbi.MachineManufacturers} | Trang Thai: {thietbi.MachineStatus}");
            }
        }

    }
}
