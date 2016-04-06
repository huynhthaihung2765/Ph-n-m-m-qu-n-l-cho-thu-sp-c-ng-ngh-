create database QLSP
go

USE [QLSP]
GO
/****** Object:  Table [dbo].[CT_HDTT]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_HDTT](
	[SoHD] [varchar](3) NOT NULL,
	[SoHDTT] [varchar](3) NOT NULL,
	[NgayLap] [datetime] NULL,
	[SoLuongSPThue] [int] NULL,
	[TraTruoc] [int] NULL,
	[Lydo] [nvarchar](50) NULL,
	[TongTienThanhToan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC,
	[SoHDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_HOPDONG]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_HOPDONG](
	[MaLoaiSP] [varchar](3) NOT NULL,
	[SoHD] [varchar](3) NOT NULL,
	[SoLuong] [int] NULL,
	[NgayNhan] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[Gia] [int] NULL,
	[GhiChu] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC,
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DATSP]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DATSP](
	[NgayHenDat] [datetime] NOT NULL,
	[SoLuongDat] [int] NULL,
	[NgayHenLay] [datetime] NULL,
	[TinhTrang] [nvarchar](20) NULL,
	[MaLoaiSP] [varchar](3) NOT NULL,
	[CMND] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NgayHenDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HDTT]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HDTT](
	[SoHDTT] [varchar](3) NOT NULL,
	[NgayNhan] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[ThanhTien] [int] NULL,
	[MaSP] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoHDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[SoHD] [varchar](3) NOT NULL,
	[NgayLap] [datetime] NULL,
	[DonGia] [int] NULL,
	[TienTamUng] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[CMND] [varchar](12) NOT NULL,
	[HoTenKH] [nvarchar](20) NULL,
	[DiaChiKH] [nvarchar](50) NULL,
	[DIenThoaiKH] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAISP]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAISP](
	[MaLoaiSP] [varchar](3) NOT NULL,
	[TenLoaiSP] [nvarchar](20) NULL,
	[SoLuongSP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](3) NOT NULL,
	[TenDangNhap] [nvarchar](20) NULL,
	[HoTenNV] [varchar](20) NULL,
	[TenDayDu] [nvarchar](20) NULL,
	[MatKhau] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAPSP]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAPSP](
	[NgayNhap] [datetime] NOT NULL,
	[GhiChu] [nvarchar](25) NULL,
	[MaSP] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NgayNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[IDQUYEN] [varchar](3) NOT NULL,
	[MaNV] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDQUYEN] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUYEN](
	[IDQUYEN] [varchar](3) NOT NULL,
	[TenQuyen] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDQUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [varchar](3) NOT NULL,
	[MoTa] [text] NULL,
	[TinhTrang] [nvarchar](20) NULL,
	[MaLoaiSP] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XuatSP]    Script Date: 4/4/2016 2:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XuatSP](
	[NgayXuat] [datetime] NOT NULL,
	[GhiChu] [nvarchar](25) NULL,
	[MaSP] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NgayXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CT_HDTT]  WITH CHECK ADD FOREIGN KEY([SoHD])
REFERENCES [dbo].[HOPDONG] ([SoHD])
GO
ALTER TABLE [dbo].[CT_HDTT]  WITH CHECK ADD FOREIGN KEY([SoHDTT])
REFERENCES [dbo].[HDTT] ([SoHDTT])
GO
ALTER TABLE [dbo].[CT_HOPDONG]  WITH CHECK ADD FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LOAISP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[CT_HOPDONG]  WITH CHECK ADD FOREIGN KEY([SoHD])
REFERENCES [dbo].[HOPDONG] ([SoHD])
GO
ALTER TABLE [dbo].[DATSP]  WITH CHECK ADD FOREIGN KEY([CMND])
REFERENCES [dbo].[KHACHHANG] ([CMND])
GO
ALTER TABLE [dbo].[DATSP]  WITH CHECK ADD FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LOAISP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[HDTT]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[NHAPSP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD FOREIGN KEY([IDQUYEN])
REFERENCES [dbo].[QUYEN] ([IDQUYEN])
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LOAISP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[XuatSP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
