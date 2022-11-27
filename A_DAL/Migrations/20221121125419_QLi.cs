using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ADAL.Migrations
{
    /// <inheritdoc />
    public partial class QLi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChieuCaoDeGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKichCo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KichCo = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChieuCaoDeGiay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCuaHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCuaHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Giay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHangGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHangGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangGiay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoCCCD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaMauSac = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNsx = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaPhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenPhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuyDoi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaQuyDoi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TiLeQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiamGia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuaChonGiamGia = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSize = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoSize = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPhanCap = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheLoai_TheLoai_IdPhanCap",
                        column: x => x.IdPhanCap,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCuaHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IdCuaHang",
                        column: x => x.IdCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDiemTieuDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoDiem = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemTieuDung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiemTieuDung_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChieuCaoDeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaBan = table.Column<float>(type: "real", nullable: false),
                    GiaNhap = table.Column<float>(type: "real", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGiay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_ChieuCaoDeGiay_IdChieuCaoDeGiay",
                        column: x => x.IdChieuCaoDeGiay,
                        principalTable: "ChieuCaoDeGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Giay_IdGiay",
                        column: x => x.IdGiay,
                        principalTable: "Giay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_HangGiay_IdHangGiay",
                        column: x => x.IdHangGiay,
                        principalTable: "HangGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Nsx_IdNsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiaoCa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVienTiepQuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiaoCa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienLai = table.Column<float>(type: "real", nullable: false),
                    TienDuTru = table.Column<float>(type: "real", nullable: false),
                    TienPhatSinh = table.Column<float>(type: "real", nullable: false),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoCa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVienTiepQuan",
                        column: x => x.IdNhanVienTiepQuan,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianShip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiamGia = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSale = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSale_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSale_Sale_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTheLoai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietTheLoai_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietTheLoai_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhuongThucThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTienThanhToan = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietThanhToan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietThanhToan_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietThanhToan_PhuongThucThanhToan_IdPhuongThucThanhToan",
                        column: x => x.IdPhuongThucThanhToan,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichSuDiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiemTieuDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuyDoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaTriQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuDiemTieuDung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_DiemTieuDung_IdDiemTieuDung",
                        column: x => x.IdDiemTieuDung,
                        principalTable: "DiemTieuDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_QuyDoi_IdQuyDoi",
                        column: x => x.IdQuyDoi,
                        principalTable: "QuyDoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ChieuCaoDeGiay",
                columns: new[] { "Id", "KichCo", "MaKichCo", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1ca5b004-58a3-4eeb-bbf1-0ee43c17fd66"), 1, "KC1", 0 },
                    { new Guid("59d65326-77dc-4f4b-ae6c-a16cb8f820d6"), 4, "KC4", 0 },
                    { new Guid("a85cd38f-fefa-4ece-8723-065babab259c"), 3, "KC3", 0 },
                    { new Guid("bed3639d-d336-40d3-a865-36e764747e6f"), 2, "KC2", 0 },
                    { new Guid("ccd6114d-65db-4716-a616-7ee6782fcca5"), 5, "KC5", 0 }
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaChucVu", "TenChucVu", "TrangThai" },
                values: new object[] { new Guid("18805f52-ed09-4ee0-a4d5-68b19b85dc44"), "CV1", "Nhân viên", 0 });

            migrationBuilder.InsertData(
                table: "CuaHang",
                columns: new[] { "Id", "DiaChi", "MaCuaHang", "TenCuaHang", "TrangThai" },
                values: new object[] { new Guid("704dbdf1-65a9-4360-9ea9-ac63513bc351"), "Hà Nội", "CH1", "Cửa hàng 1", 0 });

            migrationBuilder.InsertData(
                table: "Giay",
                columns: new[] { "Id", "MaGiay", "TenGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1e248a45-bf0a-4428-8a7d-f62eea4b4bc7"), "G5", "Giày 5", 0 },
                    { new Guid("30ded702-9bf9-4719-b1e2-8b7c4c0a2b19"), "G3", "Giày 3", 0 },
                    { new Guid("6452c3dc-24a4-4ac5-b336-a850941faf78"), "G1", "Giày 1", 0 },
                    { new Guid("b6d9ff53-19a5-47f0-b3d2-fcc09bcdd1f8"), "G4", "Giày 4", 0 },
                    { new Guid("ce22ecde-84f4-4878-b0a4-5b0a45d49171"), "G2", "Giày 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "MaHangGiay", "TenHangGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0e571279-3ea8-49e6-bff4-bd465f18746e"), "HG2", "Hãng giày 2", 0 },
                    { new Guid("c5aff94a-a329-45c9-86b2-9ec148b4d21b"), "HG3", "Hãng giày 3", 0 },
                    { new Guid("c67e9afb-1bd5-4070-9fe3-4da75e9d943c"), "HG5", "Hãng giày 5", 0 },
                    { new Guid("d89dac1b-0b4f-4481-a284-75e3069783e4"), "HG1", "Hãng giày 1", 0 },
                    { new Guid("f532ab82-0997-487a-9b65-d7252a6bd6b1"), "HG4", "Hãng giày 4", 0 }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "MaKhachHang", "NgaySinh", "Sdt", "SoCCCD", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("6d269c89-d8a5-41a3-a219-fafc0da1ae5e"), "Hà Nội", null, "KH1", new DateTime(2022, 11, 21, 19, 54, 18, 727, DateTimeKind.Local).AddTicks(8861), "0385922775", "12345", "Khách hàng 1", 0 },
                    { new Guid("a9e3e082-53ec-4a23-9e0a-d137ac7fd735"), "Hà Nội", null, "KH2", new DateTime(2022, 11, 21, 19, 54, 18, 727, DateTimeKind.Local).AddTicks(8881), "0385922775", "01234", "Khách hàng 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "MaMauSac", "TenMauSac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("379e207f-2971-4284-ae53-405a7c2ce7b2"), "MS5", "Màu sắc 5", 0 },
                    { new Guid("5d2ec729-abc4-4afc-82e2-67ee3b4037c8"), "MS2", "Màu sắc 2", 0 },
                    { new Guid("64f37a56-0999-4566-9ac1-962f422e7b3a"), "MS4", "Màu sắc 4", 0 },
                    { new Guid("743f085a-e81f-4bf2-85f4-f7ca533f6bf7"), "MS3", "Màu sắc 3", 0 },
                    { new Guid("913acd9a-4598-4a39-9713-edab7b94a31a"), "MS1", "Màu sắc 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "Id", "DiaChi", "MaNsx", "TenNsx", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("34a3fd77-6691-44e5-9dcf-f87e456c200e"), "Hà Nội", "NSX5", "Nhà sản xuất 5", 0 },
                    { new Guid("3c6656ed-37f4-4b04-8977-4949cbf7f7d8"), "Hà Nội", "NSX3", "Nhà sản xuất 3", 0 },
                    { new Guid("93809d7f-bcc3-4f7e-a27c-016d838f1cef"), "Hà Nội", "NSX1", "Nhà sản xuất 1", 0 },
                    { new Guid("a1822629-d551-4739-9098-34ff018c72d4"), "Hà Nội", "NSX4", "Nhà sản xuất 4", 0 },
                    { new Guid("e92a2212-9dc5-4645-9d3d-9b0c23df755c"), "Hà Nội", "NSX2", "Nhà sản xuất 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "SoSize", "TenSize", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1d29a26d-1270-4fb7-8f73-61beab8c8704"), "SZ3", 32, "Size 3", 0 },
                    { new Guid("2cc73740-6617-47d5-b30f-362f873ce757"), "SZ4", 33, "Size 4", 0 },
                    { new Guid("33518e19-bd23-47dd-9f9c-8010c106638e"), "SZ2", 31, "Size 2", 0 },
                    { new Guid("4e6b191c-c1bc-4813-b947-adb3da90bb85"), "SZ1", 30, "Size 1", 0 },
                    { new Guid("dd4514d6-9dc8-478b-8a67-da2a610fa75e"), "SZ5", 34, "Size 5", 0 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietGiay",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdChieuCaoDeGiay", "IdGiay", "IdHangGiay", "IdMauSac", "IdNsx", "IdSize", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("27ec8e79-2389-4533-a473-96ee668cb9fb"), 10000f, 7000f, new Guid("bed3639d-d336-40d3-a865-36e764747e6f"), new Guid("ce22ecde-84f4-4878-b0a4-5b0a45d49171"), new Guid("f532ab82-0997-487a-9b65-d7252a6bd6b1"), new Guid("64f37a56-0999-4566-9ac1-962f422e7b3a"), new Guid("3c6656ed-37f4-4b04-8977-4949cbf7f7d8"), new Guid("4e6b191c-c1bc-4813-b947-adb3da90bb85"), null, 100, 0 },
                    { new Guid("378fc3d4-9e29-49a6-bb1b-750bacda07d9"), 10000f, 7000f, new Guid("1ca5b004-58a3-4eeb-bbf1-0ee43c17fd66"), new Guid("b6d9ff53-19a5-47f0-b3d2-fcc09bcdd1f8"), new Guid("c67e9afb-1bd5-4070-9fe3-4da75e9d943c"), new Guid("64f37a56-0999-4566-9ac1-962f422e7b3a"), new Guid("e92a2212-9dc5-4645-9d3d-9b0c23df755c"), new Guid("33518e19-bd23-47dd-9f9c-8010c106638e"), null, 100, 0 },
                    { new Guid("3b6397f3-6ba3-49bc-bd9f-5e3af0ea1a3a"), 10000f, 7000f, new Guid("a85cd38f-fefa-4ece-8723-065babab259c"), new Guid("1e248a45-bf0a-4428-8a7d-f62eea4b4bc7"), new Guid("c67e9afb-1bd5-4070-9fe3-4da75e9d943c"), new Guid("913acd9a-4598-4a39-9713-edab7b94a31a"), new Guid("a1822629-d551-4739-9098-34ff018c72d4"), new Guid("33518e19-bd23-47dd-9f9c-8010c106638e"), null, 100, 0 },
                    { new Guid("3d6b2ec6-3c17-4803-ab3d-5705eb15ae35"), 10000f, 7000f, new Guid("bed3639d-d336-40d3-a865-36e764747e6f"), new Guid("b6d9ff53-19a5-47f0-b3d2-fcc09bcdd1f8"), new Guid("c5aff94a-a329-45c9-86b2-9ec148b4d21b"), new Guid("5d2ec729-abc4-4afc-82e2-67ee3b4037c8"), new Guid("a1822629-d551-4739-9098-34ff018c72d4"), new Guid("33518e19-bd23-47dd-9f9c-8010c106638e"), null, 100, 0 },
                    { new Guid("621ee617-2fbd-4d37-9e1b-748f240be7a0"), 10000f, 7000f, new Guid("1ca5b004-58a3-4eeb-bbf1-0ee43c17fd66"), new Guid("ce22ecde-84f4-4878-b0a4-5b0a45d49171"), new Guid("f532ab82-0997-487a-9b65-d7252a6bd6b1"), new Guid("64f37a56-0999-4566-9ac1-962f422e7b3a"), new Guid("34a3fd77-6691-44e5-9dcf-f87e456c200e"), new Guid("dd4514d6-9dc8-478b-8a67-da2a610fa75e"), null, 100, 0 },
                    { new Guid("6d3af54c-69c9-404e-9b7f-1f0844da7f4c"), 10000f, 7000f, new Guid("a85cd38f-fefa-4ece-8723-065babab259c"), new Guid("b6d9ff53-19a5-47f0-b3d2-fcc09bcdd1f8"), new Guid("0e571279-3ea8-49e6-bff4-bd465f18746e"), new Guid("913acd9a-4598-4a39-9713-edab7b94a31a"), new Guid("34a3fd77-6691-44e5-9dcf-f87e456c200e"), new Guid("1d29a26d-1270-4fb7-8f73-61beab8c8704"), null, 100, 0 },
                    { new Guid("8e198b25-d379-4c3f-86f8-26496ed0e33f"), 10000f, 7000f, new Guid("1ca5b004-58a3-4eeb-bbf1-0ee43c17fd66"), new Guid("b6d9ff53-19a5-47f0-b3d2-fcc09bcdd1f8"), new Guid("f532ab82-0997-487a-9b65-d7252a6bd6b1"), new Guid("5d2ec729-abc4-4afc-82e2-67ee3b4037c8"), new Guid("a1822629-d551-4739-9098-34ff018c72d4"), new Guid("2cc73740-6617-47d5-b30f-362f873ce757"), null, 100, 0 },
                    { new Guid("b26d7ba4-d939-4105-9aad-22ac4562c76b"), 10000f, 7000f, new Guid("59d65326-77dc-4f4b-ae6c-a16cb8f820d6"), new Guid("6452c3dc-24a4-4ac5-b336-a850941faf78"), new Guid("c5aff94a-a329-45c9-86b2-9ec148b4d21b"), new Guid("913acd9a-4598-4a39-9713-edab7b94a31a"), new Guid("93809d7f-bcc3-4f7e-a27c-016d838f1cef"), new Guid("dd4514d6-9dc8-478b-8a67-da2a610fa75e"), null, 100, 0 },
                    { new Guid("cc527b29-62c6-4341-94ac-ee82e0fca179"), 10000f, 7000f, new Guid("ccd6114d-65db-4716-a616-7ee6782fcca5"), new Guid("b6d9ff53-19a5-47f0-b3d2-fcc09bcdd1f8"), new Guid("c5aff94a-a329-45c9-86b2-9ec148b4d21b"), new Guid("743f085a-e81f-4bf2-85f4-f7ca533f6bf7"), new Guid("93809d7f-bcc3-4f7e-a27c-016d838f1cef"), new Guid("2cc73740-6617-47d5-b30f-362f873ce757"), null, 100, 0 },
                    { new Guid("d73aad51-c5c8-4b62-a0f9-a0dcc2de4d15"), 10000f, 7000f, new Guid("1ca5b004-58a3-4eeb-bbf1-0ee43c17fd66"), new Guid("b6d9ff53-19a5-47f0-b3d2-fcc09bcdd1f8"), new Guid("0e571279-3ea8-49e6-bff4-bd465f18746e"), new Guid("379e207f-2971-4284-ae53-405a7c2ce7b2"), new Guid("3c6656ed-37f4-4b04-8977-4949cbf7f7d8"), new Guid("4e6b191c-c1bc-4813-b947-adb3da90bb85"), null, 100, 0 }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdCuaHang", "MaNhanVien", "MatKhau", "NgaySinh", "Sdt", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("8facdc32-9a40-4455-9cb8-7ea43751b9e9"), "Hà Nội", null, 1, new Guid("18805f52-ed09-4ee0-a4d5-68b19b85dc44"), new Guid("704dbdf1-65a9-4360-9ea9-ac63513bc351"), "NV2", "00000", new DateTime(2022, 11, 21, 19, 54, 18, 727, DateTimeKind.Local).AddTicks(8839), "0385922775", "Nhân viên 2", 0 },
                    { new Guid("fe7be7ac-9983-438d-8233-0720092b579c"), "Hà Nội", null, 0, new Guid("18805f52-ed09-4ee0-a4d5-68b19b85dc44"), new Guid("704dbdf1-65a9-4360-9ea9-ac63513bc351"), "NV1", "00000", new DateTime(2022, 11, 21, 19, 54, 18, 727, DateTimeKind.Local).AddTicks(8797), "0385922775", "Nhân viên 1", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChieuCaoDeGiay_MaKichCo",
                table: "ChieuCaoDeGiay",
                column: "MaKichCo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdChieuCaoDeGiay",
                table: "ChiTietGiay",
                column: "IdChieuCaoDeGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdGiay",
                table: "ChiTietGiay",
                column: "IdGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdHangGiay",
                table: "ChiTietGiay",
                column: "IdHangGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdMauSac_IdSize_IdNsx_IdHangGiay_IdChieuCaoDeGiay_IdGiay",
                table: "ChiTietGiay",
                columns: new[] { "IdMauSac", "IdSize", "IdNsx", "IdHangGiay", "IdChieuCaoDeGiay", "IdGiay" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdNsx",
                table: "ChiTietGiay",
                column: "IdNsx");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdSize",
                table: "ChiTietGiay",
                column: "IdSize");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdChiTietGiay_IdSale",
                table: "ChiTietSale",
                columns: new[] { "IdChiTietGiay", "IdSale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdSale",
                table: "ChiTietSale",
                column: "IdSale");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdHoaDon",
                table: "ChiTietThanhToan",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdPhuongThucThanhToan",
                table: "ChiTietThanhToan",
                column: "IdPhuongThucThanhToan");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdChiTietGiay_IdTheLoai",
                table: "ChiTietTheLoai",
                columns: new[] { "IdChiTietGiay", "IdTheLoai" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdTheLoai",
                table: "ChiTietTheLoai",
                column: "IdTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVu_MaChucVu",
                table: "ChucVu",
                column: "MaChucVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CuaHang_MaCuaHang",
                table: "CuaHang",
                column: "MaCuaHang",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_IdKhachHang",
                table: "DiemTieuDung",
                column: "IdKhachHang",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_MaDiemTieuDung",
                table: "DiemTieuDung",
                column: "MaDiemTieuDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVien",
                table: "GiaoCa",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVienTiepQuan",
                table: "GiaoCa",
                column: "IdNhanVienTiepQuan");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_MaGiaoCa",
                table: "GiaoCa",
                column: "MaGiaoCa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Giay_MaGiay",
                table: "Giay",
                column: "MaGiay",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HangGiay_MaHangGiay",
                table: "HangGiay",
                column: "MaHangGiay",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHoaDon",
                table: "HoaDon",
                column: "MaHoaDon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietGiay_IdHoaDon",
                table: "HoaDonChiTiet",
                columns: new[] { "IdChiTietGiay", "IdHoaDon" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaKhachHang",
                table: "KhachHang",
                column: "MaKhachHang",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_SoCCCD",
                table: "KhachHang",
                column: "SoCCCD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdDiemTieuDung",
                table: "LichSuDiemTieuDung",
                column: "IdDiemTieuDung");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdHoaDon_IdDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                columns: new[] { "IdHoaDon", "IdDiemTieuDung", "IdQuyDoi" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                column: "IdQuyDoi");

            migrationBuilder.CreateIndex(
                name: "IX_MauSac_MaMauSac",
                table: "MauSac",
                column: "MaMauSac",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCuaHang",
                table: "NhanVien",
                column: "IdCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaNhanVien",
                table: "NhanVien",
                column: "MaNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nsx_MaNsx",
                table: "Nsx",
                column: "MaNsx",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuyDoi_MaQuyDoi",
                table: "QuyDoi",
                column: "MaQuyDoi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_MaGiamGia",
                table: "Sale",
                column: "MaGiamGia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Size_MaSize",
                table: "Size",
                column: "MaSize",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TheLoai_IdPhanCap",
                table: "TheLoai",
                column: "IdPhanCap");

            migrationBuilder.CreateIndex(
                name: "IX_TheLoai_MaTheLoai",
                table: "TheLoai",
                column: "MaTheLoai",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietSale");

            migrationBuilder.DropTable(
                name: "ChiTietThanhToan");

            migrationBuilder.DropTable(
                name: "ChiTietTheLoai");

            migrationBuilder.DropTable(
                name: "GiaoCa");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "LichSuDiemTieuDung");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "TheLoai");

            migrationBuilder.DropTable(
                name: "ChiTietGiay");

            migrationBuilder.DropTable(
                name: "DiemTieuDung");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "QuyDoi");

            migrationBuilder.DropTable(
                name: "ChieuCaoDeGiay");

            migrationBuilder.DropTable(
                name: "Giay");

            migrationBuilder.DropTable(
                name: "HangGiay");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "Nsx");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
