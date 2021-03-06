USE [master]
GO
/****** Object:  Database [SISCOP]    Script Date: 10/18/2015 9:05:49 PM ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/18/2015 9:05:49 PM ******/
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
/****** Object:  Table [dbo].[Contactos]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contactos](
	[id_contacto] [int] NOT NULL,
	[id_cliente] [int] NULL,
	[pais] [varchar](350) NULL,
	[nombre] [varchar](350) NULL,
	[ocupacion] [varchar](350) NULL,
	[telefonos] [varchar](350) NULL,
	[correo] [varchar](350) NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Correos_Contactos]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correos_Contactos](
	[id_correo_contacto] [int] NULL,
	[numero] [int] NULL,
	[id_contacto] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etapa_Tarea]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etapa_Tarea](
	[id_etapa_tarea] [int] NOT NULL,
	[id_usuario] [int] NULL,
	[id_tarea] [int] NULL,
	[id_etapa] [int] NULL,
 CONSTRAINT [PK_Asignar_tarea_etapa_proyecto] PRIMARY KEY CLUSTERED 
(
	[id_etapa_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etapas]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Etapas](
	[id_etapa] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Ofertas]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ofertas](
	[id_oferta] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](500) NULL,
	[responsable] [varchar](500) NULL,
	[anho] [varchar](500) NULL,
	[pais] [varchar](500) NULL,
	[fecha_recepcion] [varchar](500) NULL,
	[fecha_presentacion] [varchar](500) NULL,
	[estado] [varchar](500) NULL,
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
/****** Object:  Table [dbo].[Ofertas_Contactos]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ofertas_Contactos](
	[id_ofertas_contactos] [int] NOT NULL,
	[id_oferta] [int] NULL,
	[id_contacto] [int] NULL,
 CONSTRAINT [PK_Ofertas_Contactos] PRIMARY KEY CLUSTERED 
(
	[id_ofertas_contactos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proyecto_Contactos]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyecto_Contactos](
	[id_proyecto_contactos] [nchar](10) NOT NULL,
	[id_contacto] [int] NULL,
	[id_proyecto] [int] NULL,
 CONSTRAINT [PK_Proyecto_Contactos] PRIMARY KEY CLUSTERED 
(
	[id_proyecto_contactos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proyecto_Usuario]    Script Date: 10/18/2015 9:05:49 PM ******/
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
/****** Object:  Table [dbo].[Proyectos]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proyectos](
	[id_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[nombre_estudio] [varchar](500) NULL,
	[descripcion] [varchar](500) NULL,
	[responsable] [varchar](500) NULL,
	[anho] [varchar](500) NULL,
	[pais] [varchar](500) NULL,
	[fecha_recepcion] [varchar](500) NULL,
	[fecha_presentacion] [varchar](500) NULL,
	[estado] [varchar](500) NULL,
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
/****** Object:  Table [dbo].[Proyectos_Contactos]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyectos_Contactos](
	[id_proyecto_contacto] [int] NULL,
	[id_proyecto] [int] NULL,
	[id_contacto] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tareas]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tareas](
	[id_tarea] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Telefonos_Clientes]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos_Clientes](
	[id_telefono_cliente] [int] NULL,
	[numero] [int] NULL,
	[id_cliente] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefonos_Contactos]    Script Date: 10/18/2015 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos_Contactos](
	[id_telefono_contacto] [int] NULL,
	[numero] [int] NULL,
	[id_contacto] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/18/2015 9:05:49 PM ******/
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
INSERT [dbo].[Clientes] ([id_cliente], [pais], [web], [fax], [telefono], [correo], [direccion], [nombre]) VALUES (2, N'Costa Rica', N'revista.com', NULL, 433443, N'revista@hotmail.com', N'San Jose, Costa Rica', N'Revista')
INSERT [dbo].[Clientes] ([id_cliente], [pais], [web], [fax], [telefono], [correo], [direccion], [nombre]) VALUES (3, N'nicaragua', N'adfs.com', N'344', 433434, N'dfsakja', N'fdslkj', N'Gobierno')
INSERT [dbo].[Contactos] ([id_contacto], [id_cliente], [pais], [nombre], [ocupacion], [telefonos], [correo]) VALUES (1, 1, N'Costa rica', N'Contacto 1', N'fdsalkj', N'333233', N'ldksfj')
INSERT [dbo].[Etapas] ([id_etapa], [id_proyecto], [nombre], [fecha_inicio], [fecha_final], [estado], [encargado]) VALUES (1, 2, N'Diseño Muestra', N'12 octubre', N'17 octubre', N'En proceso', N'Tania')
SET IDENTITY_INSERT [dbo].[Ofertas] ON 

INSERT [dbo].[Ofertas] ([id_oferta], [descripcion], [responsable], [anho], [pais], [fecha_recepcion], [fecha_presentacion], [estado], [nota], [observacion], [id_cliente]) VALUES (1, N'No hay', N'Mara', N'2015', N'Costa Rica', N'11 julio', N'10 agosto', N'Aceptado', N'No hay', N'No hay', 2)
INSERT [dbo].[Ofertas] ([id_oferta], [descripcion], [responsable], [anho], [pais], [fecha_recepcion], [fecha_presentacion], [estado], [nota], [observacion], [id_cliente]) VALUES (2, N'flkdsaj', N'lkjflkdsaj', N'jklfdjsñlk', N'jfldkj', N'lkjfdlk', N'jflkj', N'lfkjl', N'fdlkj', N'fdlk', 3)
SET IDENTITY_INSERT [dbo].[Ofertas] OFF
SET IDENTITY_INSERT [dbo].[Proyectos] ON 

INSERT [dbo].[Proyectos] ([id_proyecto], [id_cliente], [nombre_estudio], [descripcion], [responsable], [anho], [pais], [fecha_recepcion], [fecha_presentacion], [estado], [id_oferta], [notas], [observacion], [jefe_campo]) VALUES (2, 2, N'Itrio', N'No hay', N'Luis', N'2015', N'Costa rica', N'11 octubre', NULL, N'Iniciado', 1, N'No hay', N'No hay', N'Marco')
SET IDENTITY_INSERT [dbo].[Proyectos] OFF
INSERT [dbo].[Tareas] ([id_tarea], [descripcion], [fecha_inicio], [fecha_final], [estado], [prioridad], [id_etapa]) VALUES (1, N'adsflk', N'jadsklfj', N'klñjfdsalk', N'lksdsjak', N'alsdkj', 1)
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
ALTER TABLE [dbo].[Ofertas_Contactos]  WITH CHECK ADD  CONSTRAINT [FK_Ofertas_Contactos_Contactos] FOREIGN KEY([id_oferta])
REFERENCES [dbo].[Contactos] ([id_contacto])
GO
ALTER TABLE [dbo].[Ofertas_Contactos] CHECK CONSTRAINT [FK_Ofertas_Contactos_Contactos]
GO
ALTER TABLE [dbo].[Ofertas_Contactos]  WITH CHECK ADD  CONSTRAINT [FK_Ofertas_Contactos_Ofertas] FOREIGN KEY([id_oferta])
REFERENCES [dbo].[Ofertas] ([id_oferta])
GO
ALTER TABLE [dbo].[Ofertas_Contactos] CHECK CONSTRAINT [FK_Ofertas_Contactos_Ofertas]
GO
ALTER TABLE [dbo].[Proyecto_Contactos]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Contactos_Contactos] FOREIGN KEY([id_contacto])
REFERENCES [dbo].[Contactos] ([id_contacto])
GO
ALTER TABLE [dbo].[Proyecto_Contactos] CHECK CONSTRAINT [FK_Proyecto_Contactos_Contactos]
GO
ALTER TABLE [dbo].[Proyecto_Contactos]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Contactos_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[Proyecto_Contactos] CHECK CONSTRAINT [FK_Proyecto_Contactos_Proyectos]
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
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Ofertas] FOREIGN KEY([id_oferta])
REFERENCES [dbo].[Ofertas] ([id_oferta])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Ofertas]
GO
USE [master]
GO
ALTER DATABASE [SISCOP] SET  READ_WRITE 
GO
