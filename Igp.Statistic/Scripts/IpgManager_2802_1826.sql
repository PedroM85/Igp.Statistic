USE [IgpManager]
GO
SET IDENTITY_INSERT [dbo].[SYS_Circuito] ON 

INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (1, N'Estados Unidos                                                                                      ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (2, N'Mexico                                                                                              ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (3, N'Monaco                                                                                              ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (4, N'Austria                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (5, N'Abu Dhabi                                                                                           ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (6, N'Japon                                                                                               ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (7, N'Azerbaiyan                                                                                          ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (8, N'Belgica                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (9, N'China                                                                                               ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (10, N'Malasia                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (11, N'Alemania                                                                                            ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (12, N'Australia                                                                                           ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (13, N'Rusia                                                                                               ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (14, N'España                                                                                              ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (15, N'Singapur                                                                                            ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (18, N'Hungria                                                                                             ')
INSERT [dbo].[SYS_Circuito] ([ID], [nCircuito]) VALUES (19, N'Gran                                                                                                ')
SET IDENTITY_INSERT [dbo].[SYS_Circuito] OFF
SET IDENTITY_INSERT [dbo].[SYS_Configuracion] ON 

INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Idv], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric], [PAR_Cacheable]) VALUES (1, N'NCARRERA  ', N'Numero de Carreras por Temporada', N'N', NULL, CAST(23.0000 AS Numeric(19, 4)), 1)
INSERT [dbo].[SYS_Configuracion] ([PAR_Id], [PAR_Idv], [PAR_Descripcion], [PAR_Type], [PAR_String], [PAR_Numeric], [PAR_Cacheable]) VALUES (2, N'NPILOTO   ', N'Numero de Pilotos por temporadas', N'N', NULL, CAST(33.0000 AS Numeric(19, 4)), 1)
SET IDENTITY_INSERT [dbo].[SYS_Configuracion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Nacion] ON 

INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (1, N'Venezuela                                         ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (2, N'Ucrania                                           ')
INSERT [dbo].[SYS_Nacion] ([id], [idNacion]) VALUES (5, N'Argentina                                         ')
SET IDENTITY_INSERT [dbo].[SYS_Nacion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Piloto] ON 

INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (1, N'Prueba2                                 ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (3, N'Jose                                    ', 2)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (4, N'Carmen                                  ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (5, N'Camila                                  ', 2)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (6, N'Jesus                                   ', 1)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (7, N'Juano Mikaro                            ', 5)
INSERT [dbo].[SYS_Piloto] ([id], [nPiloto], [IdNacion]) VALUES (8, N'Pedro Maneiro                           ', 5)
SET IDENTITY_INSERT [dbo].[SYS_Piloto] OFF
SET IDENTITY_INSERT [dbo].[SYS_Posicion] ON 

INSERT [dbo].[SYS_Posicion] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [Ptsllegada], [InsertedFecha], [ModifyFecha]) VALUES (50, N'29                            ', 1, N'7                                       ', 1, 25, CAST(N'2020-02-28 11:41:47.800' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[SYS_Posicion] OFF
SET IDENTITY_INSERT [dbo].[SYS_Posicion1] ON 

INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (1, N'29                            ', 4, N'7                                       ', 1, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (4, N'29                            ', 4, N'1                                       ', 2, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (5, N'29                            ', 4, N'5                                       ', 3, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (6, N'29                            ', 4, N'3                                       ', 4, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (8, N'28                            ', 4, N'4                                       ', 6, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (10, N'29                            ', 1, N'2                                       ', 11, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (11, N'29                            ', 1, N'3                                       ', 12, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (13, N'29                            ', 1, N'1                                       ', 12, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (16, N'29                            ', 14, N'1                                       ', 1, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (17, N'29                            ', 14, N'3                                       ', 3, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (18, N'29                            ', 14, N'4                                       ', 4, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (19, N'29                            ', 14, N'5                                       ', 5, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (20, N'29                            ', 14, N'6                                       ', 6, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (21, N'29                            ', 14, N'7                                       ', 7, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (22, N'29                            ', 15, N'1                                       ', 1, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (23, N'29                            ', 15, N'3                                       ', 3, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (24, N'29                            ', 15, N'4                                       ', 5, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (25, N'29                            ', 15, N'5                                       ', 6, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (26, N'29                            ', 15, N'6                                       ', 8, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (27, N'29                            ', 15, N'7                                       ', 2, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (28, N'29                            ', 8, N'7                                       ', 1, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (14, N'29                            ', 8, N'7                                       ', 9, CAST(N'2020-02-27 10:16:01.880' AS DateTime), NULL)
INSERT [dbo].[SYS_Posicion1] ([id], [idTemporada], [idCircuito], [idPiloto], [Posllegada], [InsertedFecha], [ModifyFecha]) VALUES (29, N'29                            ', 1, N'3                                       ', 1, CAST(N'2020-02-27 10:16:01.880' AS DateTime), CAST(N'2020-02-27 11:02:55.013' AS DateTime))
SET IDENTITY_INSERT [dbo].[SYS_Posicion1] OFF
SET IDENTITY_INSERT [dbo].[SYS_Punto] ON 

INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (3, N'1         ', N'25        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (4, N'2         ', N'18        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (5, N'3         ', N'15        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (6, N'4         ', N'12        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (7, N'5         ', N'10        ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (8, N'6         ', N'8         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (10, N'7         ', N'6         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (11, N'8         ', N'4         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (12, N'9         ', N'2         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (13, N'10        ', N'1         ')
INSERT [dbo].[SYS_Punto] ([id], [ptsPosicion], [ptsCantidad]) VALUES (14, N'11        ', N'0         ')
SET IDENTITY_INSERT [dbo].[SYS_Punto] OFF
SET IDENTITY_INSERT [dbo].[SYS_Temporada] ON 

INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (1, N'Temporada 1                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (2, N'Temporada 2                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (3, N'Temporada 3                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (4, N'Temporada 4                   ', 0)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (5, N'Temporada 5                   ', 0)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (6, N'Temporada 6                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (7, N'Temporada 7                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (8, N'Temporada 8                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (9, N'Temporada 9                   ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (10, N'Temporada 10                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (11, N'Temporada 11                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (12, N'Temporada 12                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (13, N'Temporada 13                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (14, N'Temporada 14                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (15, N'Temporada 15                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (16, N'Temporada 16                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (17, N'Temporada 17                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (18, N'Temporada 18                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (19, N'Temporada 19                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (20, N'Temporada 20                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (21, N'Temporada 21                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (22, N'Temporada 22                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (23, N'Temporada 23                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (24, N'Temporada 24                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (25, N'Temporada 25                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (26, N'Temporada 26                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (27, N'Temporada 27                  ', NULL)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (28, N'Temporada 28                  ', 0)
INSERT [dbo].[SYS_Temporada] ([idTem], [Temporada], [isActive]) VALUES (29, N'Temporada 29                  ', 1)
SET IDENTITY_INSERT [dbo].[SYS_Temporada] OFF
