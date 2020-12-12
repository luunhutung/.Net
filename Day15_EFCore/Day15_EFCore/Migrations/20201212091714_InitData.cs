using Microsoft.EntityFrameworkCore.Migrations;

namespace Day15_EFCore.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlInsertData = @"INSERT INTO Loai(TenLoai, MoTa) VALUES (N'Bia', N'Bia), (N'Nước ngọt', N'Nước ngọt')";
            migrationBuilder.Sql(sqlInsertData);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
