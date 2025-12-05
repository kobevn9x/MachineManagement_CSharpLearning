namespace MachineManagement
{
    public class DeleteMachineClass
    {
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

            List<Machines> Xoathietbi = DataListClass.TiemkiemThietBi(timkiemID);
            
            Console.Write($"Xac nhan xoa thiet bi ID:{timkiemID} Y/N: ");
            string? x = Console.ReadLine();
            if (x == "Y" || x == "y")
            {
                foreach(Machines machines in DataListClass.Thietbi )
                {
                    DataListClass.Thietbi.Remove(machines);
                    Console.WriteLine($"Da xoa thiet bi ID {timkiemID}");
                    break;
                }
            }
            else {
                Console.WriteLine("Da huy bo viec xoa thiet bi");
            }
        }
    }
}
