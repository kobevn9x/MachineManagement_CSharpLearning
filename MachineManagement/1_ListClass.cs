namespace MachineManagement
{
    public static class DataListClass
    {
        //Noi luu tru data vao List, Phai luu vao Class ko phai Method
        public static List<Machines> Thietbi = new List<Machines>();

        // Before
        // public static Machines TiemkiemThietBi(string idTimkiem)
        /*Thu dung thang List goc*/
        public static List<Machines> TiemkiemThietBi(string idTimkiem)
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

    }
}
