USE [master]
GO
/****** Object:  Database [SISCOP]    Script Date: 11/1/2015 8:45:28 PM ******/
CREATE DATABASE [SISCOP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SISCOP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SISCOP.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SISCOP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SISCOP_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SISCOP] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SISCOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SISCOP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SISCOP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SISCOP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SISCOP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SISCOP] SET ARITHABORT OFF 
GO
ALTER DATABASE [SISCOP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SISCOP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SISCOP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SISCOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SISCOP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SISCOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SISCOP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SISCOP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SISCOP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SISCOP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SISCOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SISCOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SISCOP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SISCOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SISCOP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SISCOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SISCOP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SISCOP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SISCOP] SET  MULTI_USER 
GO
ALTER DATABASE [SISCOP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SISCOP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SISCOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SISCOP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SISCOP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SISCOP]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] NOT NULL,
	[pais] [varchar](350) NULL,
	[web] [varchar](350) NULL,
	[fax] [varchar](350) NULL,
	[telefono] [int] NULL,
	[correo] [varchar](350) NULL,
	[direccion] [varchar](350) NULL,
	[nombre] [varchar](350) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comentarios]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentarios](
	[id_comentario] [int] IDENTITY(1,1) NOT NULL,
	[texto] [int] NULL,
	[id_etapa_tarea] [int] NULL,
 CONSTRAINT [PK_Comentarios] PRIMARY KEY CLUSTERED 
(
	[id_comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contactos](
	[id_contacto] [int] IDENTITY(1,1) NOT NULL,
	[pais] [varchar](350) NULL,
	[nombre] [varchar](350) NULL,
	[puesto] [varchar](350) NULL,
	[telefonos] [varchar](350) NULL,
	[correo] [varchar](350) NULL,
	[id_cliente] [int] NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estados_Ofertas]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estados_Ofertas](
	[id_estado_oferta] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](350) NULL,
 CONSTRAINT [PK_Estados_Ofertas] PRIMARY KEY CLUSTERED 
(
	[id_estado_oferta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estados_Proyectos]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estados_Proyectos](
	[id_estado_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](350) NULL,
 CONSTRAINT [PK_Estado_Proyectos] PRIMARY KEY CLUSTERED 
(
	[id_estado_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Etapa_Tarea]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etapa_Tarea](
	[id_etapa_tarea] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[id_tarea] [int] NULL,
	[id_etapa] [int] NULL,
 CONSTRAINT [PK_Asignar_tarea_etapa_proyecto] PRIMARY KEY CLUSTERED 
(
	[id_etapa_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etapas]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Etapas](
	[id_etapa] [int] IDENTITY(1,1) NOT NULL,
	[id_proyecto] [int] NULL,
	[nombre] [varchar](350) NULL,
	[fecha_inicio] [nchar](10) NULL,
	[fecha_final] [nchar](10) NULL,
	[estado] [varchar](350) NULL,
	[encargado] [varchar](350) NULL,
 CONSTRAINT [PK_Etapas] PRIMARY KEY CLUSTERED 
(
	[id_etapa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ofertas]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ofertas](
	[id_oferta] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](500) NULL,
	[descripcion] [varchar](500) NULL,
	[id_responsable] [int] NULL,
	[anho] [varchar](500) NULL,
	[pais] [varchar](500) NULL,
	[fecha_recepcion] [varchar](500) NULL,
	[fecha_presentacion] [varchar](500) NULL,
	[id_estado_oferta] [int] NULL,
	[nota] [varchar](350) NULL,
	[observacion] [varchar](350) NULL,
	[id_cliente] [int] NULL,
 CONSTRAINT [PK_Ofertas] PRIMARY KEY CLUSTERED 
(
	[id_oferta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proyecto_Usuario]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyecto_Usuario](
	[id] [int] NOT NULL,
	[id_proyecto] [int] NULL,
	[id_usuario] [int] NULL,
 CONSTRAINT [PK_Asignar_Proyecto_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proyectos]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proyectos](
	[id_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nchar](10) NULL,
	[id_cliente] [int] NULL,
	[nombre_estudio] [varchar](500) NULL,
	[descripcion] [varchar](500) NULL,
	[directorProyecto] [varchar](500) NULL,
	[anho] [varchar](500) NULL,
	[pais] [varchar](500) NULL,
	[fecha_recepcion] [varchar](500) NULL,
	[fecha_presentacion] [varchar](500) NULL,
	[id_estado_proyecto] [int] NULL,
	[id_oferta] [int] NULL,
	[notas] [varchar](350) NULL,
	[observacion] [varchar](350) NULL,
	[jefe_campo] [varchar](350) NULL,
 CONSTRAINT [PK_proyectos] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Responsables]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Responsables](
	[id_responsable] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](350) NULL,
 CONSTRAINT [PK_Responsables] PRIMARY KEY CLUSTERED 
(
	[id_responsable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tareas]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tareas](
	[id_tarea] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](350) NULL,
	[fecha_inicio] [varchar](350) NULL,
	[fecha_final] [varchar](350) NULL,
	[estado] [varchar](350) NULL,
	[prioridad] [varchar](350) NULL,
	[id_etapa] [int] NULL,
 CONSTRAINT [PK_Tareas] PRIMARY KEY CLUSTERED 
(
	[id_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/1/2015 8:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](250) NOT NULL,
	[correo] [varchar](250) NOT NULL,
	[clave] [varchar](250) NOT NULL,
	[rol] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Comentarios]  WITH CHECK ADD  CONSTRAINT [FK_Comentarios_Etapa_Tarea] FOREIGN KEY([id_etapa_tarea])
REFERENCES [dbo].[Etapa_Tarea] ([id_etapa_tarea])
GO
ALTER TABLE [dbo].[Comentarios] CHECK CONSTRAINT [FK_Comentarios_Etapa_Tarea]
GO
ALTER TABLE [dbo].[Contactos]  WITH CHECK ADD  CONSTRAINT [FK_Contactos_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Contactos] CHECK CONSTRAINT [FK_Contactos_Clientes]
GO
ALTER TABLE [dbo].[Etapa_Tarea]  WITH CHECK ADD  CONSTRAINT [FK_Asignar_tarea_etapa_proyecto_Etapas] FOREIGN KEY([id_etapa])
REFERENCES [dbo].[Etapas] ([id_etapa])
GO
ALTER TABLE [dbo].[Etapa_Tarea] CHECK CONSTRAINT [FK_Asignar_tarea_etapa_proyecto_Etapas]
GO
ALTER TABLE [dbo].[Etapa_Tarea]  WITH CHECK ADD  CONSTRAINT [FK_Asignar_tarea_etapa_proyecto_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Etapa_Tarea] CHECK CONSTRAINT [FK_Asignar_tarea_etapa_proyecto_Usuarios]
GO
ALTER TABLE [dbo].[Etapa_Tarea]  WITH CHECK ADD  CONSTRAINT [FK_Etapa_Tarea_Tareas] FOREIGN KEY([id_tarea])
REFERENCES [dbo].[Tareas] ([id_tarea])
GO
ALTER TABLE [dbo].[Etapa_Tarea] CHECK CONSTRAINT [FK_Etapa_Tarea_Tareas]
GO
ALTER TABLE [dbo].[Etapas]  WITH CHECK ADD  CONSTRAINT [FK_Etapas_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[Etapas] CHECK CONSTRAINT [FK_Etapas_Proyectos]
GO
ALTER TABLE [dbo].[Ofertas]  WITH CHECK ADD  CONSTRAINT [FK_Ofertas_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Ofertas] CHECK CONSTRAINT [FK_Ofertas_Clientes]
GO
ALTER TABLE [dbo].[Ofertas]  WITH CHECK ADD  CONSTRAINT [FK_Ofertas_Estados_Ofertas] FOREIGN KEY([id_estado_oferta])
REFERENCES [dbo].[Estados_Ofertas] ([id_estado_oferta])
GO
ALTER TABLE [dbo].[Ofertas] CHECK CONSTRAINT [FK_Ofertas_Estados_Ofertas]
GO
ALTER TABLE [dbo].[Ofertas]  WITH CHECK ADD  CONSTRAINT [FK_Ofertas_Responsables] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Responsables] ([id_responsable])
GO
ALTER TABLE [dbo].[Ofertas] CHECK CONSTRAINT [FK_Ofertas_Responsables]
GO
ALTER TABLE [dbo].[Proyecto_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Asignar_Proyecto_Usuario_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[Proyecto_Usuario] CHECK CONSTRAINT [FK_Asignar_Proyecto_Usuario_Proyectos]
GO
ALTER TABLE [dbo].[Proyecto_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Asignar_Proyecto_Usuario_Usuarios] FOREIGN KEY([id])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Proyecto_Usuario] CHECK CONSTRAINT [FK_Asignar_Proyecto_Usuario_Usuarios]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Clientes]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Estado_Proyectos] FOREIGN KEY([id_estado_proyecto])
REFERENCES [dbo].[Estados_Proyectos] ([id_estado_proyecto])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Estado_Proyectos]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Ofertas] FOREIGN KEY([id_oferta])
REFERENCES [dbo].[Ofertas] ([id_oferta])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Ofertas]
GO
USE [master]
GO
ALTER DATABASE [SISCOP] SET  READ_WRITE 
GO
