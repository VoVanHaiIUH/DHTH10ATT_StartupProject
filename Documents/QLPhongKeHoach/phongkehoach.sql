USE [PKH]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonBanSi]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBanSi](
	[MaHoaDonBanSi] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBanSi] [money] NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[MaChiTietHoaDonBanSi] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDonBanSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhaCungCap]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhaCungCap](
	[MaHoaDonNhaCungCap] [nvarchar](50) NOT NULL,
	[MaChiTietHoaDonNhaCungCap] [nvarchar](50) NOT NULL,
	[MaSp] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaMuaBenNhaCungCap] [money] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[TenSp] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDonNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietKhuyenMai]    Script Date: 12/10/2016 8:27:40 CH ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuDeNghiNhapKho]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuDeNghiNhapKho](
	[MaPhieuDeNghiNhapKho] [nvarchar](50) NOT NULL,
	[MaChiTietPhieuDeNghiNhapKho] [nvarchar](50) NOT NULL,
	[MaSp] [nvarchar](50) NOT NULL,
	[TenSp] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[HanChot] [datetime] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietPhieuDeNghiNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuDeNghiNhapKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTieuXuatKho]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTieuXuatKho](
	[MaPhieuDeNghiXuatKho] [nvarchar](50) NOT NULL,
	[MaChiTietXuatKho] [nvarchar](50) NOT NULL,
	[MaSp] [nvarchar](50) NOT NULL,
	[TenSp] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTieuXuatKho] PRIMARY KEY CLUSTERED 
(
	[MaChiTietXuatKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChuongTrinhKhuyenMai]    Script Date: 12/10/2016 8:27:40 CH ******/
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
/****** Object:  Table [dbo].[HoaDonBanSi]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanSi](
	[MaHoaDonBanSi] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[NgayLap] [datetime] NULL,
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonBanSi] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonBanSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonNhaCungCap]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhaCungCap](
	[MaHoaDonNhaCungCap] [nvarchar](50) NOT NULL,
	[MaNhaCungCap] [nvarchar](50) NOT NULL,
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[NgayLap] [datetime] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Phone] [int] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [nvarchar](50) NOT NULL,
	[TenLoaiSanPham] [nvarchar](50) NULL,
	[Mota] [nvarchar](max) NULL,
	[Style] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](50) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Phone] [int] NULL,
	[NgayThanhLap] [datetime] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuDeNghiNhapKho]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDeNghiNhapKho](
	[MaPhieuDeNghiNhapKho] [nvarchar](50) NOT NULL,
	[NgayLap] [datetime] NULL,
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[NgayDuaVaoKho] [datetime] NULL,
	[MoTa] [nvarchar](max) NULL,
	[MaKho] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuDeNghiNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDeNghiNhapKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuDeNghiXuatKho]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDeNghiXuatKho](
	[MaPhieuDeNghiXuatKho] [nvarchar](50) NOT NULL,
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayLap] [datetime] NULL,
	[MaKho] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuDeNghiXuatKho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDeNghiXuatKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSp] [nvarchar](50) NULL,
	[MaNhaCungCap] [nvarchar](50) NOT NULL,
	[SoLuongTonKho] [int] NULL,
	[NgaySanXuat] [datetime] NULL,
	[KichThuoc] [float] NULL,
	[KieuDang] [nvarchar](50) NULL,
	[NgayDuaVaoBan] [datetime] NULL,
	[NgayKetThucBan] [datetime] NULL,
	[Color] [nvarchar](50) NULL,
	[TrongLuong] [float] NULL,
	[MaLoaiSanPham] [nvarchar](50) NOT NULL,
	[Mota] [nvarchar](4000) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheThanhVien]    Script Date: 12/10/2016 8:27:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThanhVien](
	[MaThe] [nvarchar](50) NOT NULL,
	[NgayCapThe] [datetime] NOT NULL,
	[SoDiem] [int] NOT NULL,
	[TenThanhVien] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoCmnd] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

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
REFERENCES [dbo].[HoaDonNhaCungCap] ([MaHoaDonNhaCungCap])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhaCungCap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhaCungCap_HoaDonNhaCungCap]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhaCungCap_SanPham] FOREIGN KEY([MaSp])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhaCungCap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhaCungCap_SanPham]
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
ALTER TABLE [dbo].[ChiTietPhieuDeNghiNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDeNghiNhapKho_PhieuDeNghiNhapKho] FOREIGN KEY([MaPhieuDeNghiNhapKho])
REFERENCES [dbo].[PhieuDeNghiNhapKho] ([MaPhieuDeNghiNhapKho])
GO
ALTER TABLE [dbo].[ChiTietPhieuDeNghiNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuDeNghiNhapKho_PhieuDeNghiNhapKho]
GO
ALTER TABLE [dbo].[ChiTietPhieuDeNghiNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDeNghiNhapKho_SanPham] FOREIGN KEY([MaSp])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuDeNghiNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuDeNghiNhapKho_SanPham]
GO
ALTER TABLE [dbo].[ChiTieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTieuXuatKho_PhieuDeNghiXuatKho] FOREIGN KEY([MaPhieuDeNghiXuatKho])
REFERENCES [dbo].[PhieuDeNghiXuatKho] ([MaPhieuDeNghiXuatKho])
GO
ALTER TABLE [dbo].[ChiTieuXuatKho] CHECK CONSTRAINT [FK_ChiTieuXuatKho_PhieuDeNghiXuatKho]
GO
ALTER TABLE [dbo].[ChiTieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTieuXuatKho_SanPham] FOREIGN KEY([MaSp])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTieuXuatKho] CHECK CONSTRAINT [FK_ChiTieuXuatKho_SanPham]
GO
ALTER TABLE [dbo].[HoaDonBanSi]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanSi_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanSi] CHECK CONSTRAINT [FK_HoaDonBanSi_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonBanSi]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanSi_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDonBanSi] CHECK CONSTRAINT [FK_HoaDonBanSi_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhaCungCap_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap] CHECK CONSTRAINT [FK_HoaDonNhaCungCap_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhaCungCap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDonNhaCungCap] CHECK CONSTRAINT [FK_HoaDonNhaCungCap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuDeNghiNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDeNghiNhapKho_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[PhieuDeNghiNhapKho] CHECK CONSTRAINT [FK_PhieuDeNghiNhapKho_Kho]
GO
ALTER TABLE [dbo].[PhieuDeNghiNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDeNghiNhapKho_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuDeNghiNhapKho] CHECK CONSTRAINT [FK_PhieuDeNghiNhapKho_NhanVien]
GO
ALTER TABLE [dbo].[PhieuDeNghiXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDeNghiXuatKho_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[PhieuDeNghiXuatKho] CHECK CONSTRAINT [FK_PhieuDeNghiXuatKho_Kho]
GO
ALTER TABLE [dbo].[PhieuDeNghiXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDeNghiXuatKho_NhanVien1] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuDeNghiXuatKho] CHECK CONSTRAINT [FK_PhieuDeNghiXuatKho_NhanVien1]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaCungCap]
GO
ALTER TABLE [dbo].[TheThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_TheThanhVien_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[TheThanhVien] CHECK CONSTRAINT [FK_TheThanhVien_KhachHang]
GO
