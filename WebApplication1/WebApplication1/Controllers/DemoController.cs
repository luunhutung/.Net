using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPCore.ADONETLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        string ConnectionString = @"Data Source=.;Initial Catalog=eStore20;Integrated Security=True";
        
        public IActionResult DocDuLieu()
        {
            var connection = new SqlConnection(ConnectionString);

            var sql = "SELECT MaHH, TenHH, DonGia FROM HangHoa";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

            var dataHangHoa = new DataTable();
            
            dataAdapter.Fill(dataHangHoa);

            var dataString = new StringBuilder();
            foreach(DataRow dataRow in dataHangHoa.Rows)
            {
                var temp = $"{dataRow["MaHH"]} = {dataRow["TenHH"]} : {dataRow["DonGia"]}";
                dataString.AppendLine(temp);
            }    

            return Content(dataString.ToString());
        }

        public IActionResult DocDuLieuHoaDon()
        {
            var connection = new SqlConnection(ConnectionString);

            var sql = "SELECT hd.MaHD, SUM(SoLuong * DonGia) TongTien FROM HoaDon hd JOIN ChiTietHD cthd ON hd.MaHD = cthd.MaHD GROUP BY hd.MaHD";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

            var dataHoaDon = DataProvider.TruyVan_LayDuLieu(sql);

            var dataString = new StringBuilder();
            foreach (DataRow dataRow in dataHoaDon.Rows)
            {
                var temp = $"{dataRow["MaHD"]} : {dataRow["TongTien"]}";
                dataString.AppendLine(temp);
            }

            return Content(dataString.ToString());
        }

        public IActionResult ThemLoai()
        {
            try
            {
                var sqlThemLoai = "INSERT INTO Loai(TenLoai, MoTa) VALUES(N'Nước giải khát', N'Uống nhiều cho mát')";

                var connection = new SqlConnection(ConnectionString);

                connection.Open();

                var command = new SqlCommand(sqlThemLoai, connection);

                var N = command.ExecuteNonQuery();

                connection.Close();

                return Content("Thành công");
            }
            catch (Exception ex)
            {
                return Content($"Lỗi: {ex.Message}");
            }
        }
    }
}