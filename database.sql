/****** Object:  Table [dbo].[tblBookInfos]    Script Date: 7/25/2023 8:58:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBookInfos](
	[bkId] [int] IDENTITY(1,1) NOT NULL,
	[bkName] [nvarchar](50) NOT NULL,
	[bkAuthor] [nvarchar](50) NOT NULL,
	[bkPublication] [nvarchar](50) NOT NULL,
	[bkDate] [nvarchar](50) NOT NULL,
	[bkPrice] [bigint] NOT NULL,
	[bkQuanity] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblIssueBooks]    Script Date: 7/25/2023 8:58:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIssueBooks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[stName] [nvarchar](50) NOT NULL,
	[stNumber] [nvarchar](50) NOT NULL,
	[stDepartment] [nvarchar](50) NOT NULL,
	[stSemester] [nvarchar](50) NOT NULL,
	[stContact] [bigint] NOT NULL,
	[stEmail] [nvarchar](50) NOT NULL,
	[bkName] [nvarchar](1250) NOT NULL,
	[bkIssueDate] [nvarchar](250) NOT NULL,
	[bkReturnDate] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 7/25/2023 8:58:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[id] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStudentInfos]    Script Date: 7/25/2023 8:58:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStudentInfos](
	[stId] [int] IDENTITY(1,1) NOT NULL,
	[stName] [nvarchar](50) NOT NULL,
	[stNumber] [nvarchar](50) NOT NULL,
	[stDepartment] [nvarchar](50) NOT NULL,
	[stSemester] [nvarchar](50) NOT NULL,
	[stContact] [bigint] NOT NULL,
	[stEmail] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblBookInfos] ON 

INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (4, N'Programming Python', N'Elon Musk', N'Paycharm', N'11-8-2008', 7000, 12)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (5, N'HTML ', N'Bill Gates', N'webdev PUB', N'Tuesday, November 5, 2019', 2000, 10)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (8, N'PHP 7', N'ALi', N'Chadhouse', N'26 December 2020', 2000, 1)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (9, N'Calculus', N'Newton', N'Math', N'30 December 2020', 2555, 2)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (21, N'Mắt Biếc', N'Nguyễn Nhật Ánh', N'Mắt Biếc', N'Thursday, July 20, 2023', 1, 1)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (22, N'Homo Deus', N'Yuval Noah Harari', N'Nhã Nam', N'21/11/2023', 189001, 1)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (23, N'Cây Cam Ngọt Của Tôi', N'José Vasconcelos', N'Nhã Nam', N'22/07/2023', 80000, 5)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (25, N'1', N'1', N'2', N'24/07/2023', 22222, 2)
INSERT [dbo].[tblBookInfos] ([bkId], [bkName], [bkAuthor], [bkPublication], [bkDate], [bkPrice], [bkQuanity]) VALUES (26, N'Đoán', N'Đoán', N'Đoán', N'24/07/2023', 10000000, 123)
SET IDENTITY_INSERT [dbo].[tblBookInfos] OFF
GO
SET IDENTITY_INSERT [dbo].[tblIssueBooks] ON 

INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (2, N'Kaan Hakan', N'1810211020', N'Computer', N'4th', 5365056636, N'kaan@gmail.com', N'HTML ', N'Monday, December 21, 2020', N'Saturday, July 15, 2023')
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (3, N'Mari killi', N'1810205015', N'Ebelik', N'4th', 585858566, N'mari@gmail.com', N'Progrmming Java', N'Monday, December 21, 2020', NULL)
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (4, N'Nour', N'1810203015', N'Electrical', N'1st', 5365556633, N'nour@gmail.com', N'Progrmming C#', N'Monday, December 21, 2020', NULL)
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (5, N'Nour', N'1810203015', N'Electrical', N'1st', 5365556633, N'nour@gmail.com', N'Progrmming Java', N'Monday, December 21, 2020', N'25 December 2020')
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (6, N'Nour', N'1810203015', N'Electrical', N'1st', 5365556633, N'nour@gmail.com', N'Progrmming Python', N'Monday, December 21, 2020', N'Monday, December 21, 2020')
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (7, N'Kaan Hakan', N'1810211020', N'Computer', N'4th', 5365056636, N'kaan@gmail.com', N'HTML ', N'Tuesday, December 22, 2020', N'Tuesday, December 22, 2020')
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (8, N'Ab Yusuf', N'1810213015', N'Civil Ebgineering', N'3rd', 5466084491, N'ab@gmail.com', N'PHP 7', N'26 December 2020', NULL)
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (9, N'Ab Yusuf', N'1810213015', N'Civil Ebgineering', N'3rd', 5466084491, N'ab@gmail.com', N'Progrmming Python', N'26 December 2020', N'26 December 2020')
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (10, N'Ab Yusuf', N'1810213015', N'Civil Ebgineering', N'3rd', 5466084491, N'ab@gmail.com', N'Progrmming Java', N'26 December 2020', NULL)
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (11, N'Kaan Hakan', N'1810211020', N'Computer', N'4th', 5365056636, N'kaan@gmail.com', N'PHP 7', N'Saturday, July 15, 2023', NULL)
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (12, N'Mari killi', N'1810205015', N'Ebelik', N'4th', 585858566, N'mari@gmail.com', N'M?t bi?c', N'Thursday, July 20, 2023', N'Thursday, July 20, 2023')
INSERT [dbo].[tblIssueBooks] ([Id], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail], [bkName], [bkIssueDate], [bkReturnDate]) VALUES (13, N'Mari killi', N'1810205015', N'Ebelik', N'4th', 585858566, N'mari@gmail.com', N'Progrmming Java', N'Thursday, July 20, 2023', N'Thursday, July 20, 2023')
SET IDENTITY_INSERT [dbo].[tblIssueBooks] OFF
GO
INSERT [dbo].[tblLogin] ([id], [UserName], [Password]) VALUES (1, N'admin', N'admin')
GO
SET IDENTITY_INSERT [dbo].[tblStudentInfos] ON 

INSERT [dbo].[tblStudentInfos] ([stId], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail]) VALUES (1, N'Kaan Hakan', N'1810211020', N'Computer', N'4th', 5365056636, N'kaan@gmail.com')
INSERT [dbo].[tblStudentInfos] ([stId], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail]) VALUES (2, N'Marobi Maabi', N'1850211020', N'Medical', N'2nd', 5365057755, N'marobi@gmail.com')
INSERT [dbo].[tblStudentInfos] ([stId], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail]) VALUES (3, N'Nour', N'1810203015', N'Electrical', N'1st', 5365556633, N'nour@gmail.com')
INSERT [dbo].[tblStudentInfos] ([stId], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail]) VALUES (4, N'Mari killi', N'1810205015', N'Ebelik', N'4th', 585858566, N'mari@gmail.com')
INSERT [dbo].[tblStudentInfos] ([stId], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail]) VALUES (6, N'Ab Yusuf', N'1810213015', N'Civil Ebgineering', N'3rd', 5466084491, N'ab@gmail.com')
INSERT [dbo].[tblStudentInfos] ([stId], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail]) VALUES (7, N'Nguyễn Hữu Thường', N'Nguyễn Hữu Sơn', N'Nguyễn Hữu Thưởng', N'Nguyễn Hữu', 916321987, N'Nguyễn Hữu')
INSERT [dbo].[tblStudentInfos] ([stId], [stName], [stNumber], [stDepartment], [stSemester], [stContact], [stEmail]) VALUES (8, N'Phạm Trang', N'0001092200', N'Phạm Trang', N'Phạm Trang', 918321321, N'Phạm Trang')
SET IDENTITY_INSERT [dbo].[tblStudentInfos] OFF
GO
USE [master]
GO
ALTER DATABASE [LMSDB] SET  READ_WRITE 
GO
