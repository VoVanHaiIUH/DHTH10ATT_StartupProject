USE [SPRHR_Solution]
GO
/****** Object:  Table [dbo].[BangGiaBan]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGiaBan](
	[maSP] [nvarchar](50) NOT NULL,
	[giaBan] [money] NOT NULL,
	[ngayApDung] [datetime] NOT NULL,
 CONSTRAINT [PK_BangGiaBan] PRIMARY KEY CLUSTERED 
(
	[maSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BangGiaBanSi]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGiaBanSi](
	[maSP] [nvarchar](50) NOT NULL,
	[giaBan] [nchar](10) NOT NULL,
 CONSTRAINT [PK_BangGiaBanSi] PRIMARY KEY CLUSTERED 
(
	[maSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonBanHang]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBanHang](
	[soHD] [nvarchar](50) NOT NULL,
	[soCTHD] [int] NOT NULL,
	[maSP] [nvarchar](50) NOT NULL,
	[soLuong] [smallint] NOT NULL,
	[gia] [money] NOT NULL,
	[giaKhuyenMai] [money] NULL,
 CONSTRAINT [FK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[soHD] ASC,
	[soCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonBanSi]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBanSi](
	[MaHoaDonBanSi] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaBanSi] [money] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietHoaDonBanSi] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonBanSi] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhaCungCap]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhaCungCap](
	[MaHoaDonNhaCungCap] [nvarchar](50) NOT NULL,
	[MaSPNCC] [nvarchar](50) NOT NULL,
	[TenSPNCC] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaMuaBenNhaCungCap] [money] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhaCungCap_1] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhaCungCap] ASC,
	[MaSPNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietKho]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietKho](
	[maKho] [varchar](15) NOT NULL,
	[maSP] [nvarchar](50) NOT NULL,
	[soLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietKho] PRIMARY KEY CLUSTERED 
(
	[maKho] ASC,
	[maSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietKhuyenMai]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietKhuyenMai](
	[MaCT] [nvarchar](50) NOT NULL,
	[MaChiTietKhuyenMai] [nvarchar](50) NOT NULL,
	[MaSp] [nvarchar](50) NOT NULL,
	[MucGiam] [float] NOT NULL,
	[DonGia] [money] NOT NULL,
	[GiaKhuyenMai] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaChiTietKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietKyLuat]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietKyLuat](
	[maKyLuat] [varchar](20) NOT NULL,
	[ngayLapKyLuat] [datetime] NOT NULL,
	[maNhanVien] [varchar](20) NOT NULL,
	[lyDo] [nvarchar](max) NOT NULL,
	[ngayApDungKyLuat] [datetime] NOT NULL,
	[ngayKetThucKyLuat] [datetime] NULL,
 CONSTRAINT [PK_ChiTietKyLuat] PRIMARY KEY CLUSTERED 
(
	[maKyLuat] ASC,
	[ngayLapKyLuat] ASC,
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietLich]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietLich](
	[maLich] [varchar](20) NOT NULL,
	[maNhanVien] [varchar](20) NOT NULL,
	[ngayBatDau] [datetime] NOT NULL,
	[ngayKetThuc] [datetime] NULL,
	[ghiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK_ChiTietLich_1] PRIMARY KEY CLUSTERED 
(
	[maLich] ASC,
	[maNhanVien] ASC,
	[ngayBatDau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuDNNK]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuDNNK](
	[MaPhieuDNNK] [nvarchar](20) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietPhieuDeNghiNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDNNK] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuDNXK]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuDNXK](
	[MaPhieuDNXK] [nvarchar](15) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTieuXuatKho_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDNXK] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuTraNoKhachHang]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuTraNoKhachHang](
	[NgayTra] [date] NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[MaHoaDonBanSi] [nvarchar](50) NOT NULL,
	[MaChiTietPhieuTraNoKH] [nvarchar](50) NOT NULL,
	[SoTien] [money] NOT NULL,
	[GhiChu] [nvarchar](250) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuTraNoNCC]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuTraNoNCC](
	[SoTien] [money] NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
	[MaHoaDonNCC] [nvarchar](50) NOT NULL,
	[MaChiTietPhieuTraNoNCC] [nvarchar](50) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[NgayTra] [date] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuTraNoNCC] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuTraNoNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maChucVu] [varchar](20) NOT NULL,
	[tenChucVU] [nvarchar](100) NOT NULL,
	[moTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[maChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChuongTrinhDaoTao]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChuongTrinhDaoTao](
	[machuongTrinhDaoTao] [varchar](20) NOT NULL,
	[tenChuongTrinhDaoTao] [nvarchar](30) NOT NULL,
	[ghiChu] [nvarchar](500) NULL,
	[coSoDaoTao] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TrinhDoHocVan_1] PRIMARY KEY CLUSTERED 
(
	[machuongTrinhDaoTao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChuongTrinhKhuyenMai]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhKhuyenMai](
	[MaCT] [nvarchar](50) NOT NULL,
	[TenCT] [nvarchar](50) NOT NULL,
	[NgayKhoiDong] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChuongTrinhKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CongNoKH]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongNoKH](
	[MaHoaDonBanSi] [nvarchar](50) NOT NULL,
	[SoTienNo] [money] NOT NULL,
	[GhiChu] [nvarchar](500) NULL,
	[NgayDaoHan] [date] NOT NULL,
 CONSTRAINT [PK_CongNoKH] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonBanSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CongNoNCC]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongNoNCC](
	[MaHoaDonNCC] [nvarchar](50) NOT NULL,
	[SoTienNo] [money] NOT NULL,
	[GhiChu] [nvarchar](500) NULL,
	[NgayDaoHan] [date] NOT NULL,
 CONSTRAINT [PK_CongNoNCC_1] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhGia](
	[maNhanVien] [varchar](20) NOT NULL,
	[ngayDanhGia] [date] NOT NULL,
	[loaiDanhGia] [nvarchar](50) NOT NULL,
	[ghiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_DanhGia] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC,
	[ngayDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DanhMucCuaHang]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhMucCuaHang](
	[MaCuaHang] [varchar](15) NOT NULL,
	[TenCuaHang] [nvarchar](150) NOT NULL,
	[DiaChi] [nvarchar](250) NOT NULL,
	[SoDienThoai] [varchar](15) NOT NULL,
	[TinhTrang] [int] NOT NULL,
 CONSTRAINT [PK_DanhMucCuaHang_1] PRIMARY KEY CLUSTERED 
(
	[MaCuaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[soHD] [nvarchar](50) NOT NULL,
	[maKH] [nvarchar](50) NOT NULL,
	[maNV] [varchar](20) NOT NULL,
	[tongTien] [money] NOT NULL,
	[ngayLap] [datetime] NOT NULL,
	[VAT] [bit] NULL CONSTRAINT [DF_HoaDonBanHang_VAT]  DEFAULT ((0)),
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[soHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonBanSi]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonBanSi](
	[MaHoaDonBanSi] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[TongTien] [money] NOT NULL,
	[soTienDatra] [money] NOT NULL,
 CONSTRAINT [PK_HoaDonBanSi] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonBanSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonNhaCungCap]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNhaCungCap](
	[MaHoaDonNCC] [nvarchar](50) NOT NULL,
	[MaNhaCungCap] [nvarchar](50) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [datetime] NOT NULL,
	[TongTien] [money] NOT NULL,
	[sotienDatra] [money] NOT NULL,
 CONSTRAINT [PK_HoaDonNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[DiaChiKH] [nvarchar](50) NOT NULL,
	[SDTKH] [varchar](12) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[MaSoThue] [varchar](12) NULL,
	[TenCongTy] [nvarchar](150) NULL,
	[DiaChiCongTy] [nvarchar](250) NULL,
	[SDTCongTy] [varchar](12) NULL,
	[EmailCongTy] [varchar](150) NULL,
	[SoTaiKhoanNH] [varchar](15) NOT NULL,
	[TenNH] [nvarchar](150) NOT NULL,
	[ChiNhanhNH] [nvarchar](150) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KyLuat](
	[maKyLuat] [varchar](20) NOT NULL,
	[dieuKhoanKyLuat] [nvarchar](max) NOT NULL,
	[hinhThucKyLuat] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maKyLuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichLamViec]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichLamViec](
	[maLich] [varchar](20) NOT NULL,
	[caLamViec] [varchar](10) NOT NULL,
	[gioLam] [time](7) NOT NULL,
	[gioKetThuc] [time](7) NOT NULL,
	[ghiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_LichLamViec] PRIMARY KEY CLUSTERED 
(
	[maLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichSuLamViec]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichSuLamViec](
	[maNhanVien] [varchar](20) NOT NULL,
	[maPhongBan] [varchar](20) NOT NULL,
	[ngayBatDauLamViec] [datetime] NOT NULL,
	[ngayKetThuc] [datetime] NULL,
	[maChucVu] [varchar](20) NOT NULL,
 CONSTRAINT [PK_lichSuLamViec] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC,
	[maPhongBan] ASC,
	[ngayBatDauLamViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [nvarchar](50) NOT NULL,
	[TenLoaiSanPham] [nvarchar](50) NOT NULL,
	[Mota] [nvarchar](max) NULL,
	[Style] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](50) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[NgayThanhLap] [datetime] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [varchar](20) NOT NULL,
	[hoTenNhanVien] [nvarchar](30) NOT NULL,
	[ngayBatDauLamViec] [date] NOT NULL,
	[tinhTrang] [varchar](20) NOT NULL,
	[soTKNganHang] [varchar](20) NOT NULL,
	[soDT] [varchar](11) NOT NULL,
	[queQuan] [nvarchar](100) NULL,
	[Email] [nvarchar](30) NOT NULL,
	[soCMND] [varchar](15) NOT NULL,
	[diaChi] [nvarchar](250) NOT NULL,
	[gioiTinh] [nvarchar](10) NOT NULL,
	[ngaySinh] [date] NOT NULL,
 CONSTRAINT [PK__NhanVien__BDDEF20D6B5FAD78] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuDNNK]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuDNNK](
	[MaPhieuDNNK] [nvarchar](20) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[MaKho] [nvarchar](50) NOT NULL,
	[tinhtrang] [int] NOT NULL,
	[MaHoaDonNCC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuDNNK] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDNNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuDNXK]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuDNXK](
	[MaPhieuDNXK] [nvarchar](15) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[MaKH] [nvarchar](50) NULL,
	[NgayLap] [datetime] NOT NULL,
	[MaKho] [nvarchar](50) NOT NULL,
	[tinhtrang] [int] NOT NULL CONSTRAINT [DF_PhieuDeNghiXuatKho_tinhtrang]  DEFAULT ((0)),
	[MaHoaDonBanSi] [nvarchar](50) NULL,
	[MaCuaHang] [varchar](15) NULL,
 CONSTRAINT [PK_PhieuDeNghiXuatKho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDNXK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhapKho]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhapKho](
	[sopnk] [nvarchar](20) NOT NULL,
	[manhanvien] [varchar](20) NOT NULL,
	[ngaylap] [date] NOT NULL,
	[makho] [varchar](15) NOT NULL,
 CONSTRAINT [PK_PhieuNhapKho_1] PRIMARY KEY CLUSTERED 
(
	[sopnk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuatKho]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuatKho](
	[soPXK] [nvarchar](15) NOT NULL,
	[manhanvien] [varchar](20) NOT NULL,
	[ngaylap] [date] NOT NULL,
	[makho] [varchar](15) NOT NULL,
	[ghiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK_PhieuXuatKhp] PRIMARY KEY CLUSTERED 
(
	[soPXK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongBan](
	[maPhongBan] [varchar](20) NOT NULL,
	[tenPhongBan] [nvarchar](100) NOT NULL,
	[khuVuc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhuongThucThanhToan]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhuongThucThanhToan](
	[maPhuongThuc] [varchar](50) NOT NULL,
	[tenPhuongThuc] [nvarchar](50) NOT NULL,
	[moTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_PhuongThucThanhToan] PRIMARY KEY CLUSTERED 
(
	[maPhuongThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuanLyKho]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuanLyKho](
	[maKho] [varchar](15) NOT NULL,
	[manhanvien] [varchar](20) NOT NULL,
	[chucVu] [nvarchar](50) NOT NULL,
	[thoiGianBatDau] [date] NOT NULL,
	[thoiGianKetThuc] [date] NOT NULL,
 CONSTRAINT [PK_QuanLyKho_1] PRIMARY KEY CLUSTERED 
(
	[maKho] ASC,
	[manhanvien] ASC,
	[thoiGianBatDau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuaTrinhDaoTao]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuaTrinhDaoTao](
	[maNhanVien] [varchar](20) NOT NULL,
	[maChuongTrinhDaoTao] [varchar](20) NOT NULL,
	[ngayDuocDaoTao] [date] NOT NULL,
	[ngayKetThucDaoTao] [date] NOT NULL,
	[loaiDanhGia] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_QuaTrinhDaoTao] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC,
	[maChuongTrinhDaoTao] ASC,
	[ngayDuocDaoTao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSp] [nvarchar](50) NOT NULL,
	[NgaySanXuat] [datetime] NOT NULL,
	[DonViTinh] [nvarchar](30) NULL,
	[KieuDang] [nvarchar](50) NULL,
	[MauSac] [nvarchar](50) NULL,
	[TrongLuong] [float] NULL,
	[MaLoaiSanPham] [nvarchar](50) NOT NULL,
	[Mota] [nvarchar](500) NULL,
	[NgayHetHan] [date] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[soHD] [nvarchar](50) NOT NULL,
	[tien] [money] NOT NULL,
	[maPhuongThuc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ThanhToan] PRIMARY KEY CLUSTERED 
(
	[soHD] ASC,
	[maPhuongThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheThanhVien]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThanhVien](
	[MaThe] [nvarchar](50) NOT NULL,
	[NgayCapThe] [datetime] NOT NULL,
	[SoDiem] [int] NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinKho]    Script Date: 11/15/2016 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinKho](
	[maKho] [varchar](15) NOT NULL,
	[tenKho] [nvarchar](50) NOT NULL,
	[diaChi] [nvarchar](250) NOT NULL,
	[soDienThoai] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_ThongTinKho] PRIMARY KEY CLUSTERED 
(
	[maKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'DeNhat', 3300.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'H10BKCV', 10890000.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'H10S3KS', 7480000.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'H13BKCV', 13035000.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'HaoHao', 3300.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'HaoHao100', 3300.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'Iphone5s_16', 7689000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'Iphone6s_16', 21989000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'Iphone7_256', 30789000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'LauThai', 3300.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'No225', 1419000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'No630', 1749000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'No730', 3289000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'SamsungA3', 6259000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'SamSungNote5', 15389000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'SamSungS7', 20339000.0000, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'UA32K5300', 8690000.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'UA43K5310', 11429000.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'UA55K5300', 20790000.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBan] ([maSP], [giaBan], [ngayApDung]) VALUES (N'Udon', 3300.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'DeNhat', N'3150      ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'H10BKCV', N'10395000  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'H10S3KS', N'7140000   ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'H13BKCV', N'12442500  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'HaoHao', N'3150      ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'HaoHao100', N'3150      ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'Iphone5s_16', N'7339500   ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'Iphone6s_16', N'20989500  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'Iphone7_256', N'29389500  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'LauThai', N'3150      ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'No225', N'1354500   ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'No630', N'1669500   ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'No730', N'3139500   ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'SamsungA3', N'5974500   ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'SamSungNote5', N'14689500  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'SamSungS7', N'19414500  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'UA32K5300', N'8295000   ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'UA43K5310', N'10909500  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'UA55K5300', N'19845000  ')
GO
INSERT [dbo].[BangGiaBanSi] ([maSP], [giaBan]) VALUES (N'Udon', N'3150      ')
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160102_0001', 1, N'Iphone5s_16', 1, 7689000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160102_0002', 1, N'SamsungA3', 1, 6259000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160102_0003', 1, N'No225', 1, 1419000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160201_0001', 1, N'SamSungNote5', 1, 15389000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160201_0002', 1, N'SamSungS7', 1, 20339000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160201_0003', 1, N'SamSungNote5', 1, 15389000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160301_0001', 1, N'No730', 1, 3289000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160301_0002', 1, N'No630', 1, 1749000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160301_0003', 1, N'Iphone7_256', 1, 30789000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160401_0001', 1, N'DeNhat', 30, 3300.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160401_0001', 2, N'UA32K5300', 1, 8690000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160401_0001', 3, N'SamsungA3', 1, 6259000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160501_0001', 1, N'SamSungNote5', 2, 15389000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160601_0001', 1, N'UA55K5300', 1, 20790000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160701_0001', 1, N'Iphone7_256', 1, 30789000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160801_0001', 1, N'HaoHao', 30, 3300.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20160901_0001', 1, N'UA55K5300', 2, 20790000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([soHD], [soCTHD], [maSP], [soLuong], [gia], [giaKhuyenMai]) VALUES (N'20161001_0001', 1, N'H10S3KS', 3, 7480000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160102_0001', N'No730', 10, 3139500.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160102_0002', N'No225', 10, 1354500.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160102_0003', N'No630', 10, 1669500.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160201_0001', N'HaoHao100', 300, 3150.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160201_0001', N'LauThai', 300, 3150.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160201_0001', N'Udon', 300, 3150.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160301_0001', N'UA43K5310', 20, 10909500.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160401_0001', N'UA55K5300', 17, 19845000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonBanSi] ([MaHoaDonBanSi], [MaSP], [SoLuong], [GiaBanSi], [GhiChu]) VALUES (N'BS20160501_0001', N'DeNhat', 1970, 3150.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC001', N'No225', N'Dien Thoai Nokia 225', 100, 1290000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC001', N'No630', N'Dien Thoai Nokia 630', 100, 1590000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC001', N'No730', N'Dien Thoai Nokia 730', 100, 2990000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC002', N'SamsungA3', N'SamSung Galaxy A3 2016', 50, 5690000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC002', N'SamSungNote5', N'SamSung Galaxy Note5', 50, 13990000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC002', N'SamSungS7', N'SamSung Galaxy S7', 50, 18490000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC003', N'Iphone5s_16', N'Iphone 5s 16GB', 20, 6990000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC003', N'Iphone6s_16', N'Iphone 6s Plus 16GB', 20, 19990000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC003', N'Iphone7_256', N'Iphone 7 Plus 256GB', 20, 27990000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC004', N'DeNhat', N'Mì Đệ Nhất', 3000, 3000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC004', N'HaoHao', N'Mì Hảo Hảo Tôm Chua Cay', 3000, 3000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC004', N'HaoHao100', N'Mì Hảo Hảo 100', 3000, 3000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC004', N'LauThai', N'Mì Lẩu Thái', 3000, 3000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC004', N'Udon', N'Mì Udon', 3000, 3000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC005', N'UA32K5300', N'Smart Tivi Samsung 32 inch UA32K5300', 100, 7900000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC005', N'UA43K5310', N'Smart Tivi Samsung 43 inch UA43K5310', 100, 10390000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC005', N'UA55K5300', N'Smart Tivi Samsung 55 inch UA55K5300', 100, 18900000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC006', N'H10BKCV', N'Máy Lạnh Toshiba H10BKCV', 50, 9900000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC006', N'H10S3KS', N'Máy Lạnh Toshiba H10S3KS', 50, 6800000.0000, NULL)
GO
INSERT [dbo].[ChiTietHoaDonNhaCungCap] ([MaHoaDonNhaCungCap], [MaSPNCC], [TenSPNCC], [SoLuong], [GiaMuaBenNhaCungCap], [GhiChu]) VALUES (N'HDNCC006', N'H13BKCV', N'Máy Lạnh Toshiba H13BKCV', 50, 11850000.0000, NULL)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'DeNhat', 1000)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'H10BKCV', 50)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'H10S3KS', 47)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'H13BKCV', 50)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'HaoHao', 2970)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'HaoHao100', 2700)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'Iphone5s_16', 19)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'Iphone6s_16', 20)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'Iphone7_256', 18)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'LauThai', 2700)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'No225', 89)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'No630', 89)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'No730', 89)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'SamsungA3', 48)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'SamSungNote5', 46)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'SamSungS7', 49)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'UA32K5300', 99)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'UA43K5310', 80)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'UA55K5300', 80)
GO
INSERT [dbo].[ChiTietKho] ([maKho], [maSP], [soLuong]) VALUES (N'MK01', N'Udon', 2700)
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0001', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0002', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0003', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0004', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0005', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0006', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0007', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0008', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0009', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML01', N'NV0010', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0021', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0022', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0023', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0024', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0025', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0026', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0027', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0028', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0029', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0030', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0031', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0032', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0033', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0034', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietLich] ([maLich], [maNhanVien], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (N'ML03', N'NV0035', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK001', N'No225', 100, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK001', N'No630', 100, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK001', N'No730', 100, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK002', N'SamsungA3', 50, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK002', N'SamSungNote5', 50, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK002', N'SamSungS7', 50, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK003', N'Iphone5s_16', 20, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK003', N'Iphone6s_16', 20, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK003', N'Iphone7_256', 20, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK004', N'DeNhat', 3000, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK004', N'HaoHao', 3000, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK004', N'HaoHao100', 3000, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK004', N'LauThai', 3000, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK004', N'Udon', 3000, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK005', N'UA32K5300', 100, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK005', N'UA43K5310', 100, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK005', N'UA55K5300', 100, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK006', N'H10BKCV', 50, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK006', N'H10S3KS', 50, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNNK] ([MaPhieuDNNK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNNK006', N'H13BKCV', 50, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0001', N'No730', 10, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0002', N'No225', 10, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0003', N'No630', 10, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0004', N'HaoHao100', 300, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0004', N'LauThai', 300, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0004', N'Udon', 300, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0005', N'UA43K5310', 20, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0006', N'UA55K5300', 17, NULL)
GO
INSERT [dbo].[ChiTietPhieuDNXK] ([MaPhieuDNXK], [MaSP], [SoLuong], [GhiChu]) VALUES (N'PDNXK0007', N'DeNhat', 1970, NULL)
GO
INSERT [dbo].[ChiTietPhieuTraNoKhachHang] ([NgayTra], [MaNhanVien], [MaHoaDonBanSi], [MaChiTietPhieuTraNoKH], [SoTien], [GhiChu]) VALUES (CAST(N'2016-10-10' AS Date), N'NV0001', N'BS20160102_0001', N'CNKH0001', 15697500.0000, NULL)
GO
INSERT [dbo].[ChiTietPhieuTraNoKhachHang] ([NgayTra], [MaNhanVien], [MaHoaDonBanSi], [MaChiTietPhieuTraNoKH], [SoTien], [GhiChu]) VALUES (CAST(N'2016-10-10' AS Date), N'NV0001', N'BS20160102_0002', N'CNKH0002', 6772500.0000, NULL)
GO
INSERT [dbo].[ChiTietPhieuTraNoKhachHang] ([NgayTra], [MaNhanVien], [MaHoaDonBanSi], [MaChiTietPhieuTraNoKH], [SoTien], [GhiChu]) VALUES (CAST(N'2016-10-10' AS Date), N'NV0001', N'BS20160102_0003', N'CNKH0003', 8347500.0000, NULL)
GO
INSERT [dbo].[ChiTietPhieuTraNoNCC] ([SoTien], [GhiChu], [MaHoaDonNCC], [MaChiTietPhieuTraNoNCC], [MaNhanVien], [NgayTra]) VALUES (10000.0000, NULL, N'HDNCC001', N'CTPTNNCC001', N'NV0001', CAST(N'2016-10-10' AS Date))
GO
INSERT [dbo].[ChiTietPhieuTraNoNCC] ([SoTien], [GhiChu], [MaHoaDonNCC], [MaChiTietPhieuTraNoNCC], [MaNhanVien], [NgayTra]) VALUES (10000.0000, NULL, N'HDNCC001', N'CTPTNNCC002', N'NV0001', CAST(N'2016-10-10' AS Date))
GO
INSERT [dbo].[ChiTietPhieuTraNoNCC] ([SoTien], [GhiChu], [MaHoaDonNCC], [MaChiTietPhieuTraNoNCC], [MaNhanVien], [NgayTra]) VALUES (10000.0000, NULL, N'HDNCC002', N'CTPTNNCC003', N'NV0001', CAST(N'2016-10-10' AS Date))
GO
INSERT [dbo].[ChiTietPhieuTraNoNCC] ([SoTien], [GhiChu], [MaHoaDonNCC], [MaChiTietPhieuTraNoNCC], [MaNhanVien], [NgayTra]) VALUES (10000.0000, NULL, N'HDNCC002', N'CTPTNNCC004', N'NV0001', CAST(N'2016-10-10' AS Date))
GO
INSERT [dbo].[ChiTietPhieuTraNoNCC] ([SoTien], [GhiChu], [MaHoaDonNCC], [MaChiTietPhieuTraNoNCC], [MaNhanVien], [NgayTra]) VALUES (10000.0000, NULL, N'HDNCC003', N'CTPTNNCC005', N'NV0001', CAST(N'2016-10-10' AS Date))
GO
INSERT [dbo].[ChiTietPhieuTraNoNCC] ([SoTien], [GhiChu], [MaHoaDonNCC], [MaChiTietPhieuTraNoNCC], [MaNhanVien], [NgayTra]) VALUES (5555.0000, NULL, N'HDNCC004', N'CTPTNNCC006', N'NV0001', CAST(N'2016-10-10' AS Date))
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVU], [moTa]) VALUES (N'CV01', N'Giám Đốc', N'')
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVU], [moTa]) VALUES (N'CV02', N'Phó Giám Đốc', N'')
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVU], [moTa]) VALUES (N'CV03', N'Trưởng Phòng', N'')
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVU], [moTa]) VALUES (N'CV04', N'Phó Phòng', N'')
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVU], [moTa]) VALUES (N'CV05', N'Nhân Viên', N'')
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVU], [moTa]) VALUES (N'CV06', N'Tạp Vụ', N'')
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVU], [moTa]) VALUES (N'CV07', N'Bảo Vệ', N'')
GO
INSERT [dbo].[ChuongTrinhDaoTao] ([machuongTrinhDaoTao], [tenChuongTrinhDaoTao], [ghiChu], [coSoDaoTao]) VALUES (N'CTDT0001', N'Kỹ năng Lãnh đạo', N'', N'Đại Học Công Nghiệp TP.HCM')
GO
INSERT [dbo].[ChuongTrinhDaoTao] ([machuongTrinhDaoTao], [tenChuongTrinhDaoTao], [ghiChu], [coSoDaoTao]) VALUES (N'CTDT0002', N'Kỹ năng Quản lý', N'', N'Đại Học Công Nghiệp TP.HCM')
GO
INSERT [dbo].[ChuongTrinhDaoTao] ([machuongTrinhDaoTao], [tenChuongTrinhDaoTao], [ghiChu], [coSoDaoTao]) VALUES (N'CTDT0003', N'Kỹ năng Giao tiếp', NULL, N'Đại Học Công Nghiệp TP.HCM')
GO
INSERT [dbo].[ChuongTrinhDaoTao] ([machuongTrinhDaoTao], [tenChuongTrinhDaoTao], [ghiChu], [coSoDaoTao]) VALUES (N'CTDT0004', N'Kỹ năng Đàm phán', NULL, N'Đại Học Công Nghiệp TP.HCM')
GO
INSERT [dbo].[ChuongTrinhDaoTao] ([machuongTrinhDaoTao], [tenChuongTrinhDaoTao], [ghiChu], [coSoDaoTao]) VALUES (N'CTDT0005', N'Kỹ năng Tư vấn', NULL, N'Đại Học Công Nghiệp TP.HCM')
GO
INSERT [dbo].[ChuongTrinhKhuyenMai] ([MaCT], [TenCT], [NgayKhoiDong], [NgayKetThuc], [MoTa]) VALUES (N'CTKM0001', N'Ngày Thành Lập Hội Phụ Nữ Việt Nam', CAST(N'2016-10-15 00:00:00.000' AS DateTime), CAST(N'2016-10-25 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChuongTrinhKhuyenMai] ([MaCT], [TenCT], [NgayKhoiDong], [NgayKetThuc], [MoTa]) VALUES (N'CTKM0002', N'Ngày Hallowen', CAST(N'2016-10-26 00:00:00.000' AS DateTime), CAST(N'2016-10-30 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChuongTrinhKhuyenMai] ([MaCT], [TenCT], [NgayKhoiDong], [NgayKetThuc], [MoTa]) VALUES (N'CTKM0003', N'Ngày Nhà Giáo Việt Nam', CAST(N'2016-11-11 00:00:00.000' AS DateTime), CAST(N'2016-11-25 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChuongTrinhKhuyenMai] ([MaCT], [TenCT], [NgayKhoiDong], [NgayKetThuc], [MoTa]) VALUES (N'CTKM0004', N'Ngày Thế Giới Phòng Chống AIDS', CAST(N'2016-11-26 00:00:00.000' AS DateTime), CAST(N'2016-12-03 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChuongTrinhKhuyenMai] ([MaCT], [TenCT], [NgayKhoiDong], [NgayKetThuc], [MoTa]) VALUES (N'CTKM0005', N'Ngày Thành Lập Quân Đội Nhân Dân Việt Nam', CAST(N'2016-12-22 00:00:00.000' AS DateTime), CAST(N'2016-12-30 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[ChuongTrinhKhuyenMai] ([MaCT], [TenCT], [NgayKhoiDong], [NgayKetThuc], [MoTa]) VALUES (N'CTKM0006', N'Merry Christmas', CAST(N'2016-12-12 00:00:00.000' AS DateTime), CAST(N'2016-12-30 00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[CongNoKH] ([MaHoaDonBanSi], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'BS20160102_0001', 15697500.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoKH] ([MaHoaDonBanSi], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'BS20160102_0002', 6772500.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoKH] ([MaHoaDonBanSi], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'BS20160102_0003', 8347500.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoKH] ([MaHoaDonBanSi], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'BS20160201_0001', 2835000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoKH] ([MaHoaDonBanSi], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'BS20160301_0001', 218190000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoKH] ([MaHoaDonBanSi], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'BS20160401_0001', 337365000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoKH] ([MaHoaDonBanSi], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'BS20160501_0001', 6205500.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoNCC] ([MaHoaDonNCC], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'HDNCC001', 587000000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoNCC] ([MaHoaDonNCC], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'HDNCC002', 1000000000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoNCC] ([MaHoaDonNCC], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'HDNCC003', 1000000000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoNCC] ([MaHoaDonNCC], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'HDNCC004', 0.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoNCC] ([MaHoaDonNCC], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'HDNCC005', 2000000000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[CongNoNCC] ([MaHoaDonNCC], [SoTienNo], [GhiChu], [NgayDaoHan]) VALUES (N'HDNCC006', 1000000000.0000, NULL, CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[DanhMucCuaHang] ([MaCuaHang], [TenCuaHang], [DiaChi], [SoDienThoai], [TinhTrang]) VALUES (N'CH01', N'Cửa Hàng Quận Gò Vấp', N'Gò V?p', N'08222222', 1)
GO
INSERT [dbo].[DanhMucCuaHang] ([MaCuaHang], [TenCuaHang], [DiaChi], [SoDienThoai], [TinhTrang]) VALUES (N'CH02', N'Cửa Hàng Quận 2', N'Gò V?p', N'08222333', 1)
GO
INSERT [dbo].[DanhMucCuaHang] ([MaCuaHang], [TenCuaHang], [DiaChi], [SoDienThoai], [TinhTrang]) VALUES (N'CH03', N'Cửa Hàng Quận 1', N'Gò V?p', N'08222444', 1)
GO
INSERT [dbo].[DanhMucCuaHang] ([MaCuaHang], [TenCuaHang], [DiaChi], [SoDienThoai], [TinhTrang]) VALUES (N'CH04', N'Cửa Hàng Quận Bình Thạnh', N'Gò V?p', N'08222555', 1)
GO
INSERT [dbo].[DanhMucCuaHang] ([MaCuaHang], [TenCuaHang], [DiaChi], [SoDienThoai], [TinhTrang]) VALUES (N'CH05', N'Cửa Hàng Quận Tân Bình', N'Gò V?p', N'08222666', 1)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160102_0001', N'KH0001', N'NV0022', 7689000.0000, CAST(N'2016-01-02 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160102_0002', N'KH0002', N'NV0022', 6259000.0000, CAST(N'2016-01-02 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160102_0003', N'KH0003', N'NV0022', 1419000.0000, CAST(N'2016-01-02 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160201_0001', N'KH0004', N'NV0022', 15389000.0000, CAST(N'2016-02-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160201_0002', N'KH0005', N'NV0022', 20339000.0000, CAST(N'2016-02-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160201_0003', N'KH0006', N'NV0022', 15389000.0000, CAST(N'2016-02-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160301_0001', N'KH0007', N'NV0022', 3289000.0000, CAST(N'2016-03-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160301_0002', N'KH0008', N'NV0022', 1749000.0000, CAST(N'2016-03-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160301_0003', N'KH0009', N'NV0022', 30789000.0000, CAST(N'2016-03-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160401_0001', N'KH0001', N'NV0022', 15048000.0000, CAST(N'2016-04-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160501_0001', N'KH0002', N'NV0022', 30778000.0000, CAST(N'2016-05-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160601_0001', N'KH0003', N'NV0022', 20790000.0000, CAST(N'2016-06-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160701_0001', N'KH0004', N'NV0022', 30789000.0000, CAST(N'2016-07-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160801_0001', N'KH0005', N'NV0022', 99000.0000, CAST(N'2016-08-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20160901_0001', N'KH0006', N'NV0022', 41580000.0000, CAST(N'2016-09-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanHang] ([soHD], [maKH], [maNV], [tongTien], [ngayLap], [VAT]) VALUES (N'20161001_0001', N'KH0007', N'NV0022', 22440000.0000, CAST(N'2016-10-01 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[HoaDonBanSi] ([MaHoaDonBanSi], [MaKH], [NgayLap], [MaNhanVien], [MoTa], [TongTien], [soTienDatra]) VALUES (N'BS20160102_0001', N'KH0001', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'NV0022', NULL, 31395000.0000, 15697500.0000)
GO
INSERT [dbo].[HoaDonBanSi] ([MaHoaDonBanSi], [MaKH], [NgayLap], [MaNhanVien], [MoTa], [TongTien], [soTienDatra]) VALUES (N'BS20160102_0002', N'KH0002', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'NV0022', NULL, 13545000.0000, 6772500.0000)
GO
INSERT [dbo].[HoaDonBanSi] ([MaHoaDonBanSi], [MaKH], [NgayLap], [MaNhanVien], [MoTa], [TongTien], [soTienDatra]) VALUES (N'BS20160102_0003', N'KH0003', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'NV0022', NULL, 16695000.0000, 8347500.0000)
GO
INSERT [dbo].[HoaDonBanSi] ([MaHoaDonBanSi], [MaKH], [NgayLap], [MaNhanVien], [MoTa], [TongTien], [soTienDatra]) VALUES (N'BS20160201_0001', N'KH0001', CAST(N'2016-02-01 00:00:00.000' AS DateTime), N'NV0022', NULL, 2835000.0000, 0.0000)
GO
INSERT [dbo].[HoaDonBanSi] ([MaHoaDonBanSi], [MaKH], [NgayLap], [MaNhanVien], [MoTa], [TongTien], [soTienDatra]) VALUES (N'BS20160301_0001', N'KH0002', CAST(N'2016-03-01 00:00:00.000' AS DateTime), N'NV0022', NULL, 218190000.0000, 0.0000)
GO
INSERT [dbo].[HoaDonBanSi] ([MaHoaDonBanSi], [MaKH], [NgayLap], [MaNhanVien], [MoTa], [TongTien], [soTienDatra]) VALUES (N'BS20160401_0001', N'KH0003', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'NV0022', NULL, 337365000.0000, 0.0000)
GO
INSERT [dbo].[HoaDonBanSi] ([MaHoaDonBanSi], [MaKH], [NgayLap], [MaNhanVien], [MoTa], [TongTien], [soTienDatra]) VALUES (N'BS20160501_0001', N'KH0004', CAST(N'2016-05-01 00:00:00.000' AS DateTime), N'NV0022', NULL, 6205500.0000, 0.0000)
GO
INSERT [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien], [sotienDatra]) VALUES (N'HDNCC001', N'NCC01', NULL, CAST(N'2016-01-01 00:00:00.000' AS DateTime), 587000000.0000, 0.0000)
GO
INSERT [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien], [sotienDatra]) VALUES (N'HDNCC002', N'NCC02', NULL, CAST(N'2016-01-01 00:00:00.000' AS DateTime), 1908500000.0000, 908500000.0000)
GO
INSERT [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien], [sotienDatra]) VALUES (N'HDNCC003', N'NCC03', NULL, CAST(N'2016-01-01 00:00:00.000' AS DateTime), 1099400000.0000, 99400000.0000)
GO
INSERT [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien], [sotienDatra]) VALUES (N'HDNCC004', N'NCC04', NULL, CAST(N'2016-04-01 00:00:00.000' AS DateTime), 45000000.0000, 45000000.0000)
GO
INSERT [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien], [sotienDatra]) VALUES (N'HDNCC005', N'NCC02', NULL, CAST(N'2016-04-01 00:00:00.000' AS DateTime), 3719000000.0000, 1719000000.0000)
GO
INSERT [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien], [sotienDatra]) VALUES (N'HDNCC006', N'NCC07', NULL, CAST(N'2016-04-01 00:00:00.000' AS DateTime), 1427500000.0000, 427500000.0000)
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0001', N'TP.HCM', N'0984888999', N'Nam', N'Nguyễn Văn A', N'00000000001', N'Công Ty Số 1', N'TP.HCM', N'08666666', N'congtyso1@gmail.com', N'0000000001', N'Ngân Hàng Agribank', N'Chi Nhánh Số 01')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0002', N'TP.HCM', N'0984888999', N'Nam', N'Nguyễn Văn An', N'00000000002', N'Công Ty Số 1', N'TP.HCM', N'08666878', N'congtyso1@gmail.com', N'0000000002', N'Ngân Hàng Agribank', N'Chi Nhánh Số 01')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0003', N'TP.HCM', N'0984888999', N'Nam', N'Nguyễn Văn Anh', N'00000000003', N'Công Ty Số 1', N'TP.HCM', N'08666231', N'congtyso1@gmail.com', N'0000000003', N'Ngân Hàng Agribank', N'Chi Nhánh Số 01')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0004', N'TP.HCM', N'0984888999', N'Nam', N'Nguyễn Văn Ai', N'00000000004', N'Công Ty Số 1', N'TP.HCM', N'08666125', N'congtyso1@gmail.com', N'0000000004', N'Ngân Hàng Agribank', N'Chi Nhánh Số 01')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0005', N'TP.HCM', N'0984888999', N'Nam', N'Nguyễn Văn Ân', N'00000000005', N'Công Ty Số 1', N'TP.HCM', N'08666475', N'congtyso1@gmail.com', N'0000000005', N'Ngân Hàng Agribank', N'Chi Nhánh Số 01')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0006', N'TP.HCM', N'0984888544', N'Nam', N'Trần Hoàng B', N'00000000006', N'Công Ty Số 2', N'TP.HCM', N'08665456', N'congtyso2@gmail.com', N'0000000006', N'Ngân Hàng Vietcombank', N'Chi Nhánh Số 02')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0007', N'TP.HCM', N'0984888999', N'Nam', N'Trần Hoàng Ba', N'00000000007', N'Công Ty Số 2', N'TP.HCM', N'08665212', N'congtyso2@gmail.com', N'0000000007', N'Ngân Hàng Vietcombank', N'Chi Nhánh Số 02')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0008', N'TP.HCM', N'0984888548', N'Nam', N'Trần Hoàng Bốn', N'00000000008', N'Công Ty Số 2', N'TP.HCM', N'08665456', N'congtyso2@gmail.com', N'0000000008', N'Ngân Hàng Vietcombank', N'Chi Nhánh Số 02')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0009', N'TP.HCM', N'0984888021', N'Nam', N'Trần Hoàng Bang', N'00000000009', N'Công Ty Số 2', N'TP.HCM', N'08665578', N'congtyso2@gmail.com', N'0000000009', N'Ngân Hàng Vietcombank', N'Chi Nhánh Số 02')
GO
INSERT [dbo].[KhachHang] ([MaKH], [DiaChiKH], [SDTKH], [GioiTinh], [TenKH], [MaSoThue], [TenCongTy], [DiaChiCongTy], [SDTCongTy], [EmailCongTy], [SoTaiKhoanNH], [TenNH], [ChiNhanhNH]) VALUES (N'KH0010', N'TP.HCM', N'0984888665', N'Nam', N'Trần Hoàng Bãnh', N'000000000010', N'Công Ty Số 2', N'TP.HCM', N'08665456', N'congtyso2@gmail.com', N'00000000010', N'Ngân Hàng Vietcombank', N'Chi Nhánh Số 02')
GO
INSERT [dbo].[KyLuat] ([maKyLuat], [dieuKhoanKyLuat], [hinhThucKyLuat]) VALUES (N'KL01', N'khiển trách bằng miệng hoặc bằng văn bản được áp dụng đối với người lao động phạm lỗi lần đầu, nhưng ở mức độ nhẹ.', N'Hình thức khiển trách')
GO
INSERT [dbo].[KyLuat] ([maKyLuat], [dieuKhoanKyLuat], [hinhThucKyLuat]) VALUES (N'KL02', N'bị khiển trách bằng văn bản mà tái phạm trong thời hạn 03 tháng kể từ ngày bị khiển trách hoặc những hành vi vi phạm đó được quy định trong nội quy lao động.', N'Giảm bậc lương')
GO
INSERT [dbo].[KyLuat] ([maKyLuat], [dieuKhoanKyLuat], [hinhThucKyLuat]) VALUES (N'KL03', N'1. Người lao động có hành vi trộm cắp, tham ô, đánh bạc, cố ý gây thương tích, sử dụng ma tuý trong phạm vi nơi làm việc, tiết lộ bí mật kinh doanh, bí mật công nghệ, xâm phạm quyền sở hữu trí tuệ của người sử dụng lao động, có hành vi gây thiệt hại nghiêm trọng hoặc đe doạ gây thiệt hại đặc biệt nghiêm trọng về tài sản, lợi ích của người sử dụng lao động;
 
2. Người lao động bị xử lý kỷ luật kéo dài thời hạn nâng lương mà tái phạm trong thời gian chưa xoá kỷ luật hoặc bị xử lý kỷ luật cách chức mà tái phạm.Tái phạm là trường hợp người lao động lặp lại hành vi vi phạm đã bị xử lý kỷ luật mà chưa được xóa kỷ luật theo quy định tại Điều 127 của Bộ luật này;
 
3. Người lao động tự ý bỏ việc 05 ngày cộng dồn trong 01 tháng hoặc 20 ngày cộng dồn trong 01 năm mà không có lý do chính đáng.', N'Hình thức sa thải.')
GO
INSERT [dbo].[LichLamViec] ([maLich], [caLamViec], [gioLam], [gioKetThuc], [ghiChu]) VALUES (N'ML01', N'Ca Sang', CAST(N'07:30:00' AS Time), CAST(N'11:30:00' AS Time), N'')
GO
INSERT [dbo].[LichLamViec] ([maLich], [caLamViec], [gioLam], [gioKetThuc], [ghiChu]) VALUES (N'ML02', N'Ca Chieu', CAST(N'01:30:00' AS Time), CAST(N'05:30:00' AS Time), N'')
GO
INSERT [dbo].[LichLamViec] ([maLich], [caLamViec], [gioLam], [gioKetThuc], [ghiChu]) VALUES (N'ML03', N'Ca Toi', CAST(N'06:00:00' AS Time), CAST(N'10:00:00' AS Time), N'')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0001', N'PB01', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV03')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0002', N'PB02', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV03')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0003', N'PB03', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV03')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0004', N'PB04', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV03')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0005', N'PB05', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV03')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0006', N'PB01', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV04')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0007', N'PB02', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV04')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0008', N'PB03', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV04')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0009', N'PB04', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV04')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0010', N'PB05', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV04')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0011', N'PB01', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0012', N'PB01', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0013', N'PB01', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0014', N'PB01', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0015', N'PB01', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0016', N'PB02', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0017', N'PB02', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0018', N'PB02', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0019', N'PB02', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0020', N'PB02', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0021', N'PB03', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0022', N'PB03', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0023', N'PB03', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0024', N'PB03', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0025', N'PB03', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0026', N'PB04', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0027', N'PB04', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0028', N'PB04', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0029', N'PB04', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0030', N'PB04', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0031', N'PB05', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0032', N'PB05', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0033', N'PB05', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0034', N'PB05', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LichSuLamViec] ([maNhanVien], [maPhongBan], [ngayBatDauLamViec], [ngayKetThuc], [maChucVu]) VALUES (N'NV0035', N'PB05', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-12-12 00:00:00.000' AS DateTime), N'CV05')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [Mota], [Style]) VALUES (N'LSP01', N'Điện Thoại', N'', N'')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [Mota], [Style]) VALUES (N'LSP02', N'Tablet', N'', N'')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [Mota], [Style]) VALUES (N'LSP03', N'Mì', N'', N'')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [Mota], [Style]) VALUES (N'LSP04', N'Tivi', N'', N'')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [Mota], [Style]) VALUES (N'LSP05', N'Máy Lạnh', N'', N'')
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [Phone], [NgayThanhLap]) VALUES (N'NCC01', N'Nokia', N'TP.HCM', 8333888, NULL)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [Phone], [NgayThanhLap]) VALUES (N'NCC02', N'SamSung', N'TP.HCM', 833222555, NULL)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [Phone], [NgayThanhLap]) VALUES (N'NCC03', N'Apple', N'TP.HCM', 12345678, NULL)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [Phone], [NgayThanhLap]) VALUES (N'NCC04', N'Acecook', N'TP.HCM', 83124523, NULL)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [Phone], [NgayThanhLap]) VALUES (N'NCC05', N'Vinamilk', N'TP.HCM', 8365252, NULL)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [Phone], [NgayThanhLap]) VALUES (N'NCC06', N'Kangaroo', N'TP.HCM', 83562564, NULL)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [Phone], [NgayThanhLap]) VALUES (N'NCC07', N'Toshiba', N'TP.HCM', 83124584, NULL)
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0001', N'Phan Công Anh', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000001', N'01649000001', N'Cà Mau', N'conganh@gmail.com', N'300000001', N'Tp.hcm', N'Nam', CAST(N'1996-01-01' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0002', N'Phan Công An', CAST(N'2016-01-01' AS Date), N'Nghi Viec', N'300000000002', N'01649000002', N'Cà Mau', N'congan@gmail.com', N'300000002', N'Tp.hcm', N'Nam', CAST(N'1996-09-09' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0003', N'Võ Ngọc Hào', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000003', N'01649000003', N'Đồng Tháp', N'ngochao123@gmail.com', N'300000003', N'Tp.hcm', N'Nam', CAST(N'1996-08-01' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0004', N'Võ Ngọc Hào Hào', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000004', N'01649000004', N'Đồng Tháp', N'ngocanh123456@gmail.com', N'300000004', N'Tp.hcm', N'Nam', CAST(N'1996-07-07' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0005', N'Vũ Đình Hiệp', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000005', N'01649000005', N'Đắk Lắk', N'dinhhiep@gmail.com', N'300000005', N'Tp.hcm', N'Nam', CAST(N'1996-09-01' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0006', N'Vũ Đình Hiệp Hiệp', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000006', N'01649000006', N'Đắk Lắk', N'dinhhiep123@gmail.com', N'300000006', N'Tp.hcm', N'Nam', CAST(N'1996-03-10' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0007', N'Đào Ngọc Anh Hòa', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000007', N'01649000007', N'Long An', N'anhhoa@gmail.com', N'300000007', N'Tp.hcm', N'Nam', CAST(N'1996-02-02' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0008', N'Đào Ngọc Anh Hòa Hòa', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000008', N'01649000008', N'Long An', N'anhhoa123@gmail.com', N'300000008', N'Tp.hcm', N'Nam', CAST(N'1996-11-09' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0009', N'Phan Mạnh Lâm', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000009', N'01649000009', N'Trà Vinh', N'manhlam@gmail.com', N'300000009', N'Tp.hcm', N'Nam', CAST(N'1996-12-11' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0010', N'Phan Mạnh Lâm Lâm', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000010', N'01649000010', N'Trà Vinh', N'manhlam123@gmail.com', N'300000010', N'Tp.hcm', N'Nam', CAST(N'1996-10-12' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0011', N'Đào Bình Minh', CAST(N'2016-01-01' AS Date), N'Nghi Viec', N'300000000011', N'01649000011', N'Bảo Lộc', N'binhminh@gmail.com', N'300000011', N'Tp.hcm', N'Nam', CAST(N'1996-10-06' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0012', N'Đào Bình Minh', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000012', N'01649000012', N'Bảo Lộc', N'binhminh@gmail.com', N'300000012', N'Tp.hcm', N'Nam', CAST(N'1996-06-06' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0013', N'Lê Tất Thạnh', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000013', N'01649000013', N'Bình Thuận', N'tatthanh@gmail.com', N'300000013', N'Tp.hcm', N'Nam', CAST(N'1996-08-07' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0014', N'Lê Tất Thạnh Thạnh', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000014', N'01649000014', N'Bình Thuận', N'tatthanh123@gmail.com', N'300000014', N'Tp.hcm', N'Nam', CAST(N'1996-04-01' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0015', N'Lương Gia Thuận', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000015', N'01649000015', N'Bình Thuận', N'giathuan@gmail.com', N'300000015', N'Tp.hcm', N'Nam', CAST(N'1996-04-06' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0016', N'Lương Gia Thuận Thuận', CAST(N'2016-01-01' AS Date), N'Nghi Viec', N'300000000016', N'01649000016', N'Bình Thuận', N'giathuan123@gmail.com', N'300000016', N'Tp.hcm', N'Nam', CAST(N'1996-12-12' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0017', N'Tôn Đức Hoàng', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000017', N'01649000017', N'TP.hcm', N'duchoang@gmail.com', N'300000017', N'Tp.hcm', N'Nam', CAST(N'1996-08-08' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0018', N'Tôn Đức Hoàng Hoàng', CAST(N'2016-01-01' AS Date), N'Nghi Viec', N'300000000018', N'01649000018', N'TP.hcm', N'duchoang123@gmail.com', N'300000018', N'Tp.hcm', N'Nam', CAST(N'1996-05-05' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0019', N'Hoàng Đức Nguyên Kỷ', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000019', N'01649000019', N'TP.hcm', N'nguyenky@gmail.com', N'300000019', N'Tp.hcm', N'Nam', CAST(N'1996-04-07' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0020', N'Hoàng Đức Nguyên Kỷ Kỷ', CAST(N'2016-01-01' AS Date), N'Nghi Viec', N'300000000020', N'01649000020', N'TP.hcm', N'nguyenky123@gmail.com', N'300000020', N'Tp.hcm', N'Nam', CAST(N'1996-10-01' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0021', N'Nguyễn Ngọc Hóa', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000021', N'01649000021', N'Bình Thuận', N'ngochoa@gmail.com', N'300000021', N'Tp.hcm', N'Nam', CAST(N'1996-04-01' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0022', N'Vũ Đình Ân', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000022', N'01649000022', N'Tp.hcm', N'dinhan@gmail.com', N'300000022', N'Tp.hcm', N'Nam', CAST(N'1996-06-04' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0023', N'Lê Nhật Văn', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000023', N'01649000023', N'Đà Nẵng', N'nhatvan@gmail.com', N'300000001', N'Tp.hcm', N'Nam', CAST(N'1996-08-24' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0024', N'Lê Nhật Văn Văn', CAST(N'2016-05-01' AS Date), N'Nghi Viec', N'300000000024', N'01649000024', N'Đà Nẵng', N'nhatvan@gmail.com', N'300000024', N'Tp.hcm', N'Nam', CAST(N'1996-09-09' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0025', N'Nguyễn Ngọc Khánh', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000035', N'01649000035', N'TP.hcm', N'ngockhanh@gmail.com', N'300000035', N'Tp.hcm', N'Nam', CAST(N'1996-08-01' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0026', N'Hồ Huê Hào', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000025', N'01649000025', N'TP.hcm', N'huehao@gmail.com', N'300000025', N'Tp.hcm', N'Nam', CAST(N'1996-08-07' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0027', N'Hồ Huê Hào Hào', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000026', N'01649000026', N'TP.hcm', N'huehao123@gmail.com', N'300000026', N'Tp.hcm', N'Nam', CAST(N'1996-09-24' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0028', N'Châu Minh Tuấn', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000027', N'01649000027', N'Long Thành', N'minhtuan@gmail.com', N'300000027', N'Tp.hcm', N'Nam', CAST(N'1996-03-10' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0029', N'Châu Minh Tuấn Tuấn', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000028', N'01649000028', N'Long Thành', N'minhtuan123@gmail.com', N'300000028', N'Tp.hcm', N'Nam', CAST(N'1996-02-02' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0030', N'Võ Hiếu Tài', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000029', N'01649000029', N'TP.hcm', N'hieutai@gmail.com', N'300000029', N'Tp.hcm', N'Nam', CAST(N'1996-11-09' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0031', N'Võ Hiếu Tài Tài', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000030', N'01649000030', N'TP.hcm', N'hieutai123@gmail.com', N'300000030', N'Tp.hcm', N'Nam', CAST(N'1996-12-11' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0032', N'Nguyễn Thài Thành Đạt', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000031', N'01649000031', N'TP.hcm', N'thanhdat@gmail.com', N'300000031', N'Tp.hcm', N'Nam', CAST(N'1996-10-12' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0033', N'Nguyễn Thái Thành Đạt Đạt', CAST(N'2016-01-01' AS Date), N'Nghi Viec', N'300000000032', N'01649000032', N'TP.hcm', N'thanhdat123@gmail.com', N'300000032', N'Tp.hcm', N'Nam', CAST(N'1996-10-06' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0034', N'Nguyễn Khôi Khoa', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000033', N'01649000033', N'Vũng Tàu', N'khoikhoa@gmail.com', N'300000033', N'Tp.hcm', N'Nam', CAST(N'1996-06-06' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [hoTenNhanVien], [ngayBatDauLamViec], [tinhTrang], [soTKNganHang], [soDT], [queQuan], [Email], [soCMND], [diaChi], [gioiTinh], [ngaySinh]) VALUES (N'NV0035', N'Nguyễn Khôi Khoa', CAST(N'2016-01-01' AS Date), N'Dang Lam', N'300000000034', N'01649000034', N'Vũng Tàu', N'khoikhoa123@gmail.com', N'300000034', N'Tp.hcm', N'Nam', CAST(N'1996-08-07' AS Date))
GO
INSERT [dbo].[PhieuDNNK] ([MaPhieuDNNK], [NgayLap], [MaNhanVien], [MoTa], [MaKho], [tinhtrang], [MaHoaDonNCC]) VALUES (N'PDNNK001', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'NV0001', NULL, N'MK01', 1, N'HDNCC001')
GO
INSERT [dbo].[PhieuDNNK] ([MaPhieuDNNK], [NgayLap], [MaNhanVien], [MoTa], [MaKho], [tinhtrang], [MaHoaDonNCC]) VALUES (N'PDNNK002', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'NV0001', NULL, N'MK01', 1, N'HDNCC002')
GO
INSERT [dbo].[PhieuDNNK] ([MaPhieuDNNK], [NgayLap], [MaNhanVien], [MoTa], [MaKho], [tinhtrang], [MaHoaDonNCC]) VALUES (N'PDNNK003', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'NV0001', NULL, N'MK01', 1, N'HDNCC003')
GO
INSERT [dbo].[PhieuDNNK] ([MaPhieuDNNK], [NgayLap], [MaNhanVien], [MoTa], [MaKho], [tinhtrang], [MaHoaDonNCC]) VALUES (N'PDNNK004', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'NV0001', NULL, N'MK01', 1, N'HDNCC004')
GO
INSERT [dbo].[PhieuDNNK] ([MaPhieuDNNK], [NgayLap], [MaNhanVien], [MoTa], [MaKho], [tinhtrang], [MaHoaDonNCC]) VALUES (N'PDNNK005', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'NV0001', NULL, N'MK01', 1, N'HDNCC005')
GO
INSERT [dbo].[PhieuDNNK] ([MaPhieuDNNK], [NgayLap], [MaNhanVien], [MoTa], [MaKho], [tinhtrang], [MaHoaDonNCC]) VALUES (N'PDNNK006', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'NV0001', NULL, N'MK01', 1, N'HDNCC006')
GO
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang], [MaHoaDonBanSi], [MaCuaHang]) VALUES (N'PDNXK0001', N'NV0001', N'KH0001', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'MK01', 1, N'BS20160102_0001', NULL)
GO
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang], [MaHoaDonBanSi], [MaCuaHang]) VALUES (N'PDNXK0002', N'NV0001', N'KH0002', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'MK01', 1, N'BS20160102_0002', NULL)
GO
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang], [MaHoaDonBanSi], [MaCuaHang]) VALUES (N'PDNXK0003', N'NV0001', N'KH0003', CAST(N'2016-01-02 00:00:00.000' AS DateTime), N'MK01', 1, N'BS20160102_0003', NULL)
GO
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang], [MaHoaDonBanSi], [MaCuaHang]) VALUES (N'PDNXK0004', N'NV0001', N'KH0001', CAST(N'2016-02-01 00:00:00.000' AS DateTime), N'MK01', 1, N'BS20160201_0001', NULL)
GO
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang], [MaHoaDonBanSi], [MaCuaHang]) VALUES (N'PDNXK0005', N'NV0001', N'KH0002', CAST(N'2016-03-01 00:00:00.000' AS DateTime), N'MK01', 1, N'BS20160301_0001', NULL)
GO
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang], [MaHoaDonBanSi], [MaCuaHang]) VALUES (N'PDNXK0006', N'NV0001', N'KH0003', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'MK01', 1, N'BS20160401_0001', NULL)
GO
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang], [MaHoaDonBanSi], [MaCuaHang]) VALUES (N'PDNXK0007', N'NV0001', N'KH0004', CAST(N'2016-05-01 00:00:00.000' AS DateTime), N'MK01', 1, N'BS20160501_0001', NULL)
GO
INSERT [dbo].[PhieuNhapKho] ([sopnk], [manhanvien], [ngaylap], [makho]) VALUES (N'PDNNK001', N'NV0027', CAST(N'2016-01-01' AS Date), N'MK01')
GO
INSERT [dbo].[PhieuNhapKho] ([sopnk], [manhanvien], [ngaylap], [makho]) VALUES (N'PDNNK002', N'NV0027', CAST(N'2016-01-01' AS Date), N'MK01')
GO
INSERT [dbo].[PhieuNhapKho] ([sopnk], [manhanvien], [ngaylap], [makho]) VALUES (N'PDNNK003', N'NV0027', CAST(N'2016-01-01' AS Date), N'MK01')
GO
INSERT [dbo].[PhieuNhapKho] ([sopnk], [manhanvien], [ngaylap], [makho]) VALUES (N'PDNNK004', N'NV0027', CAST(N'2016-04-01' AS Date), N'MK01')
GO
INSERT [dbo].[PhieuNhapKho] ([sopnk], [manhanvien], [ngaylap], [makho]) VALUES (N'PDNNK005', N'NV0027', CAST(N'2016-04-01' AS Date), N'MK01')
GO
INSERT [dbo].[PhieuNhapKho] ([sopnk], [manhanvien], [ngaylap], [makho]) VALUES (N'PDNNK006', N'NV0027', CAST(N'2016-04-01' AS Date), N'MK01')
GO
INSERT [dbo].[PhieuXuatKho] ([soPXK], [manhanvien], [ngaylap], [makho], [ghiChu]) VALUES (N'PDNXK0001', N'NV0027', CAST(N'2016-01-02' AS Date), N'MK01', NULL)
GO
INSERT [dbo].[PhieuXuatKho] ([soPXK], [manhanvien], [ngaylap], [makho], [ghiChu]) VALUES (N'PDNXK0002', N'NV0027', CAST(N'2016-01-02' AS Date), N'MK01', NULL)
GO
INSERT [dbo].[PhieuXuatKho] ([soPXK], [manhanvien], [ngaylap], [makho], [ghiChu]) VALUES (N'PDNXK0003', N'NV0027', CAST(N'2016-01-02' AS Date), N'MK01', NULL)
GO
INSERT [dbo].[PhongBan] ([maPhongBan], [tenPhongBan], [khuVuc]) VALUES (N'PB01', N'Phòng Kế Hoạch', N'Lau 01')
GO
INSERT [dbo].[PhongBan] ([maPhongBan], [tenPhongBan], [khuVuc]) VALUES (N'PB02', N'Phòng Nhân Sự', N'Lau 02')
GO
INSERT [dbo].[PhongBan] ([maPhongBan], [tenPhongBan], [khuVuc]) VALUES (N'PB03', N'Phòng Bán Hàng', N'Lau 03')
GO
INSERT [dbo].[PhongBan] ([maPhongBan], [tenPhongBan], [khuVuc]) VALUES (N'PB04', N'Phòng Quản Lý Kho', N'Lau 04')
GO
INSERT [dbo].[PhongBan] ([maPhongBan], [tenPhongBan], [khuVuc]) VALUES (N'PB05', N'Phòng Quản Lý Công Nợ', N'Lau 05')
GO
INSERT [dbo].[PhuongThucThanhToan] ([maPhuongThuc], [tenPhuongThuc], [moTa]) VALUES (N'PTTT01', N'Tiền Mặt', N'')
GO
INSERT [dbo].[PhuongThucThanhToan] ([maPhuongThuc], [tenPhuongThuc], [moTa]) VALUES (N'PTTT02', N'Thẻ ATM', N'Dùng bất kỳ Thẻ ATM nào')
GO
INSERT [dbo].[QuanLyKho] ([maKho], [manhanvien], [chucVu], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (N'MK01', N'NV0004', N'CV03', CAST(N'2016-01-01' AS Date), CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[QuanLyKho] ([maKho], [manhanvien], [chucVu], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (N'MK02', N'NV0009', N'CV04', CAST(N'2016-01-01' AS Date), CAST(N'2016-12-12' AS Date))
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'DeNhat', N'Mì Đệ Nhất', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'Gói', NULL, NULL, NULL, N'LSP03', NULL, CAST(N'2016-12-31' AS Date))
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'H10BKCV', N'Máy Lạnh Toshiba H10BKCV', CAST(N'2016-04-01 00:00:00.000' AS DateTime), NULL, NULL, N'Trắng', NULL, N'LSP05', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'H10S3KS', N'Máy Lạnh Toshiba H10S3KS', CAST(N'2016-04-01 00:00:00.000' AS DateTime), NULL, NULL, N'Trắng', NULL, N'LSP05', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'H13BKCV', N'Máy Lạnh Toshiba H13BKCV', CAST(N'2016-04-01 00:00:00.000' AS DateTime), NULL, NULL, N'Trắng', NULL, N'LSP05', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'HaoHao', N'Mì Hảo Hảo Tôm Chua Cay', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'Gói', NULL, NULL, NULL, N'LSP03', NULL, CAST(N'2016-12-31' AS Date))
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'HaoHao100', N'Mì Hảo Hảo 100', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'Gói', NULL, NULL, NULL, N'LSP03', NULL, CAST(N'2016-12-31' AS Date))
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'Iphone5s_16', N'Iphone 5s 16GB', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Đen', 112, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'Iphone6s_16', N'Iphone 6s Plus 16GB', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Hồng', 192, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'Iphone7_256', N'Iphone 7 Plus 256GB', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Xám', 188, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'LauThai', N'Mì Lẩu Thái', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'Gói', NULL, NULL, NULL, N'LSP03', NULL, CAST(N'2016-12-31' AS Date))
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'No225', N'Dien Thoai Nokia 225', CAST(N'2016-01-01 00:00:00.000' AS DateTime), N'', NULL, N'Cam', 134, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'No630', N'Dien Thoai Nokia 630', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Đen', 134, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'No730', N'Dien Thoai Nokia 730', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Đỏ', 100.6, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'SamsungA3', N'SamSung Galaxy A3 2016', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Trắng', 157, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'SamSungNote5', N'SamSung Galaxy Note5', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Xanh Đen', 171, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'SamSungS7', N'SamSung Galaxy S7', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, NULL, N'Xanh Đen', 157, N'LSP01', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'UA32K5300', N'Smart Tivi Samsung 32 inch UA32K5300', CAST(N'2016-04-01 00:00:00.000' AS DateTime), NULL, NULL, N'Đen', NULL, N'LSP04', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'UA43K5310', N'Smart Tivi Samsung 43 inch UA43K5310', CAST(N'2016-04-01 00:00:00.000' AS DateTime), NULL, NULL, N'Đen', NULL, N'LSP04', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'UA55K5300', N'Smart Tivi Samsung 55 inch UA55K5300', CAST(N'2016-04-01 00:00:00.000' AS DateTime), NULL, NULL, N'Đen', NULL, N'LSP04', NULL, NULL)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [NgaySanXuat], [DonViTinh], [KieuDang], [MauSac], [TrongLuong], [MaLoaiSanPham], [Mota], [NgayHetHan]) VALUES (N'Udon', N'Mì Udon', CAST(N'2016-04-01 00:00:00.000' AS DateTime), N'Gói', NULL, NULL, NULL, N'LSP03', NULL, CAST(N'2016-12-31' AS Date))
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160102_0001', 7689000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160102_0002', 6259000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160102_0003', 1419000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160201_0001', 15389000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160201_0002', 20339000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160201_0003', 15389000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160301_0001', 3289000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160301_0002', 1749000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160301_0003', 30789000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160401_0001', 15048000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160501_0001', 30778000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160601_0001', 20790000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160701_0001', 30789000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160801_0001', 99000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20160901_0001', 41580000.0000, N'PTTT01')
GO
INSERT [dbo].[ThanhToan] ([soHD], [tien], [maPhuongThuc]) VALUES (N'20161001_0001', 22440000.0000, N'PTTT01')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0001', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0001')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0002', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0002')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0003', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0003')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0004', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0004')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0005', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0005')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0006', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0006')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0007', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0007')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0008', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0008')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0009', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0009')
GO
INSERT [dbo].[TheThanhVien] ([MaThe], [NgayCapThe], [SoDiem], [MaKH]) VALUES (N'TTV0010', CAST(N'2016-10-22 00:00:00.000' AS DateTime), 0, N'KH0010')
GO
INSERT [dbo].[ThongTinKho] ([maKho], [tenKho], [diaChi], [soDienThoai]) VALUES (N'MK01', N'Kho số 01', N'Quận Gò Vấp,TP.hcm', N'0723888888')
GO
INSERT [dbo].[ThongTinKho] ([maKho], [tenKho], [diaChi], [soDienThoai]) VALUES (N'MK02', N'Kho số 02', N'Quận 12,TP.hcm', N'0723888889')
GO
ALTER TABLE [dbo].[BangGiaBanSi]  WITH CHECK ADD  CONSTRAINT [FK_BangGiaBanSi_SanPham] FOREIGN KEY([maSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[BangGiaBanSi] CHECK CONSTRAINT [FK_BangGiaBanSi_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBanHang_BangGiaBan] FOREIGN KEY([maSP])
REFERENCES [dbo].[BangGiaBan] ([maSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [FK_ChiTietHoaDonBanHang_BangGiaBan]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBanHang_HoaDonBanHang] FOREIGN KEY([soHD])
REFERENCES [dbo].[HoaDonBanHang] ([soHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [FK_ChiTietHoaDonBanHang_HoaDonBanHang]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanSi]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBanSi_HoaDonBanSi] FOREIGN KEY([MaHoaDonBanSi])
REFERENCES [dbo].[HoaDonBanSi] ([MaHoaDonBanSi])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanSi] CHECK CONSTRAINT [FK_ChiTietHoaDonBanSi_HoaDonBanSi]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanSi]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBanSi_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanSi] CHECK CONSTRAINT [FK_ChiTietHoaDonBanSi_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhaCungCap_HoaDonNhaCungCap] FOREIGN KEY([MaHoaDonNhaCungCap])
REFERENCES [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhaCungCap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhaCungCap_HoaDonNhaCungCap]
GO
ALTER TABLE [dbo].[ChiTietKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKho_SanPham] FOREIGN KEY([maSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietKho] CHECK CONSTRAINT [FK_ChiTietKho_SanPham]
GO
ALTER TABLE [dbo].[ChiTietKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKho_ThongTinKho] FOREIGN KEY([maKho])
REFERENCES [dbo].[ThongTinKho] ([maKho])
GO
ALTER TABLE [dbo].[ChiTietKho] CHECK CONSTRAINT [FK_ChiTietKho_ThongTinKho]
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKhuyenMai_ChuongTrinhKhuyenMai] FOREIGN KEY([MaCT])
REFERENCES [dbo].[ChuongTrinhKhuyenMai] ([MaCT])
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai] CHECK CONSTRAINT [FK_ChiTietKhuyenMai_ChuongTrinhKhuyenMai]
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKhuyenMai_SanPham] FOREIGN KEY([MaSp])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai] CHECK CONSTRAINT [FK_ChiTietKhuyenMai_SanPham]
GO
ALTER TABLE [dbo].[ChiTietKyLuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKyLuat_KyLuat] FOREIGN KEY([maKyLuat])
REFERENCES [dbo].[KyLuat] ([maKyLuat])
GO
ALTER TABLE [dbo].[ChiTietKyLuat] CHECK CONSTRAINT [FK_ChiTietKyLuat_KyLuat]
GO
ALTER TABLE [dbo].[ChiTietKyLuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKyLuat_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietKyLuat] CHECK CONSTRAINT [FK_ChiTietKyLuat_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietLich]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLich_LichLamViec] FOREIGN KEY([maLich])
REFERENCES [dbo].[LichLamViec] ([maLich])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietLich] CHECK CONSTRAINT [FK_ChiTietLich_LichLamViec]
GO
ALTER TABLE [dbo].[ChiTietLich]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLich_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietLich] CHECK CONSTRAINT [FK_ChiTietLich_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietPhieuDNNK]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDNNK_PhieuDNNK] FOREIGN KEY([MaPhieuDNNK])
REFERENCES [dbo].[PhieuDNNK] ([MaPhieuDNNK])
GO
ALTER TABLE [dbo].[ChiTietPhieuDNNK] CHECK CONSTRAINT [FK_ChiTietPhieuDNNK_PhieuDNNK]
GO
ALTER TABLE [dbo].[ChiTietPhieuDNNK]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDNNK_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuDNNK] CHECK CONSTRAINT [FK_ChiTietPhieuDNNK_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuDNXK]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDNXK_PhieuDNXK] FOREIGN KEY([MaPhieuDNXK])
REFERENCES [dbo].[PhieuDNXK] ([MaPhieuDNXK])
GO
ALTER TABLE [dbo].[ChiTietPhieuDNXK] CHECK CONSTRAINT [FK_ChiTietPhieuDNXK_PhieuDNXK]
GO
ALTER TABLE [dbo].[ChiTietPhieuDNXK]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDNXK_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuDNXK] CHECK CONSTRAINT [FK_ChiTietPhieuDNXK_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTraNoKhachHang_CongNoKH] FOREIGN KEY([MaHoaDonBanSi])
REFERENCES [dbo].[CongNoKH] ([MaHoaDonBanSi])
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoKhachHang] CHECK CONSTRAINT [FK_ChiTietPhieuTraNoKhachHang_CongNoKH]
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTraNoKhachHang_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoKhachHang] CHECK CONSTRAINT [FK_ChiTietPhieuTraNoKhachHang_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoNCC]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTraNoNCC_CongNoNCC] FOREIGN KEY([MaHoaDonNCC])
REFERENCES [dbo].[CongNoNCC] ([MaHoaDonNCC])
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoNCC] CHECK CONSTRAINT [FK_ChiTietPhieuTraNoNCC_CongNoNCC]
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoNCC]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTraNoNCC_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[ChiTietPhieuTraNoNCC] CHECK CONSTRAINT [FK_ChiTietPhieuTraNoNCC_NhanVien]
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_KhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_NhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonBanSi]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanSi_CongNoKH] FOREIGN KEY([MaHoaDonBanSi])
REFERENCES [dbo].[CongNoKH] ([MaHoaDonBanSi])
GO
ALTER TABLE [dbo].[HoaDonBanSi] CHECK CONSTRAINT [FK_HoaDonBanSi_CongNoKH]
GO
ALTER TABLE [dbo].[HoaDonBanSi]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanSi_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanSi] CHECK CONSTRAINT [FK_HoaDonBanSi_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhaCungCap_CongNoNCC] FOREIGN KEY([MaHoaDonNCC])
REFERENCES [dbo].[CongNoNCC] ([MaHoaDonNCC])
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap] CHECK CONSTRAINT [FK_HoaDonNhaCungCap_CongNoNCC]
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhaCungCap_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap] CHECK CONSTRAINT [FK_HoaDonNhaCungCap_NhaCungCap]
GO
ALTER TABLE [dbo].[LichSuLamViec]  WITH CHECK ADD  CONSTRAINT [FK_HistoryLvUp_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LichSuLamViec] CHECK CONSTRAINT [FK_HistoryLvUp_NhanVien]
GO
ALTER TABLE [dbo].[LichSuLamViec]  WITH CHECK ADD  CONSTRAINT [FK_lichSuLamViec_ChucVu] FOREIGN KEY([maChucVu])
REFERENCES [dbo].[ChucVu] ([maChucVu])
GO
ALTER TABLE [dbo].[LichSuLamViec] CHECK CONSTRAINT [FK_lichSuLamViec_ChucVu]
GO
ALTER TABLE [dbo].[LichSuLamViec]  WITH CHECK ADD  CONSTRAINT [FK_lichSuLamViec_PhongBan] FOREIGN KEY([maPhongBan])
REFERENCES [dbo].[PhongBan] ([maPhongBan])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LichSuLamViec] CHECK CONSTRAINT [FK_lichSuLamViec_PhongBan]
GO
ALTER TABLE [dbo].[PhieuDNNK]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDNNK_HoaDonNhaCungCap] FOREIGN KEY([MaHoaDonNCC])
REFERENCES [dbo].[HoaDonNhaCungCap] ([MaHoaDonNCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDNNK] CHECK CONSTRAINT [FK_PhieuDNNK_HoaDonNhaCungCap]
GO
ALTER TABLE [dbo].[PhieuDNXK]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDNXK_DanhMucCuaHang] FOREIGN KEY([MaCuaHang])
REFERENCES [dbo].[DanhMucCuaHang] ([MaCuaHang])
GO
ALTER TABLE [dbo].[PhieuDNXK] CHECK CONSTRAINT [FK_PhieuDNXK_DanhMucCuaHang]
GO
ALTER TABLE [dbo].[PhieuDNXK]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDNXK_HoaDonBanSi] FOREIGN KEY([MaHoaDonBanSi])
REFERENCES [dbo].[HoaDonBanSi] ([MaHoaDonBanSi])
GO
ALTER TABLE [dbo].[PhieuDNXK] CHECK CONSTRAINT [FK_PhieuDNXK_HoaDonBanSi]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_NhanVien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_PhieuDNNK] FOREIGN KEY([sopnk])
REFERENCES [dbo].[PhieuDNNK] ([MaPhieuDNNK])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_PhieuDNNK]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_ThongTinKho] FOREIGN KEY([makho])
REFERENCES [dbo].[ThongTinKho] ([maKho])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_ThongTinKho]
GO
ALTER TABLE [dbo].[PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_NhanVien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_PhieuDNXK] FOREIGN KEY([soPXK])
REFERENCES [dbo].[PhieuDNXK] ([MaPhieuDNXK])
GO
ALTER TABLE [dbo].[PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_PhieuDNXK]
GO
ALTER TABLE [dbo].[PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_ThongTinKho] FOREIGN KEY([makho])
REFERENCES [dbo].[ThongTinKho] ([maKho])
GO
ALTER TABLE [dbo].[PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_ThongTinKho]
GO
ALTER TABLE [dbo].[QuanLyKho]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyKho_NhanVien1] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[QuanLyKho] CHECK CONSTRAINT [FK_QuanLyKho_NhanVien1]
GO
ALTER TABLE [dbo].[QuanLyKho]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyKho_ThongTinKho] FOREIGN KEY([maKho])
REFERENCES [dbo].[ThongTinKho] ([maKho])
GO
ALTER TABLE [dbo].[QuanLyKho] CHECK CONSTRAINT [FK_QuanLyKho_ThongTinKho]
GO
ALTER TABLE [dbo].[QuaTrinhDaoTao]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhDaoTao_ChuongTrinhDaoTao] FOREIGN KEY([maChuongTrinhDaoTao])
REFERENCES [dbo].[ChuongTrinhDaoTao] ([machuongTrinhDaoTao])
GO
ALTER TABLE [dbo].[QuaTrinhDaoTao] CHECK CONSTRAINT [FK_QuaTrinhDaoTao_ChuongTrinhDaoTao]
GO
ALTER TABLE [dbo].[QuaTrinhDaoTao]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhHoc_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[QuaTrinhDaoTao] CHECK CONSTRAINT [FK_QuaTrinhHoc_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH NOCHECK ADD  CONSTRAINT [FK_SanPham_BangGiaBan1] FOREIGN KEY([MaSP])
REFERENCES [dbo].[BangGiaBan] ([maSP])
GO
ALTER TABLE [dbo].[SanPham] NOCHECK CONSTRAINT [FK_SanPham_BangGiaBan1]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_HoaDonBanHang] FOREIGN KEY([soHD])
REFERENCES [dbo].[HoaDonBanHang] ([soHD])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_HoaDonBanHang]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_PhuongThucThanhToan] FOREIGN KEY([maPhuongThuc])
REFERENCES [dbo].[PhuongThucThanhToan] ([maPhuongThuc])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_PhuongThucThanhToan]
GO
ALTER TABLE [dbo].[TheThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_TheThanhVien_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[TheThanhVien] CHECK CONSTRAINT [FK_TheThanhVien_KhachHang]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đào tạo kỹ năng hoặc chương trình' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ChuongTrinhDaoTao', @level2type=N'COLUMN',@level2name=N'tenChuongTrinhDaoTao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nhan vien de nghi xuat kho' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhieuDNXK', @level2type=N'COLUMN',@level2name=N'MaNhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: chua xu ly,1 da xu ly, -1: huy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhieuDNXK', @level2type=N'COLUMN',@level2name=N'tinhtrang'
GO
