using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NhomKNTT_QLRapChieuPhim.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatVe",
                columns: table => new
                {
                    MaDatVe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoDienThoai = table.Column<double>(maxLength: 50, nullable: false),
                    LichChieuPhim = table.Column<string>(nullable: true),
                    SoLuongChoTrong = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatVe", x => x.MaDatVe);
                });

            migrationBuilder.CreateTable(
                name: "Rap",
                columns: table => new
                {
                    MaRap = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenRap = table.Column<string>(maxLength: 50, nullable: false),
                    SoChoTrong = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rap", x => x.MaRap);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachPhim",
                columns: table => new
                {
                    MaPhim = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(maxLength: 50, nullable: false),
                    ThoiLuong = table.Column<double>(nullable: false),
                    RapMaRap = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachPhim", x => x.MaPhim);
                    table.ForeignKey(
                        name: "FK_DanhSachPhim_Rap_RapMaRap",
                        column: x => x.RapMaRap,
                        principalTable: "Rap",
                        principalColumn: "MaRap",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichChieuPhim",
                columns: table => new
                {
                    MaLichChieu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(maxLength: 50, nullable: false),
                    TenRap = table.Column<string>(nullable: true),
                    GioCongChieu = table.Column<DateTime>(nullable: false),
                    RapMaRap = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieuPhim", x => x.MaLichChieu);
                    table.ForeignKey(
                        name: "FK_LichChieuPhim_Rap_RapMaRap",
                        column: x => x.RapMaRap,
                        principalTable: "Rap",
                        principalColumn: "MaRap",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachPhim_RapMaRap",
                table: "DanhSachPhim",
                column: "RapMaRap");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieuPhim_RapMaRap",
                table: "LichChieuPhim",
                column: "RapMaRap");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhSachPhim");

            migrationBuilder.DropTable(
                name: "DatVe");

            migrationBuilder.DropTable(
                name: "LichChieuPhim");

            migrationBuilder.DropTable(
                name: "Rap");
        }
    }
}
