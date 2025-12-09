using Dapper;
using System.Data;
using System.Reflection.PortableExecutable;

namespace SQLiteConnection
{
    public class DatabaseConnect
    {
        private string  _connectionString = @"D:\MSSQLLocalDB\myData.db;Version=3;";
        public List<Machine> LoadMachines()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                // Query<T>: Tự động map kết quả SQL vào List<Machine>
                var output = cnn.Query<Machine>("SELECT * FROM Machines");
                return output.ToList();
            }
        }

    }
    public class SqliteDataAccess
    {
        private string _connString = @"Data Source=D:\MyFactoryData.db;Version=3;";

        // 1. Create (Thêm)
        public void InsertMachine(Machines m)
        {
            using (IDbConnection cnn = new SQLiteConnection(_connString))
            {
                // Dapper tự lấy giá trị từ m.ID, m.Name... điền vào @ID, @Name...
                string sql = "INSERT INTO Machine (MachineID, MachineName, MachineType, MachineManufacturers,YearOfMachineManufacturers,MachineStatus) VALUES (@MachineID, @MachineName, @MachineType, @MachineManufacturers,@YearOfMachineManufacturers,@MachineStatus)";
                cnn.Execute(sql, m);
            }
        }

        // 2. Read (Đọc tất cả)
        public List<Machine> GetAllMachines()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connString))
            {
                return cnn.Query<Machine>("SELECT * FROM Machine").ToList();
            }
        }

        // 3. Update (Sửa)
        public void UpdateMachine(Machine m)
        {
            using (IDbConnection cnn = new SQLiteConnection(_connString))
            {
                // Cập nhật thông tin dựa trên ID
                string sql = "UPDATE Machine SET Name = @Name, Type = @Type, Year = @Year WHERE ID = @ID";
                cnn.Execute(sql, m);
            }
        }

        // 4. Delete (Xóa)
        public void DeleteMachine(string idCanXoa)
        {
            using (IDbConnection cnn = new SQLiteConnection(_connString))
            {
                // Tạo đối tượng ẩn danh (new { ... }) để truyền tham số @ID
                string sql = "DELETE FROM Machine WHERE ID = @ID";
                cnn.Execute(sql, new { ID = idCanXoa });
            }
        }
    }
}
