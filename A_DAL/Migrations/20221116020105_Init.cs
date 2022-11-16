using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace ADAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_ChieuCaoDeGiay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_CuaHang", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_Giay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_HangGiay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNsx = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNsx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_PhuongThucThanhToan", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_QuyDoi", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_Sale", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_Size", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_TheLoai", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_TheLoai_TheLoai_IdPhanCap",
                        column: x => x.IdPhanCap,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_NhanVien", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IdCuaHang",
                        column: x => x.IdCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_DiemTieuDung", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_DiemTieuDung_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_ChiTietGiay", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_ChieuCaoDeGiay_IdChieuCaoDeGiay",
                        column: x => x.IdChieuCaoDeGiay,
                        principalTable: "ChieuCaoDeGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Giay_IdGiay",
                        column: x => x.IdGiay,
                        principalTable: "Giay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_HangGiay_IdHangGiay",
                        column: x => x.IdHangGiay,
                        principalTable: "HangGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Nsx_IdNsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_GiaoCa", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVienTiepQuan",
                        column: x => x.IdNhanVienTiepQuan,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiamGia = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_HoaDon", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_ChiTietSale", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietSale_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietSale_Sale_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_ChiTietTheLoai", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietTheLoai_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietTheLoai_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_ChiTietThanhToan", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietThanhToan_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietThanhToan_PhuongThucThanhToan_IdPhuongThucThanhToan",
                        column: x => x.IdPhuongThucThanhToan,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
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
                    _ = table.PrimaryKey("PK_LichSuDiemTieuDung", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_DiemTieuDung_IdDiemTieuDung",
                        column: x => x.IdDiemTieuDung,
                        principalTable: "DiemTieuDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_QuyDoi_IdQuyDoi",
                        column: x => x.IdQuyDoi,
                        principalTable: "QuyDoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.InsertData(
                table: "ChieuCaoDeGiay",
                columns: new[] { "Id", "KichCo", "MaKichCo", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("2104b4bd-e808-4429-9f7c-48e4edf209f3"), 4, "KC4", 0 },
                    { new Guid("5d5313dc-838a-4b47-96f9-312533abedee"), 2, "KC2", 0 },
                    { new Guid("a4b015c4-369e-404c-9fb1-f04b2a258778"), 3, "KC3", 0 },
                    { new Guid("ccea912d-c604-4cd9-a8a4-66e1805eb55b"), 5, "KC5", 0 },
                    { new Guid("f3badddc-ae12-4b5f-b75a-6c3e79889482"), 1, "KC1", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaChucVu", "TenChucVu", "TrangThai" },
                values: new object[] { new Guid("90fe3fac-39e6-4ac7-847d-6044d8a2d820"), "CV1", "Nhân viên", 0 });

            _ = migrationBuilder.InsertData(
                table: "CuaHang",
                columns: new[] { "Id", "DiaChi", "MaCuaHang", "TenCuaHang", "TrangThai" },
                values: new object[] { new Guid("c49a3670-1e2e-4940-bb3a-4ae847110134"), "Hà Nội", "CH1", "Cửa hàng 1", 0 });

            _ = migrationBuilder.InsertData(
                table: "Giay",
                columns: new[] { "Id", "MaGiay", "TenGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("39662923-362f-4aae-82f0-d9aea5bc447a"), "G4", "Giày 4", 0 },
                    { new Guid("98b09b19-7a73-4d7a-989a-88a67e8e42ee"), "G2", "Giày 2", 0 },
                    { new Guid("bd438dfb-d5b5-46d3-adb3-2d1d7b0fc507"), "G3", "Giày 3", 0 },
                    { new Guid("ce3a72a2-49c5-408e-801c-ee3d6cbb888a"), "G1", "Giày 1", 0 },
                    { new Guid("ece60c2b-8961-405f-affa-3795176cba83"), "G5", "Giày 5", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "MaHangGiay", "TenHangGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("45f695d5-c84e-4e2c-95fb-ece01d63a3a9"), "HG4", "Hãng giày 4", 0 },
                    { new Guid("4bc4ff73-e4e4-4bf8-86b1-69c3ef2c4561"), "HG1", "Hãng giày 1", 0 },
                    { new Guid("8cc642df-b4c6-489f-808a-11903edefd6c"), "HG3", "Hãng giày 3", 0 },
                    { new Guid("f01e7df2-6669-49f8-bdc4-312f30162da8"), "HG2", "Hãng giày 2", 0 },
                    { new Guid("fafbca98-8986-4846-9ce1-2fdfd1568848"), "HG5", "Hãng giày 5", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "MaKhachHang", "NgaySinh", "Sdt", "SoCCCD", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("32771d5f-cb10-43ff-887c-8732a061d444"), "Hà Nội", null, "KH2", new DateTime(2022, 11, 16, 9, 1, 4, 989, DateTimeKind.Local).AddTicks(9694), "0385922775", "01234", "Khách hàng 2", 0 },
                    { new Guid("3912f0f5-0e90-4691-802b-de17c0568aae"), "Hà Nội", null, "KH1", new DateTime(2022, 11, 16, 9, 1, 4, 989, DateTimeKind.Local).AddTicks(9683), "0385922775", "12345", "Khách hàng 1", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "MaMauSac", "TenMauSac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("26e0d21a-bce3-458c-9318-51a86234cdab"), "MS4", "Màu sắc 4", 0 },
                    { new Guid("6d33812b-1a62-41aa-8163-b7d46ad9ae5b"), "MS3", "Màu sắc 3", 0 },
                    { new Guid("86840ecf-3df5-4dc0-8f01-30bc9a1eb873"), "MS2", "Màu sắc 2", 0 },
                    { new Guid("a0ec8c11-c17b-41e6-8c66-fcd2b6f079b6"), "MS5", "Màu sắc 5", 0 },
                    { new Guid("eac2b9dd-384f-4723-991e-1b5940afb441"), "MS1", "Màu sắc 1", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "Id", "DiaChi", "MaNsx", "TenNsx" },
                values: new object[,]
                {
                    { new Guid("0a4c0941-a6a1-4dbe-9737-7d23bb2afea7"), "Hà Nội", "NSX2", "Nhà sản xuất 2" },
                    { new Guid("9d6d08b2-a7c9-494c-bcfb-077f95e2ca2e"), "Hà Nội", "NSX4", "Nhà sản xuất 4" },
                    { new Guid("db920241-1519-4419-8467-98a39a5e4f27"), "Hà Nội", "NSX1", "Nhà sản xuất 1" },
                    { new Guid("e04fef0d-71c2-4731-900b-62ea92b40389"), "Hà Nội", "NSX3", "Nhà sản xuất 3" },
                    { new Guid("e2f2de98-5d4c-4832-8a9f-c11b31fa7d03"), "Hà Nội", "NSX5", "Nhà sản xuất 5" }
                });

            _ = migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "SoSize", "TenSize", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("031fd95a-8dac-4d21-8f45-50d2b93ed82f"), "SZ5", 34, "Size 5", 0 },
                    { new Guid("3bbbafbc-004d-48f4-bc90-7f3ee9023b30"), "SZ4", 33, "Size 4", 0 },
                    { new Guid("51f54ff4-79f4-4288-923b-c1658749e5d1"), "SZ2", 31, "Size 2", 0 },
                    { new Guid("54a16a01-84e3-4316-a0da-c35618637033"), "SZ3", 32, "Size 3", 0 },
                    { new Guid("6332debb-4a80-4322-9105-f16f9f9b1c59"), "SZ1", 30, "Size 1", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChiTietGiay",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdChieuCaoDeGiay", "IdGiay", "IdHangGiay", "IdMauSac", "IdNsx", "IdSize", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("30c96370-10c1-46a1-8773-409eaebb65ee"), 10000f, 7000f, new Guid("f3badddc-ae12-4b5f-b75a-6c3e79889482"), new Guid("39662923-362f-4aae-82f0-d9aea5bc447a"), new Guid("f01e7df2-6669-49f8-bdc4-312f30162da8"), new Guid("86840ecf-3df5-4dc0-8f01-30bc9a1eb873"), new Guid("e2f2de98-5d4c-4832-8a9f-c11b31fa7d03"), new Guid("031fd95a-8dac-4d21-8f45-50d2b93ed82f"), null, 100, 0 },
                    { new Guid("3c01e1e3-1e7d-4102-aa38-14363df2e7c2"), 10000f, 7000f, new Guid("2104b4bd-e808-4429-9f7c-48e4edf209f3"), new Guid("ce3a72a2-49c5-408e-801c-ee3d6cbb888a"), new Guid("4bc4ff73-e4e4-4bf8-86b1-69c3ef2c4561"), new Guid("26e0d21a-bce3-458c-9318-51a86234cdab"), new Guid("db920241-1519-4419-8467-98a39a5e4f27"), new Guid("031fd95a-8dac-4d21-8f45-50d2b93ed82f"), null, 100, 0 },
                    { new Guid("4890a890-623a-4b46-8593-14694de9ff8f"), 10000f, 7000f, new Guid("f3badddc-ae12-4b5f-b75a-6c3e79889482"), new Guid("ce3a72a2-49c5-408e-801c-ee3d6cbb888a"), new Guid("4bc4ff73-e4e4-4bf8-86b1-69c3ef2c4561"), new Guid("6d33812b-1a62-41aa-8163-b7d46ad9ae5b"), new Guid("9d6d08b2-a7c9-494c-bcfb-077f95e2ca2e"), new Guid("031fd95a-8dac-4d21-8f45-50d2b93ed82f"), null, 100, 0 },
                    { new Guid("6115aac3-2f50-4035-932b-462c35364696"), 10000f, 7000f, new Guid("5d5313dc-838a-4b47-96f9-312533abedee"), new Guid("ece60c2b-8961-405f-affa-3795176cba83"), new Guid("f01e7df2-6669-49f8-bdc4-312f30162da8"), new Guid("86840ecf-3df5-4dc0-8f01-30bc9a1eb873"), new Guid("9d6d08b2-a7c9-494c-bcfb-077f95e2ca2e"), new Guid("6332debb-4a80-4322-9105-f16f9f9b1c59"), null, 100, 0 },
                    { new Guid("81bdee9d-13ae-42ca-aa23-7ac0def8bdf3"), 10000f, 7000f, new Guid("a4b015c4-369e-404c-9fb1-f04b2a258778"), new Guid("98b09b19-7a73-4d7a-989a-88a67e8e42ee"), new Guid("4bc4ff73-e4e4-4bf8-86b1-69c3ef2c4561"), new Guid("6d33812b-1a62-41aa-8163-b7d46ad9ae5b"), new Guid("9d6d08b2-a7c9-494c-bcfb-077f95e2ca2e"), new Guid("51f54ff4-79f4-4288-923b-c1658749e5d1"), null, 100, 0 },
                    { new Guid("88c5ac2d-c11e-461e-8164-f166c6fd0f74"), 10000f, 7000f, new Guid("f3badddc-ae12-4b5f-b75a-6c3e79889482"), new Guid("bd438dfb-d5b5-46d3-adb3-2d1d7b0fc507"), new Guid("8cc642df-b4c6-489f-808a-11903edefd6c"), new Guid("26e0d21a-bce3-458c-9318-51a86234cdab"), new Guid("e04fef0d-71c2-4731-900b-62ea92b40389"), new Guid("3bbbafbc-004d-48f4-bc90-7f3ee9023b30"), null, 100, 0 },
                    { new Guid("9e10649c-ec4d-4007-acb0-b3a3d77432aa"), 10000f, 7000f, new Guid("5d5313dc-838a-4b47-96f9-312533abedee"), new Guid("bd438dfb-d5b5-46d3-adb3-2d1d7b0fc507"), new Guid("45f695d5-c84e-4e2c-95fb-ece01d63a3a9"), new Guid("a0ec8c11-c17b-41e6-8c66-fcd2b6f079b6"), new Guid("9d6d08b2-a7c9-494c-bcfb-077f95e2ca2e"), new Guid("3bbbafbc-004d-48f4-bc90-7f3ee9023b30"), null, 100, 0 },
                    { new Guid("ba2966f7-a7dd-4f5e-8f4b-c02844b16807"), 10000f, 7000f, new Guid("2104b4bd-e808-4429-9f7c-48e4edf209f3"), new Guid("ece60c2b-8961-405f-affa-3795176cba83"), new Guid("fafbca98-8986-4846-9ce1-2fdfd1568848"), new Guid("6d33812b-1a62-41aa-8163-b7d46ad9ae5b"), new Guid("e2f2de98-5d4c-4832-8a9f-c11b31fa7d03"), new Guid("3bbbafbc-004d-48f4-bc90-7f3ee9023b30"), null, 100, 0 },
                    { new Guid("c5114fff-4d6a-43d1-8032-d973745a0054"), 10000f, 7000f, new Guid("a4b015c4-369e-404c-9fb1-f04b2a258778"), new Guid("39662923-362f-4aae-82f0-d9aea5bc447a"), new Guid("4bc4ff73-e4e4-4bf8-86b1-69c3ef2c4561"), new Guid("86840ecf-3df5-4dc0-8f01-30bc9a1eb873"), new Guid("db920241-1519-4419-8467-98a39a5e4f27"), new Guid("031fd95a-8dac-4d21-8f45-50d2b93ed82f"), null, 100, 0 },
                    { new Guid("ffa7e2cf-14aa-43ba-9523-6f6c67876085"), 10000f, 7000f, new Guid("2104b4bd-e808-4429-9f7c-48e4edf209f3"), new Guid("ece60c2b-8961-405f-affa-3795176cba83"), new Guid("fafbca98-8986-4846-9ce1-2fdfd1568848"), new Guid("eac2b9dd-384f-4723-991e-1b5940afb441"), new Guid("0a4c0941-a6a1-4dbe-9737-7d23bb2afea7"), new Guid("54a16a01-84e3-4316-a0da-c35618637033"), null, 100, 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdCuaHang", "MaNhanVien", "MatKhau", "NgaySinh", "Sdt", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("62f1df5f-6102-4fcc-bab2-a942432f9677"), "Hà Nội", null, 1, new Guid("90fe3fac-39e6-4ac7-847d-6044d8a2d820"), new Guid("c49a3670-1e2e-4940-bb3a-4ae847110134"), "NV2", "00000", new DateTime(2022, 11, 16, 9, 1, 4, 989, DateTimeKind.Local).AddTicks(9669), "0385922775", "Nhân viên 2", 0 },
                    { new Guid("c12eccd2-5933-4cf0-9632-3ee923d11a97"), "Hà Nội", null, 0, new Guid("90fe3fac-39e6-4ac7-847d-6044d8a2d820"), new Guid("c49a3670-1e2e-4940-bb3a-4ae847110134"), "NV1", "00000", new DateTime(2022, 11, 16, 9, 1, 4, 989, DateTimeKind.Local).AddTicks(9639), "0385922775", "Nhân viên 1", 0 }
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChieuCaoDeGiay_MaKichCo",
                table: "ChieuCaoDeGiay",
                column: "MaKichCo",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdChieuCaoDeGiay",
                table: "ChiTietGiay",
                column: "IdChieuCaoDeGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdGiay",
                table: "ChiTietGiay",
                column: "IdGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdHangGiay",
                table: "ChiTietGiay",
                column: "IdHangGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdMauSac_IdSize_IdNsx_IdHangGiay_IdChieuCaoDeGiay_IdGiay",
                table: "ChiTietGiay",
                columns: new[] { "IdMauSac", "IdSize", "IdNsx", "IdHangGiay", "IdChieuCaoDeGiay", "IdGiay" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdNsx",
                table: "ChiTietGiay",
                column: "IdNsx");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdSize",
                table: "ChiTietGiay",
                column: "IdSize");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdChiTietGiay_IdSale",
                table: "ChiTietSale",
                columns: new[] { "IdChiTietGiay", "IdSale" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdSale",
                table: "ChiTietSale",
                column: "IdSale");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdHoaDon",
                table: "ChiTietThanhToan",
                column: "IdHoaDon");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdPhuongThucThanhToan",
                table: "ChiTietThanhToan",
                column: "IdPhuongThucThanhToan");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdChiTietGiay_IdTheLoai",
                table: "ChiTietTheLoai",
                columns: new[] { "IdChiTietGiay", "IdTheLoai" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdTheLoai",
                table: "ChiTietTheLoai",
                column: "IdTheLoai");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChucVu_MaChucVu",
                table: "ChucVu",
                column: "MaChucVu",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_CuaHang_MaCuaHang",
                table: "CuaHang",
                column: "MaCuaHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_IdKhachHang",
                table: "DiemTieuDung",
                column: "IdKhachHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_MaDiemTieuDung",
                table: "DiemTieuDung",
                column: "MaDiemTieuDung",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVien",
                table: "GiaoCa",
                column: "IdNhanVien");

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVienTiepQuan",
                table: "GiaoCa",
                column: "IdNhanVienTiepQuan");

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_MaGiaoCa",
                table: "GiaoCa",
                column: "MaGiaoCa",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Giay_MaGiay",
                table: "Giay",
                column: "MaGiay",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HangGiay_MaHangGiay",
                table: "HangGiay",
                column: "MaHangGiay",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHoaDon",
                table: "HoaDon",
                column: "MaHoaDon",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietGiay_IdHoaDon",
                table: "HoaDonChiTiet",
                columns: new[] { "IdChiTietGiay", "IdHoaDon" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            _ = migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaKhachHang",
                table: "KhachHang",
                column: "MaKhachHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_KhachHang_SoCCCD",
                table: "KhachHang",
                column: "SoCCCD",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdDiemTieuDung",
                table: "LichSuDiemTieuDung",
                column: "IdDiemTieuDung");

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdHoaDon_IdDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                columns: new[] { "IdHoaDon", "IdDiemTieuDung", "IdQuyDoi" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                column: "IdQuyDoi");

            _ = migrationBuilder.CreateIndex(
                name: "IX_MauSac_MaMauSac",
                table: "MauSac",
                column: "MaMauSac",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCuaHang",
                table: "NhanVien",
                column: "IdCuaHang");

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaNhanVien",
                table: "NhanVien",
                column: "MaNhanVien",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Nsx_MaNsx",
                table: "Nsx",
                column: "MaNsx",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_QuyDoi_MaQuyDoi",
                table: "QuyDoi",
                column: "MaQuyDoi",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Sale_MaGiamGia",
                table: "Sale",
                column: "MaGiamGia",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Size_MaSize",
                table: "Size",
                column: "MaSize",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_TheLoai_IdPhanCap",
                table: "TheLoai",
                column: "IdPhanCap");

            _ = migrationBuilder.CreateIndex(
                name: "IX_TheLoai_MaTheLoai",
                table: "TheLoai",
                column: "MaTheLoai",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "ChiTietSale");

            _ = migrationBuilder.DropTable(
                name: "ChiTietThanhToan");

            _ = migrationBuilder.DropTable(
                name: "ChiTietTheLoai");

            _ = migrationBuilder.DropTable(
                name: "GiaoCa");

            _ = migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            _ = migrationBuilder.DropTable(
                name: "LichSuDiemTieuDung");

            _ = migrationBuilder.DropTable(
                name: "Sale");

            _ = migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            _ = migrationBuilder.DropTable(
                name: "TheLoai");

            _ = migrationBuilder.DropTable(
                name: "ChiTietGiay");

            _ = migrationBuilder.DropTable(
                name: "DiemTieuDung");

            _ = migrationBuilder.DropTable(
                name: "HoaDon");

            _ = migrationBuilder.DropTable(
                name: "QuyDoi");

            _ = migrationBuilder.DropTable(
                name: "ChieuCaoDeGiay");

            _ = migrationBuilder.DropTable(
                name: "Giay");

            _ = migrationBuilder.DropTable(
                name: "HangGiay");

            _ = migrationBuilder.DropTable(
                name: "MauSac");

            _ = migrationBuilder.DropTable(
                name: "Nsx");

            _ = migrationBuilder.DropTable(
                name: "Size");

            _ = migrationBuilder.DropTable(
                name: "KhachHang");

            _ = migrationBuilder.DropTable(
                name: "NhanVien");

            _ = migrationBuilder.DropTable(
                name: "ChucVu");

            _ = migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
