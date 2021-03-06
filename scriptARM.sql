USE [ArmDental]
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 01.06.2022 16:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointment](
	[id_appointment] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [int] NOT NULL,
	[date_app] [datetime] NULL,
	[reason] [nvarchar](50) NULL,
	[description] [nvarchar](250) NULL,
 CONSTRAINT [PK_appointment] PRIMARY KEY CLUSTERED 
(
	[id_appointment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[consumables]    Script Date: 01.06.2022 16:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consumables](
	[id_consumable] [int] IDENTITY(1,1) NOT NULL,
	[nozzle] [int] NULL,
	[anesthesia] [int] NULL,
	[crown] [int] NULL,
	[gel] [int] NULL,
	[vitamins] [int] NULL,
	[basic_tools] [int] NULL,
 CONSTRAINT [PK_consumables] PRIMARY KEY CLUSTERED 
(
	[id_consumable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 01.06.2022 16:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id_login] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[med_history]    Script Date: 01.06.2022 16:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[med_history](
	[id_history] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [int] NOT NULL,
	[x_ray] [nvarchar](50) NULL,
	[fase] [nvarchar](100) NULL,
	[desease] [nvarchar](50) NULL,
	[current_health] [nvarchar](50) NULL,
	[description] [nvarchar](150) NULL,
	[cost] [int] NULL,
	[complication] [nvarchar](50) NULL,
	[stage] [nvarchar](50) NULL,
	[mkb] [nvarchar](250) NULL,
	[consumable_id] [int] NULL,
 CONSTRAINT [PK_med_history] PRIMARY KEY CLUSTERED 
(
	[id_history] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mkb_codes]    Script Date: 01.06.2022 16:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mkb_codes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NULL,
	[Code] [nvarchar](10) NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_mkb_codes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 01.06.2022 16:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[id_patient] [int] IDENTITY(1,1) NOT NULL,
	[patient_first_name] [nvarchar](50) NOT NULL,
	[patient_last_name] [nvarchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[allergy] [nvarchar](100) NOT NULL,
	[teeth_map] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[appointment] ON 

INSERT [dbo].[appointment] ([id_appointment], [patient_id], [date_app], [reason], [description]) VALUES (1003, 1, CAST(N'2022-07-29T00:39:27.000' AS DateTime), N'Лечение', N'фцвфцвфвфцв')
INSERT [dbo].[appointment] ([id_appointment], [patient_id], [date_app], [reason], [description]) VALUES (2003, 2, CAST(N'2022-05-10T20:09:58.000' AS DateTime), N'Лечение', N'lkjhjklkjhjkljh')
INSERT [dbo].[appointment] ([id_appointment], [patient_id], [date_app], [reason], [description]) VALUES (2005, 1, CAST(N'2015-07-20T00:00:00.000' AS DateTime), N'test', N'test')
INSERT [dbo].[appointment] ([id_appointment], [patient_id], [date_app], [reason], [description]) VALUES (2008, 1, CAST(N'2022-05-09T15:26:24.000' AS DateTime), N'Повторное', N'цв')
SET IDENTITY_INSERT [dbo].[appointment] OFF
GO
SET IDENTITY_INSERT [dbo].[consumables] ON 

INSERT [dbo].[consumables] ([id_consumable], [nozzle], [anesthesia], [crown], [gel], [vitamins], [basic_tools]) VALUES (1, 222, 111, 1222221, 122111, 1222222221, 12)
INSERT [dbo].[consumables] ([id_consumable], [nozzle], [anesthesia], [crown], [gel], [vitamins], [basic_tools]) VALUES (2, 1111, 11111, 111111, 11111111, 111111111, 111)
SET IDENTITY_INSERT [dbo].[consumables] OFF
GO
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([id_login], [login], [password]) VALUES (1, N'admin', N'1234')
INSERT [dbo].[login] ([id_login], [login], [password]) VALUES (2, N'alex', N'2205')
SET IDENTITY_INSERT [dbo].[login] OFF
GO
SET IDENTITY_INSERT [dbo].[med_history] ON 

INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (1, 1, N'есть', N'есть', N'рак', N'здоров', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (2, 1, N'нет', N'есть', N'НеРак', N'болен', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (4, 1, N'нет', N'есть', N'Студент', N'здоров', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (1002, 2, N'нет', N'Любая', N'Периодонтит', N'Болен', N'fdbzdf', 12345, N'Осложнение', N'Начальная', N'K00.20', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (1003, 1, N'есть', N'Любая', N'Кариес', N'Здоров', N'scsdc', 123, N'Осложнение', N'Начальная', N'K00.10', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (2002, 2, N'есть', N'Любая', N'Пульпит', N'Здоров', N'dfsdf', 1000, N'Осложнение', N'Средняя', N'K00.01', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3002, 2, N'есть', N'Любая', N'Кариес', N'Здоров', N'fghj', 10000, N'Осложнение', N'Средняя', N'K00.3', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3003, 2, N'нет', N'Обострение', N'System.Windows.Controls.SelectedItemCollection', N'Не знаю', N'lkiuhj', 100, N'Без осложнения', N'Последняя', N'K00.4', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3004, 2, N'Не знаю', N'Не знаю', N'Кариес', N'Болен', N'jkbjkb', 8765, N'Не знаю', N'Press F', N'K00.4', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3005, 2, N'Не знаю', N'Любая', N'0,Кариес,Пульпит', N'Здоров', N'lkjhg', 345678, N'Не знаю', N'Начальная', N'K00.2', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3006, 1, N'есть', N'Любая', N'0,Кариес,Пульпит', N'Болен', N'sc', 99, N'Без осложнения', N'Средняя', N'K02', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3007, 2, N'нет', N'Любая', N'0,Пульпит,Периодонтит', N'Здоров', N'dddd', 111111, N'Не знаю', N'Средняя', N'K00.4', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3008, 2, N'есть', N'Любая', N'0,Пульпит,Периодонтит', N'Здоров', N'DDDDDDD', 1, N'Осложнение', N'Начальная', N'K00.4', 2)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3009, 1, N'test', N'test', N'test', N'test', N'test', 1, N'test', N'test', N'test', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3010, 1, N'test', N'test', N'test', N'test', N'test', 1, N'test', N'test', N'test', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3011, 1, N'test', N'test', N'test', N'test', N'test', 1, N'test', N'test', N'test', NULL)
INSERT [dbo].[med_history] ([id_history], [patient_id], [x_ray], [fase], [desease], [current_health], [description], [cost], [complication], [stage], [mkb], [consumable_id]) VALUES (3012, 1, N'test', N'test', N'test', N'test', N'test', 1, N'test', N'test', N'test', NULL)
SET IDENTITY_INSERT [dbo].[med_history] OFF
GO
SET IDENTITY_INSERT [dbo].[mkb_codes] ON 

INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (1, 0, N'K00.0', N'адентия')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (2, 1, N'K00.00', N'частичная адентия (гиподентия) (олигодентия)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (3, 1, N'K00.01', N'полная адентия')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (4, 1, N'K00.09', N'адентия неуточнённая')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (5, 0, N'K00.1', N'сверхкомплектные зубы')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (6, 5, N'K00.10', N'областей резца и клыка мезиодентия (срединный зуб)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (7, 5, N'K00.11', N'области премоляров')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (8, 5, N'K00.12', N'области моляров дистомолярный зуб, четвёртый моляр, парамолярный зуб')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (9, 5, N'K00.19', N'сверхкомплектные зубы неуточнённые')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (10, 0, N'K00.2', N'аномалии размеров и формы зубов')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (11, 10, N'K00.20', N'макродентия')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (12, 10, N'K00.21', N'микродентия')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (13, 10, N'K00.22', N'сращение')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (14, 10, N'K00.23', N'слияние (синодентия) и раздвоение (шизодентия)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (15, 10, N'K00.24', N'выпячивание зубов (добавочные окклюзионные бугорки)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (16, 10, N'K00.25', N'инвагинированный зуб (зуб в зубе) (дилатированная одонтома)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (17, 10, N'K00.26', N'премоляризация')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (18, 10, N'K00.27', N'аномальные бугорки и эмалевые жемчужины (адамантома)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (19, 10, N'K00.28', N'бычий зуб (тауродонтизм)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (20, 10, N'K00.29', N'другие и неуточнённые аномалии размеров и формы зубов')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (21, 0, N'K00.3', N'крапчатые зубы')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (22, 21, N'K00.30', N'эндемическая (флюорозная) крапчатость эмали (флюороз зубов)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (23, 21, N'K00.31', N'неэндемическая крапчатость эмали (нефлюорозное потемнение эмали)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (24, 0, N'K00.4', N'нарушение формирования зубов')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (25, 24, N'K00.40', N'гипоплазия эмали')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (26, 24, N'K00.41', N'перинатальная гипоплазия эмали')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (27, 24, N'K00.42', N'неонатальная гипоплазия эмали')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (28, 24, N'K00.43', N'аплазия и гипоплазия цемента')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (29, 24, N'K00.44', N'дилацеразия (трещины эмали)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (30, 24, N'K00.45', N'одонтодисплазия (региональная одонтодисплазия)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (31, 24, N'K00.46', N'зуб Тернера')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (32, 24, N'K00.48', N'другие уточнённые нарушения формирования зубов')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (33, 24, N'K00.49', N'нарушения формирования зубов неуточнённые')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (34, 0, N'K02', N'кариес зубов')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (35, 34, N'K02.0', N'кариес эмали стадия белого (мелового) пятна (начальный кариес)')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (36, 34, N'K02.1', N'кариес дентина')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (37, 34, N'K02.2', N'кариес цемента')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (38, 34, N'K02.3', N'приостановившийся кариес зубов')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (39, 34, N'K02.4', N'одонтоклазия детская меланодентия, меланодонтоклазия')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (40, 34, N'K02.8', N'другой уточнённый кариес зубов')
INSERT [dbo].[mkb_codes] ([ID], [ParentID], [Code], [Description]) VALUES (41, 34, N'K02.9', N'кариес зубов неуточнённый')
SET IDENTITY_INSERT [dbo].[mkb_codes] OFF
GO
SET IDENTITY_INSERT [dbo].[patients] ON 

INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (1, N'wefwefww', N'wefwefgggwww', CAST(N'2000-01-01' AS Date), N'asdas,апор', N'1')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (2, N'Владимир', N'Путин', CAST(N'1999-10-10' AS Date), N'Америка', N'3,4,5,6,7,8,9,10')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (3, N'AbobaNew', N'testNeww', CAST(N'2015-07-20' AS Date), N'test', N'3,4,5,6,7,8,9,10')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (4, N'Жмых', N'Индуса', CAST(N'2022-12-12' AS Date), N'test', N'1')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (5, N'Амогус', N'Украинский', CAST(N'1988-09-01' AS Date), N'test', N'1')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (6, N'Гитлер', N'Капут', CAST(N'1977-12-25' AS Date), N'Russia', N'1')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (7, N'Вася', N'Пупкин', CAST(N'0001-01-01' AS Date), N'test', N'1')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (8, N'Вася', N'Пупкин', CAST(N'0001-01-01' AS Date), N'test', N'1')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (9, N'Вася', N'Пупкин', CAST(N'0001-01-01' AS Date), N'test', N'1')
INSERT [dbo].[patients] ([id_patient], [patient_first_name], [patient_last_name], [date_of_birth], [allergy], [teeth_map]) VALUES (1009, N'test', N'patient', CAST(N'2022-04-01' AS Date), N'test', N'1')
SET IDENTITY_INSERT [dbo].[patients] OFF
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [FK_appointment_patients] FOREIGN KEY([patient_id])
REFERENCES [dbo].[patients] ([id_patient])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [FK_appointment_patients]
GO
ALTER TABLE [dbo].[med_history]  WITH CHECK ADD  CONSTRAINT [FK_med_history_consumables] FOREIGN KEY([consumable_id])
REFERENCES [dbo].[consumables] ([id_consumable])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[med_history] CHECK CONSTRAINT [FK_med_history_consumables]
GO
ALTER TABLE [dbo].[med_history]  WITH CHECK ADD  CONSTRAINT [FK_med_history_patients] FOREIGN KEY([patient_id])
REFERENCES [dbo].[patients] ([id_patient])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[med_history] CHECK CONSTRAINT [FK_med_history_patients]
GO
