using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Day15_EFCore.Migrations
{
    public partial class Add_HoaDon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    MaHoaDon = table.Column<Guid>(nullable: false),
                    MaKH = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(maxLength: 150, nullable: false),
                    NgayLap = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.MaHoaDon);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    MaHoaDon = table.Column<Guid>(nullable: false),
                    MaHangHoa = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.MaHoaDon, x.MaHangHoa });
                    table.ForeignKey(
                        name: "FK_OrderDetail_HangHoa_MaHangHoa",
                        column: x => x.MaHangHoa,
                        principalTable: "HangHoa",
                        principalColumn: "MaHangHoa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTHD_HD",
                        column: x => x.MaHoaDon,
                        principalTable: "Order",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_MaHangHoa",
                table: "OrderDetail",
                column: "MaHangHoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
