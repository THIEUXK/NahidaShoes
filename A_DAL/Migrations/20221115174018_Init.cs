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
                    { new Guid("23fd8acd-35b6-4386-ad7a-eec87b3a949c"), 4, "KC4", 0 },
                    { new Guid("4badeba9-ca83-4df3-9dce-aa97f3cc923d"), 3, "KC3", 0 },
                    { new Guid("82886453-e29e-475f-94b7-b3dcbed00e6b"), 5, "KC5", 0 },
                    { new Guid("9ab9876e-e95d-4f29-991b-b755863f0d1a"), 1, "KC1", 0 },
                    { new Guid("9ba4ec54-67db-4353-bed7-02030a990156"), 2, "KC2", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaChucVu", "TenChucVu", "TrangThai" },
                values: new object[] { new Guid("b18389a1-efe4-440e-a8e2-61a0e8d8f592"), "CV1", "Nhân viên", 0 });

            _ = migrationBuilder.InsertData(
                table: "CuaHang",
                columns: new[] { "Id", "DiaChi", "MaCuaHang", "TenCuaHang", "TrangThai" },
                values: new object[] { new Guid("df5f0843-f5a5-4a71-a76a-74c111f9e824"), "Hà Nội", "CH1", "Cửa hàng 1", 0 });

            _ = migrationBuilder.InsertData(
                table: "Giay",
                columns: new[] { "Id", "MaGiay", "TenGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0018e408-089e-464f-b53b-ea525cff069c"), "G1", "Giày 1", 0 },
                    { new Guid("5d7b56bc-378f-4187-b45c-a9f86f4468eb"), "G3", "Giày 3", 0 },
                    { new Guid("73e21b9d-6cf2-44f0-9d1c-aeb8231d2e3b"), "G4", "Giày 4", 0 },
                    { new Guid("7c1d2b44-6cb3-4024-bfa5-f27418790e49"), "G2", "Giày 2", 0 },
                    { new Guid("f8ff2f30-3778-4d8f-b50a-e6f719cfda26"), "G5", "Giày 5", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "MaHangGiay", "TenHangGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("06194216-0662-4cb4-94c9-1ff1200fbaa7"), "HG3", "Hãng giày 3", 0 },
                    { new Guid("183a85d3-d1bf-4162-a6d7-4a55c7fa68b3"), "HG5", "Hãng giày 5", 0 },
                    { new Guid("d183b232-3f41-4a5a-8264-63a119947b4f"), "HG4", "Hãng giày 4", 0 },
                    { new Guid("e3958fb7-5581-46fc-819f-4fba1d69b3e4"), "HG1", "Hãng giày 1", 0 },
                    { new Guid("e670b84e-f7e5-48dd-ac49-f8a95efb8a28"), "HG2", "Hãng giày 2", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "MaKhachHang", "NgaySinh", "Sdt", "SoCCCD", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1c012dd2-73e1-4d49-a208-5ccc7475b8b8"), "Hà Nội", null, "KH1", new DateTime(2022, 11, 16, 0, 40, 17, 919, DateTimeKind.Local).AddTicks(1411), "0385922775", "12345", "Khách hàng 1", 0 },
                    { new Guid("ab801907-3b74-43ec-b0d9-17dbbd3f19ff"), "Hà Nội", null, "KH2", new DateTime(2022, 11, 16, 0, 40, 17, 919, DateTimeKind.Local).AddTicks(1434), "0385922775", "01234", "Khách hàng 2", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "MaMauSac", "TenMauSac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1b1e29a8-91a3-4806-8b17-22ce23ea9691"), "MS5", "Màu sắc 5", 0 },
                    { new Guid("1e113d7c-a0ff-4e79-8b9d-3e20205bb7d7"), "MS4", "Màu sắc 4", 0 },
                    { new Guid("b8ffac07-74b8-436a-881d-63c47bd1355b"), "MS2", "Màu sắc 2", 0 },
                    { new Guid("d26073e9-2f7d-40fb-adb4-f5cd2e130321"), "MS3", "Màu sắc 3", 0 },
                    { new Guid("e759a64e-0825-49d8-bfba-50b3dc30eef6"), "MS1", "Màu sắc 1", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "Id", "DiaChi", "MaNsx", "TenNsx" },
                values: new object[,]
                {
                    { new Guid("182f595c-e8a2-4d82-b89b-4e414074d21e"), "Hà Nội", "NSX1", "Nhà sản xuất 1" },
                    { new Guid("2f4e53c5-02cd-4c14-a0a1-d5afc6651403"), "Hà Nội", "NSX5", "Nhà sản xuất 5" },
                    { new Guid("6d45a6bf-8791-4198-adc0-30749e38e47f"), "Hà Nội", "NSX3", "Nhà sản xuất 3" },
                    { new Guid("7379f54e-61af-4599-b610-8b09967cdab5"), "Hà Nội", "NSX4", "Nhà sản xuất 4" },
                    { new Guid("e13a1047-022c-4901-a473-9d6fbe6268ed"), "Hà Nội", "NSX2", "Nhà sản xuất 2" }
                });

            _ = migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "SoSize", "TenSize", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("083bb147-a858-46ed-a053-231d64d72a34"), "SZ3", 32, "Size 3", 0 },
                    { new Guid("914a06ad-4243-4cc8-a9b0-415a9e1d5df4"), "SZ4", 33, "Size 4", 0 },
                    { new Guid("9fd21196-ee3a-44ae-9ecb-32e815635506"), "SZ2", 31, "Size 2", 0 },
                    { new Guid("ac0b2bf3-4ff8-40db-8fdc-10714c1f29af"), "SZ1", 30, "Size 1", 0 },
                    { new Guid("d9307aac-0deb-43a5-b8e3-be66f7124982"), "SZ5", 34, "Size 5", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChiTietGiay",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdChieuCaoDeGiay", "IdGiay", "IdHangGiay", "IdMauSac", "IdNsx", "IdSize", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("2f54d08c-7d4c-4658-8e11-e4a6f6006e12"), 10000f, 7000f, new Guid("23fd8acd-35b6-4386-ad7a-eec87b3a949c"), new Guid("f8ff2f30-3778-4d8f-b50a-e6f719cfda26"), new Guid("d183b232-3f41-4a5a-8264-63a119947b4f"), new Guid("1b1e29a8-91a3-4806-8b17-22ce23ea9691"), new Guid("182f595c-e8a2-4d82-b89b-4e414074d21e"), new Guid("083bb147-a858-46ed-a053-231d64d72a34"), null, 100, 0 },
                    { new Guid("698ea76d-0580-4dc2-8030-8fd7f9f0824e"), 10000f, 7000f, new Guid("82886453-e29e-475f-94b7-b3dcbed00e6b"), new Guid("7c1d2b44-6cb3-4024-bfa5-f27418790e49"), new Guid("06194216-0662-4cb4-94c9-1ff1200fbaa7"), new Guid("b8ffac07-74b8-436a-881d-63c47bd1355b"), new Guid("6d45a6bf-8791-4198-adc0-30749e38e47f"), new Guid("d9307aac-0deb-43a5-b8e3-be66f7124982"), null, 100, 0 },
                    { new Guid("727165e0-829f-44cd-8c01-87128d3699e8"), 10000f, 7000f, new Guid("82886453-e29e-475f-94b7-b3dcbed00e6b"), new Guid("0018e408-089e-464f-b53b-ea525cff069c"), new Guid("e3958fb7-5581-46fc-819f-4fba1d69b3e4"), new Guid("1e113d7c-a0ff-4e79-8b9d-3e20205bb7d7"), new Guid("7379f54e-61af-4599-b610-8b09967cdab5"), new Guid("d9307aac-0deb-43a5-b8e3-be66f7124982"), null, 100, 0 },
                    { new Guid("72a045f6-4750-4b4c-9a71-7b111cbb3464"), 10000f, 7000f, new Guid("9ba4ec54-67db-4353-bed7-02030a990156"), new Guid("0018e408-089e-464f-b53b-ea525cff069c"), new Guid("183a85d3-d1bf-4162-a6d7-4a55c7fa68b3"), new Guid("1e113d7c-a0ff-4e79-8b9d-3e20205bb7d7"), new Guid("7379f54e-61af-4599-b610-8b09967cdab5"), new Guid("9fd21196-ee3a-44ae-9ecb-32e815635506"), null, 100, 0 },
                    { new Guid("8a39c1c7-905f-49ef-ab88-700c3d1e5744"), 10000f, 7000f, new Guid("4badeba9-ca83-4df3-9dce-aa97f3cc923d"), new Guid("5d7b56bc-378f-4187-b45c-a9f86f4468eb"), new Guid("d183b232-3f41-4a5a-8264-63a119947b4f"), new Guid("1b1e29a8-91a3-4806-8b17-22ce23ea9691"), new Guid("182f595c-e8a2-4d82-b89b-4e414074d21e"), new Guid("083bb147-a858-46ed-a053-231d64d72a34"), null, 100, 0 },
                    { new Guid("d6696331-32b8-416f-874e-e0d6db7aded5"), 10000f, 7000f, new Guid("23fd8acd-35b6-4386-ad7a-eec87b3a949c"), new Guid("5d7b56bc-378f-4187-b45c-a9f86f4468eb"), new Guid("183a85d3-d1bf-4162-a6d7-4a55c7fa68b3"), new Guid("d26073e9-2f7d-40fb-adb4-f5cd2e130321"), new Guid("182f595c-e8a2-4d82-b89b-4e414074d21e"), new Guid("9fd21196-ee3a-44ae-9ecb-32e815635506"), null, 100, 0 },
                    { new Guid("dd73b252-6466-4234-9420-483de3967a92"), 10000f, 7000f, new Guid("4badeba9-ca83-4df3-9dce-aa97f3cc923d"), new Guid("5d7b56bc-378f-4187-b45c-a9f86f4468eb"), new Guid("183a85d3-d1bf-4162-a6d7-4a55c7fa68b3"), new Guid("1e113d7c-a0ff-4e79-8b9d-3e20205bb7d7"), new Guid("182f595c-e8a2-4d82-b89b-4e414074d21e"), new Guid("083bb147-a858-46ed-a053-231d64d72a34"), null, 100, 0 },
                    { new Guid("e8667725-7210-4461-8c1e-ed80aa83eeb4"), 10000f, 7000f, new Guid("23fd8acd-35b6-4386-ad7a-eec87b3a949c"), new Guid("73e21b9d-6cf2-44f0-9d1c-aeb8231d2e3b"), new Guid("183a85d3-d1bf-4162-a6d7-4a55c7fa68b3"), new Guid("1b1e29a8-91a3-4806-8b17-22ce23ea9691"), new Guid("7379f54e-61af-4599-b610-8b09967cdab5"), new Guid("9fd21196-ee3a-44ae-9ecb-32e815635506"), null, 100, 0 },
                    { new Guid("f5776735-8478-46f7-83f1-3244344ee82e"), 10000f, 7000f, new Guid("9ba4ec54-67db-4353-bed7-02030a990156"), new Guid("7c1d2b44-6cb3-4024-bfa5-f27418790e49"), new Guid("e670b84e-f7e5-48dd-ac49-f8a95efb8a28"), new Guid("e759a64e-0825-49d8-bfba-50b3dc30eef6"), new Guid("2f4e53c5-02cd-4c14-a0a1-d5afc6651403"), new Guid("9fd21196-ee3a-44ae-9ecb-32e815635506"), null, 100, 0 },
                    { new Guid("fd415eb7-949d-4279-9ba0-664b99d2b509"), 10000f, 7000f, new Guid("9ba4ec54-67db-4353-bed7-02030a990156"), new Guid("73e21b9d-6cf2-44f0-9d1c-aeb8231d2e3b"), new Guid("e3958fb7-5581-46fc-819f-4fba1d69b3e4"), new Guid("b8ffac07-74b8-436a-881d-63c47bd1355b"), new Guid("182f595c-e8a2-4d82-b89b-4e414074d21e"), new Guid("9fd21196-ee3a-44ae-9ecb-32e815635506"), null, 100, 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdCuaHang", "MaNhanVien", "MatKhau", "NgaySinh", "Sdt", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0e8b792a-98c1-4181-8e2f-86331faefab3"), "Hà Nội", null, 1, new Guid("b18389a1-efe4-440e-a8e2-61a0e8d8f592"), new Guid("df5f0843-f5a5-4a71-a76a-74c111f9e824"), "NV2", "00000", new DateTime(2022, 11, 16, 0, 40, 17, 919, DateTimeKind.Local).AddTicks(1396), "0385922775", "Nhân viên 2", 0 },
                    { new Guid("ca61d1c2-025e-4a33-aaab-d2d753f40c5a"), "Hà Nội", null, 0, new Guid("b18389a1-efe4-440e-a8e2-61a0e8d8f592"), new Guid("df5f0843-f5a5-4a71-a76a-74c111f9e824"), "NV1", "00000", new DateTime(2022, 11, 16, 0, 40, 17, 919, DateTimeKind.Local).AddTicks(1376), "0385922775", "Nhân viên 1", 0 }
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
