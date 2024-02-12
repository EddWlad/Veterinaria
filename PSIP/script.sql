USE [master]
GO
/****** Object:  Database [Veterinaria_Final]    Script Date: 24/1/2024 22:13:13 ******/
CREATE DATABASE [Veterinaria_Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Veterinaria_Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Veterinaria_Final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Veterinaria_Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Veterinaria_Final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Veterinaria_Final] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Veterinaria_Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Veterinaria_Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Veterinaria_Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Veterinaria_Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Veterinaria_Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Veterinaria_Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET RECOVERY FULL 
GO
ALTER DATABASE [Veterinaria_Final] SET  MULTI_USER 
GO
ALTER DATABASE [Veterinaria_Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Veterinaria_Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Veterinaria_Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Veterinaria_Final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Veterinaria_Final] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Veterinaria_Final] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Veterinaria_Final', N'ON'
GO
ALTER DATABASE [Veterinaria_Final] SET QUERY_STORE = ON
GO
ALTER DATABASE [Veterinaria_Final] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Veterinaria_Final]
GO
/****** Object:  Table [dbo].[Animales]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animales](
	[ID_Animal] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Fecha_Nacimiento] [date] NULL,
	[ID_Especie] [int] NULL,
	[ID_Raza] [int] NULL,
	[ID_Sexo] [int] NULL,
	[ID_Dueño_Cedula] [varchar](10) NULL,
	[Est_Animal] [int] NULL,
 CONSTRAINT [PK_Animales] PRIMARY KEY CLUSTERED 
(
	[ID_Animal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[ID_Citas] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Cita] [date] NULL,
	[ID_Animal] [int] NULL,
	[ID_Especialista_Cedula] [varchar](50) NULL,
	[ID_Servicio] [int] NULL,
	[Fecha_Hora] [time](0) NULL,
	[Est_Cita] [bit] NULL,
	[ID_Dueño_Cedula] [varchar](10) NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[ID_Citas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dueño]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dueño](
	[ID_Dueño_Cedula] [varchar](10) NOT NULL,
	[Nombre_Dueño] [varchar](20) NULL,
	[Apellido_Dueño] [varchar](20) NULL,
	[Dirección_Dueño] [varchar](50) NULL,
	[Telefono_Dueño] [varchar](50) NULL,
	[Email_Dueño] [varchar](50) NULL,
	[Est_Dueño] [int] NULL,
 CONSTRAINT [PK_Dueño] PRIMARY KEY CLUSTERED 
(
	[ID_Dueño_Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialista]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialista](
	[ID_Especialista_Cedula] [varchar](10) NOT NULL,
	[Nombre_Espe] [varchar](20) NULL,
	[Apellido_Espe] [varchar](20) NULL,
	[Telefono_Espe] [varchar](50) NULL,
	[Email_Espe] [varchar](50) NULL,
	[Especialización_Espe] [varchar](50) NULL,
	[Est_Espe] [int] NULL,
	[ID_Servicio] [int] NULL,
 CONSTRAINT [PK_Especialista] PRIMARY KEY CLUSTERED 
(
	[ID_Especialista_Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialista_Horario]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialista_Horario](
	[ID_Esp_Hora] [int] IDENTITY(1,1) NOT NULL,
	[ID_Especialista_Cedula] [varchar](10) NULL,
	[ID_Horario] [int] NULL,
 CONSTRAINT [PK_Especialista_Horario] PRIMARY KEY CLUSTERED 
(
	[ID_Esp_Hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especie]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especie](
	[ID_Especie] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Especie] [varchar](50) NULL,
	[Est_Especie] [int] NULL,
 CONSTRAINT [PK_Especie] PRIMARY KEY CLUSTERED 
(
	[ID_Especie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial_Medico]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Medico](
	[ID_Historial] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Historial] [date] NULL,
	[Diagnostico] [varchar](50) NULL,
	[Tratamiento] [varchar](200) NULL,
	[Observaciones] [varchar](50) NULL,
	[ID_Dueño_Cedula] [varchar](10) NULL,
	[Est_Historial] [int] NULL,
	[ID_Animal] [int] NULL,
 CONSTRAINT [PK_Historial_Medico] PRIMARY KEY CLUSTERED 
(
	[ID_Historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario](
	[ID_Horario] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cita] [int] NULL,
 CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED 
(
	[ID_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raza]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raza](
	[ID_Raza] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Raza] [varchar](50) NULL,
	[Est_Raza] [int] NULL,
 CONSTRAINT [PK_Raza] PRIMARY KEY CLUSTERED 
(
	[ID_Raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[ID_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Serv] [varchar](20) NULL,
	[Descripcion_Serv] [varchar](50) NULL,
	[Est_Serv] [int] NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[ID_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 24/1/2024 22:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[ID_Sexo] [int] IDENTITY(1,1) NOT NULL,
	[Sexo] [varchar](6) NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[ID_Sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Animales] ADD  CONSTRAINT [DF_Animales_Est_Animal]  DEFAULT ((1)) FOR [Est_Animal]
GO
ALTER TABLE [dbo].[Cita] ADD  CONSTRAINT [DF_Cita_Est_Cita]  DEFAULT ((1)) FOR [Est_Cita]
GO
ALTER TABLE [dbo].[Dueño] ADD  CONSTRAINT [DF_Dueño_Est_Dueño]  DEFAULT ((1)) FOR [Est_Dueño]
GO
ALTER TABLE [dbo].[Especialista] ADD  CONSTRAINT [DF_Especialista_Est_Espe]  DEFAULT ((1)) FOR [Est_Espe]
GO
ALTER TABLE [dbo].[Especie] ADD  CONSTRAINT [DF_Especie_Est_Especie]  DEFAULT ((1)) FOR [Est_Especie]
GO
ALTER TABLE [dbo].[Historial_Medico] ADD  CONSTRAINT [DF_Historial_Medico_Est_Historial]  DEFAULT ((1)) FOR [Est_Historial]
GO
ALTER TABLE [dbo].[Raza] ADD  CONSTRAINT [DF_Raza_Est_Raza]  DEFAULT ((1)) FOR [Est_Raza]
GO
ALTER TABLE [dbo].[Servicios] ADD  CONSTRAINT [DF_Servicios_Est_Serv]  DEFAULT ((1)) FOR [Est_Serv]
GO
ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [FK_Animales_Dueño] FOREIGN KEY([ID_Dueño_Cedula])
REFERENCES [dbo].[Dueño] ([ID_Dueño_Cedula])
GO
ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [FK_Animales_Dueño]
GO
ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [FK_Animales_Especie] FOREIGN KEY([ID_Especie])
REFERENCES [dbo].[Especie] ([ID_Especie])
GO
ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [FK_Animales_Especie]
GO
ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [FK_Animales_Raza] FOREIGN KEY([ID_Raza])
REFERENCES [dbo].[Raza] ([ID_Raza])
GO
ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [FK_Animales_Raza]
GO
ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [FK_Animales_Sexo] FOREIGN KEY([ID_Sexo])
REFERENCES [dbo].[Sexo] ([ID_Sexo])
GO
ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [FK_Animales_Sexo]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Animales] FOREIGN KEY([ID_Animal])
REFERENCES [dbo].[Animales] ([ID_Animal])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Animales]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Servicios] FOREIGN KEY([ID_Servicio])
REFERENCES [dbo].[Servicios] ([ID_Servicio])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Servicios]
GO
ALTER TABLE [dbo].[Especialista]  WITH CHECK ADD  CONSTRAINT [FK_Especialista_Servicios] FOREIGN KEY([ID_Servicio])
REFERENCES [dbo].[Servicios] ([ID_Servicio])
GO
ALTER TABLE [dbo].[Especialista] CHECK CONSTRAINT [FK_Especialista_Servicios]
GO
ALTER TABLE [dbo].[Especialista_Horario]  WITH CHECK ADD  CONSTRAINT [FK_Especialista_Horario_Especialista] FOREIGN KEY([ID_Especialista_Cedula])
REFERENCES [dbo].[Especialista] ([ID_Especialista_Cedula])
GO
ALTER TABLE [dbo].[Especialista_Horario] CHECK CONSTRAINT [FK_Especialista_Horario_Especialista]
GO
ALTER TABLE [dbo].[Especialista_Horario]  WITH CHECK ADD  CONSTRAINT [FK_Especialista_Horario_Horario] FOREIGN KEY([ID_Horario])
REFERENCES [dbo].[Horario] ([ID_Horario])
GO
ALTER TABLE [dbo].[Especialista_Horario] CHECK CONSTRAINT [FK_Especialista_Horario_Horario]
GO
ALTER TABLE [dbo].[Historial_Medico]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Medico_Dueño] FOREIGN KEY([ID_Dueño_Cedula])
REFERENCES [dbo].[Dueño] ([ID_Dueño_Cedula])
GO
ALTER TABLE [dbo].[Historial_Medico] CHECK CONSTRAINT [FK_Historial_Medico_Dueño]
GO
USE [master]
GO
ALTER DATABASE [Veterinaria_Final] SET  READ_WRITE 
GO
