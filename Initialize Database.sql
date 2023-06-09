/****** Object:  Database [BdBotones]    Script Date: 16/03/2023 22:39:34 ******/
IF NOT EXISTS(SELECT name FROM sys.databases WHERE name = 'BdBotones')
BEGIN
    CREATE DATABASE [BdBotones]
END
GO
USE BdBotones
GO

IF NOT EXISTS(SELECT name FROM sys.tables WHERE name = 'Botones')
BEGIN
CREATE TABLE [dbo].[Botones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Contador] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO



