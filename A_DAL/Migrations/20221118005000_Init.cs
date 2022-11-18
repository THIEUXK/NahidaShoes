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
                    { new Guid("2429c610-dfef-4d75-96b7-7404f71e508a"), 2, "KC2", 0 },
                    { new Guid("4f1e567c-c03b-4691-af7d-0f5907b71888"), 1, "KC1", 0 },
                    { new Guid("5a9d56cd-0f34-4348-bc33-4b1b3d44120f"), 3, "KC3", 0 },
                    { new Guid("6eaa159a-b9a6-4322-8fd7-f95476014b01"), 5, "KC5", 0 },
                    { new Guid("877f1a90-2de8-419a-9cc9-b793f2c3667a"), 4, "KC4", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaChucVu", "TenChucVu", "TrangThai" },
                values: new object[] { new Guid("3d54cbf7-9933-4314-88db-7edbb357cb6c"), "CV1", "Nhân viên", 0 });

            _ = migrationBuilder.InsertData(
                table: "CuaHang",
                columns: new[] { "Id", "DiaChi", "MaCuaHang", "TenCuaHang", "TrangThai" },
                values: new object[] { new Guid("f1887f8f-910c-4dbc-9b30-3027bf3c8d03"), "Hà Nội", "CH1", "Cửa hàng 1", 0 });

            _ = migrationBuilder.InsertData(
                table: "Giay",
                columns: new[] { "Id", "MaGiay", "TenGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("62602898-2f58-4215-84a6-69cc7dc88673"), "G4", "Giày 4", 0 },
                    { new Guid("a72c231d-0818-4e87-99a7-b30ff7cce5b6"), "G5", "Giày 5", 0 },
                    { new Guid("d97f2312-a8ff-4550-b57b-1f132e81d6f0"), "G1", "Giày 1", 0 },
                    { new Guid("dd6e4975-9a0b-4efb-8836-e0dbf492d33e"), "G2", "Giày 2", 0 },
                    { new Guid("ffaeb614-9fa6-49cf-91da-9f70b6ee1699"), "G3", "Giày 3", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "MaHangGiay", "TenHangGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("176f1d26-d62e-43a1-831b-782fee5a5625"), "HG3", "Hãng giày 3", 0 },
                    { new Guid("237a838f-b8c3-4e1b-9473-0bc3914fd901"), "HG2", "Hãng giày 2", 0 },
                    { new Guid("c2731e15-224e-4abe-8c03-b81e03104354"), "HG4", "Hãng giày 4", 0 },
                    { new Guid("df415f0c-0a0e-4c20-8a3f-b8cac6d95f69"), "HG1", "Hãng giày 1", 0 },
                    { new Guid("ed9a3578-bb35-429b-813f-8333a920d98b"), "HG5", "Hãng giày 5", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "MaKhachHang", "NgaySinh", "Sdt", "SoCCCD", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("a72fa274-5ceb-4f8d-bffc-a64a817e552e"), "Hà Nội", null, "KH2", new DateTime(2022, 11, 18, 7, 50, 0, 104, DateTimeKind.Local).AddTicks(6835), "0385922775", "01234", "Khách hàng 2", 0 },
                    { new Guid("dda9e8c4-688c-41ca-96bc-e6dcfd33c486"), "Hà Nội", null, "KH1", new DateTime(2022, 11, 18, 7, 50, 0, 104, DateTimeKind.Local).AddTicks(6815), "0385922775", "12345", "Khách hàng 1", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "MaMauSac", "TenMauSac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("02dabd87-7211-4ae9-9531-c139ce84beec"), "MS3", "Màu sắc 3", 0 },
                    { new Guid("46a2def5-0250-4d51-92fd-59041dc78691"), "MS2", "Màu sắc 2", 0 },
                    { new Guid("6713ae1f-9b60-4de4-a38e-d56049e0c5e0"), "MS5", "Màu sắc 5", 0 },
                    { new Guid("77ed823f-8806-41b7-9c18-6944bbd1cff1"), "MS1", "Màu sắc 1", 0 },
                    { new Guid("7b883e9c-18c4-4aec-902d-9ca619b2e088"), "MS4", "Màu sắc 4", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "Id", "DiaChi", "MaNsx", "TenNsx" },
                values: new object[,]
                {
                    { new Guid("1e26b99a-2d8e-4e24-9dc7-47047e44ddd6"), "Hà Nội", "NSX1", "Nhà sản xuất 1" },
                    { new Guid("92a2c832-eff4-43f2-a6e6-780dd113ae38"), "Hà Nội", "NSX5", "Nhà sản xuất 5" },
                    { new Guid("940d39f3-695e-4bf1-8d53-ecb1fc65c446"), "Hà Nội", "NSX2", "Nhà sản xuất 2" },
                    { new Guid("c46a9983-2ccd-48dc-93c2-d2fbb9d07ed1"), "Hà Nội", "NSX4", "Nhà sản xuất 4" },
                    { new Guid("c8979339-5688-4c6a-b234-ee1f1ee9d9ff"), "Hà Nội", "NSX3", "Nhà sản xuất 3" }
                });

            _ = migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "SoSize", "TenSize", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1169d9cc-6f9e-426a-9271-d3f5bbc7bdb2"), "SZ5", 34, "Size 5", 0 },
                    { new Guid("72dccb49-2740-4afc-a805-9d902663b1ab"), "SZ3", 32, "Size 3", 0 },
                    { new Guid("80b654e3-fc5c-4bd3-ab7e-4f5f34dc6465"), "SZ1", 30, "Size 1", 0 },
                    { new Guid("ad592169-d26b-4699-b31b-059ca4b502e4"), "SZ4", 33, "Size 4", 0 },
                    { new Guid("b043b7f2-2ac4-45b2-9598-e525805e78a3"), "SZ2", 31, "Size 2", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChiTietGiay",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdChieuCaoDeGiay", "IdGiay", "IdHangGiay", "IdMauSac", "IdNsx", "IdSize", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("04a443a5-7d0f-42ad-b0ee-28e5ec45f24e"), 10000f, 7000f, new Guid("2429c610-dfef-4d75-96b7-7404f71e508a"), new Guid("d97f2312-a8ff-4550-b57b-1f132e81d6f0"), new Guid("df415f0c-0a0e-4c20-8a3f-b8cac6d95f69"), new Guid("6713ae1f-9b60-4de4-a38e-d56049e0c5e0"), new Guid("c8979339-5688-4c6a-b234-ee1f1ee9d9ff"), new Guid("ad592169-d26b-4699-b31b-059ca4b502e4"), null, 100, 0 },
                    { new Guid("315d48c6-e7a8-48de-acca-bf1b94379255"), 10000f, 7000f, new Guid("6eaa159a-b9a6-4322-8fd7-f95476014b01"), new Guid("d97f2312-a8ff-4550-b57b-1f132e81d6f0"), new Guid("c2731e15-224e-4abe-8c03-b81e03104354"), new Guid("02dabd87-7211-4ae9-9531-c139ce84beec"), new Guid("c46a9983-2ccd-48dc-93c2-d2fbb9d07ed1"), new Guid("b043b7f2-2ac4-45b2-9598-e525805e78a3"), null, 100, 0 },
                    { new Guid("38d1ac7e-4e25-4b92-a85c-2263cfaa0b19"), 10000f, 7000f, new Guid("4f1e567c-c03b-4691-af7d-0f5907b71888"), new Guid("dd6e4975-9a0b-4efb-8836-e0dbf492d33e"), new Guid("df415f0c-0a0e-4c20-8a3f-b8cac6d95f69"), new Guid("7b883e9c-18c4-4aec-902d-9ca619b2e088"), new Guid("940d39f3-695e-4bf1-8d53-ecb1fc65c446"), new Guid("1169d9cc-6f9e-426a-9271-d3f5bbc7bdb2"), null, 100, 0 },
                    { new Guid("6d7dd411-0b66-4017-8b3b-5278c9b9f9ac"), 10000f, 7000f, new Guid("5a9d56cd-0f34-4348-bc33-4b1b3d44120f"), new Guid("d97f2312-a8ff-4550-b57b-1f132e81d6f0"), new Guid("c2731e15-224e-4abe-8c03-b81e03104354"), new Guid("6713ae1f-9b60-4de4-a38e-d56049e0c5e0"), new Guid("c46a9983-2ccd-48dc-93c2-d2fbb9d07ed1"), new Guid("1169d9cc-6f9e-426a-9271-d3f5bbc7bdb2"), null, 100, 0 },
                    { new Guid("8177adc0-f492-44f0-b015-ef2d7e1d8552"), 10000f, 7000f, new Guid("5a9d56cd-0f34-4348-bc33-4b1b3d44120f"), new Guid("dd6e4975-9a0b-4efb-8836-e0dbf492d33e"), new Guid("176f1d26-d62e-43a1-831b-782fee5a5625"), new Guid("77ed823f-8806-41b7-9c18-6944bbd1cff1"), new Guid("c8979339-5688-4c6a-b234-ee1f1ee9d9ff"), new Guid("ad592169-d26b-4699-b31b-059ca4b502e4"), null, 100, 0 },
                    { new Guid("af02202c-c962-4243-8238-e6317f56f0f3"), 10000f, 7000f, new Guid("5a9d56cd-0f34-4348-bc33-4b1b3d44120f"), new Guid("d97f2312-a8ff-4550-b57b-1f132e81d6f0"), new Guid("c2731e15-224e-4abe-8c03-b81e03104354"), new Guid("7b883e9c-18c4-4aec-902d-9ca619b2e088"), new Guid("c8979339-5688-4c6a-b234-ee1f1ee9d9ff"), new Guid("ad592169-d26b-4699-b31b-059ca4b502e4"), null, 100, 0 },
                    { new Guid("b66a77b7-034a-421a-8d77-c81481d9132a"), 10000f, 7000f, new Guid("877f1a90-2de8-419a-9cc9-b793f2c3667a"), new Guid("dd6e4975-9a0b-4efb-8836-e0dbf492d33e"), new Guid("ed9a3578-bb35-429b-813f-8333a920d98b"), new Guid("77ed823f-8806-41b7-9c18-6944bbd1cff1"), new Guid("92a2c832-eff4-43f2-a6e6-780dd113ae38"), new Guid("1169d9cc-6f9e-426a-9271-d3f5bbc7bdb2"), null, 100, 0 },
                    { new Guid("c2e3aaa5-8068-4996-b41c-e32655578988"), 10000f, 7000f, new Guid("4f1e567c-c03b-4691-af7d-0f5907b71888"), new Guid("a72c231d-0818-4e87-99a7-b30ff7cce5b6"), new Guid("176f1d26-d62e-43a1-831b-782fee5a5625"), new Guid("02dabd87-7211-4ae9-9531-c139ce84beec"), new Guid("1e26b99a-2d8e-4e24-9dc7-47047e44ddd6"), new Guid("ad592169-d26b-4699-b31b-059ca4b502e4"), null, 100, 0 },
                    { new Guid("c9dddd17-d964-4947-bed4-37ff2d7e8b4f"), 10000f, 7000f, new Guid("877f1a90-2de8-419a-9cc9-b793f2c3667a"), new Guid("dd6e4975-9a0b-4efb-8836-e0dbf492d33e"), new Guid("176f1d26-d62e-43a1-831b-782fee5a5625"), new Guid("02dabd87-7211-4ae9-9531-c139ce84beec"), new Guid("1e26b99a-2d8e-4e24-9dc7-47047e44ddd6"), new Guid("80b654e3-fc5c-4bd3-ab7e-4f5f34dc6465"), null, 100, 0 },
                    { new Guid("d9f5c6c6-a111-4ea7-ab92-c4ddb1a98754"), 10000f, 7000f, new Guid("4f1e567c-c03b-4691-af7d-0f5907b71888"), new Guid("ffaeb614-9fa6-49cf-91da-9f70b6ee1699"), new Guid("ed9a3578-bb35-429b-813f-8333a920d98b"), new Guid("02dabd87-7211-4ae9-9531-c139ce84beec"), new Guid("c8979339-5688-4c6a-b234-ee1f1ee9d9ff"), new Guid("80b654e3-fc5c-4bd3-ab7e-4f5f34dc6465"), null, 100, 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdCuaHang", "MaNhanVien", "MatKhau", "NgaySinh", "Sdt", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1bff5f02-1f08-48e9-959e-5f20f24824fd"), "Hà Nội", null, 1, new Guid("3d54cbf7-9933-4314-88db-7edbb357cb6c"), new Guid("f1887f8f-910c-4dbc-9b30-3027bf3c8d03"), "NV2", "00000", new DateTime(2022, 11, 18, 7, 50, 0, 104, DateTimeKind.Local).AddTicks(6777), "0385922775", "Nhân viên 2", 0 },
                    { new Guid("cffe5808-8c26-44d1-b0a9-f65edfcd91bd"), "Hà Nội", null, 0, new Guid("3d54cbf7-9933-4314-88db-7edbb357cb6c"), new Guid("f1887f8f-910c-4dbc-9b30-3027bf3c8d03"), "NV1", "00000", new DateTime(2022, 11, 18, 7, 50, 0, 104, DateTimeKind.Local).AddTicks(6687), "0385922775", "Nhân viên 1", 0 }
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
