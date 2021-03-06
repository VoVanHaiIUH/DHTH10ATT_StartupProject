USE [SPRHR_IntegrationTeam]
GO
/****** Object:  Table [dbo].[PhieuDNNK]    Script Date: 16-Nov-16 2:09:43 PM ******/
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
	[tinhtrang] [int] NOT NULL CONSTRAINT [ckbdft_TinhTrang]  DEFAULT ((0)),
 CONSTRAINT [PK_PhieuDNNK] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDNNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuDNXK]    Script Date: 16-Nov-16 2:09:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuDNXK](
	[MaPhieuDNXK] [nvarchar](15) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[MaKho] [nvarchar](50) NOT NULL,
	[tinhtrang] [int] NOT NULL CONSTRAINT [ckb_checkTinhTrang]  DEFAULT ((0)),
 CONSTRAINT [PK_PhieuDNXK] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDNXK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PhieuDNNK] ([MaPhieuDNNK], [NgayLap], [MaNhanVien], [MoTa], [MaKho], [tinhtrang]) VALUES (N'PDNNK123', CAST(N'2016-11-16 13:58:15.103' AS DateTime), N'NV43', N'Vui lòng nhập kho gấp', N'K15', 0)
INSERT [dbo].[PhieuDNXK] ([MaPhieuDNXK], [MaNhanVien], [MaKH], [NgayLap], [MaKho], [tinhtrang]) VALUES (N'PDNXK143', N'NV43', N'KH32', CAST(N'2016-11-16 13:59:11.057' AS DateTime), N'K15', 1)
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nhan vien de nghi xuat kho' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhieuDNXK', @level2type=N'COLUMN',@level2name=N'MaNhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: chua xu ly,1 da xu ly, -1: huy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhieuDNXK', @level2type=N'COLUMN',@level2name=N'tinhtrang'
GO
