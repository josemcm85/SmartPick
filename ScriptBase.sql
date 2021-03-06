USE [master]
GO
/****** Object:  Database [MenuTTS]    Script Date: 2/24/2019 12:02:59 PM ******/
CREATE DATABASE [MenuTTS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MenuTTS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.PROGRA\MSSQL\DATA\MenuTTS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MenuTTS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.PROGRA\MSSQL\DATA\MenuTTS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MenuTTS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MenuTTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MenuTTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MenuTTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MenuTTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MenuTTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MenuTTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [MenuTTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MenuTTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MenuTTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MenuTTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MenuTTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MenuTTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MenuTTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MenuTTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MenuTTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MenuTTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MenuTTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MenuTTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MenuTTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MenuTTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MenuTTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MenuTTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MenuTTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MenuTTS] SET RECOVERY FULL 
GO
ALTER DATABASE [MenuTTS] SET  MULTI_USER 
GO
ALTER DATABASE [MenuTTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MenuTTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MenuTTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MenuTTS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MenuTTS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MenuTTS', N'ON'
GO
ALTER DATABASE [MenuTTS] SET QUERY_STORE = OFF
GO
USE [MenuTTS]
GO
/****** Object:  Table [dbo].[FotosMenu]    Script Date: 2/24/2019 12:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FotosMenu](
	[CodPlato] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Foto] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuEng]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuEng](
	[NoPlato] [varchar](50) NULL,
	[Description] [varchar](120) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuEsp]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuEsp](
	[CodPlato] [varchar](50) NOT NULL,
	[Nombre] [varchar](80) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Categoria] [varchar](80) NOT NULL,
	[TipoComida] [varchar](80) NOT NULL,
	[Precio] [float] NOT NULL,
	[Calorias] [float] NOT NULL,
 CONSTRAINT [PK_MenuEsp] PRIMARY KEY CLUSTERED 
(
	[CodPlato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [varchar](50) NOT NULL,
	[Nombre] [varchar](80) NULL,
	[Apellidos] [varchar](80) NULL,
	[Username] [varchar](80) NULL,
	[Password] [varchar](50) NULL,
	[Puesto] [varchar](50) NULL,
	[Correo] [varchar](80) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FotosMenu]  WITH CHECK ADD  CONSTRAINT [FK_FotosMenu_MenuEsp] FOREIGN KEY([CodPlato])
REFERENCES [dbo].[MenuEsp] ([CodPlato])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FotosMenu] CHECK CONSTRAINT [FK_FotosMenu_MenuEsp]
GO
ALTER TABLE [dbo].[MenuEng]  WITH CHECK ADD  CONSTRAINT [FK_MenuEng_MenuEsp] FOREIGN KEY([NoPlato])
REFERENCES [dbo].[MenuEsp] ([CodPlato])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MenuEng] CHECK CONSTRAINT [FK_MenuEng_MenuEsp]
GO
/****** Object:  StoredProcedure [dbo].[addPlato]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[addPlato]
	@inCodPlato as Varchar(50),
	@inNombre as Varchar(120),
	@inDesEsp as varchar(200),
	@inTipoPLato as varchar(120),
	@inTipoComida as Varchar(120),
	@inPrecio as float,
	@inCalorias as float,
	@inDesIng as varchar(120)
AS

Insert into MenuEsp values(@inCodPlato,@inNombre,@inDesEsp,@inTipoPLato,@inTipoComida,@inPrecio,@inCalorias)
Insert into MenuEng values(@inCodPlato,@inDesIng)


GO
/****** Object:  StoredProcedure [dbo].[addUsuario]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[addUsuario]
	
	@id as varchar(50),
	@inNombre as varchar(80),
	@inApellido as varchar(80), 
	@inUser as varchar(50), 
	@inPass as varchar(50),
	@inPuesto as varchar(50),
	@inCorreo as varchar(50)

AS

insert into Usuarios values(@id,@inNombre,@inApellido,@inUser,@inPass,@inPuesto,@inCorreo)

	

GO
/****** Object:  StoredProcedure [dbo].[DelPlato]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DelPlato]
@inCod as Varchar
AS
BEGIN
	Delete from MenuEsp where MenuEsp.CodPlato = @inCod
	
END
GO
/****** Object:  StoredProcedure [dbo].[EditPlato]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EditPlato]
	@inCodPlato as Varchar(50),
	@inNombre as Varchar(120),
	@inDesEsp as varchar(200),
	@inTipoPLato as varchar(120),
	@inTipoComida as Varchar(120),
	@inPrecio as float,
	@inCalorias as float,
	@inDesIng as varchar(120)
AS

Update MenuEsp set Nombre = @inNombre,
 Descripcion =  @inDesEsp,
 categoria = @inTipoPLato , 
 TipoComida = @inTipoComida, 
 Precio = @inPrecio,
 Calorias = @inCalorias 
 where CodPlato =@inCodPlato;


Update MenuEng set Description=@inDesIng where NoPlato =@inCodPlato;


GO
/****** Object:  StoredProcedure [dbo].[getinfo]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getinfo]
	@in as varchar(50)
AS
Select Username,Password,Correo from Usuarios where idUsuario = @in
GO
/****** Object:  StoredProcedure [dbo].[loadMenuEsp]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[loadMenuEsp]
	
AS

	Select E.*, F.Foto, I.Description from MenuEsp E,MenuEng I,FotosMenu F where E.CodPlato = I.NoPlato and E.CodPlato = F.CodPlato 
GO
/****** Object:  StoredProcedure [dbo].[loadMenuIng]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[loadMenuIng]

as

Select E.CodPlato,E.Nombre,I.Description,E.Categoria,e.TipoComida,E.Precio,e.Calorias,F.Foto, E.Descripcion from MenuEsp E,MenuEng I,FotosMenu F where E.CodPlato = I.NoPlato and E.CodPlato = F.CodPlato
	
GO
/****** Object:  StoredProcedure [dbo].[UserLogin]    Script Date: 2/24/2019 12:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserLogin]
@inUsername as varchar(50), @inPassword as varchar(50)

AS

Select * from Usuarios where Usuarios.Username = @inUsername and Usuarios.Password = @inPassword


GO
USE [master]
GO
ALTER DATABASE [MenuTTS] SET  READ_WRITE 
GO
