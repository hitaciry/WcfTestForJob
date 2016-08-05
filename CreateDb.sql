CREATE TABLE [dbo].[type_client](
	[id] [int] IDENTITY(1,1) NOT NULL, /* Id типа клиента */
	[name] [varchar](50) NOT NULL, /* наменование типа */
	CONSTRAINT [PK_type_client] PRIMARY KEY CLUSTERED ([id] ASC)
)
go
CREATE TABLE [dbo].[client](
	[id] [int] IDENTITY(1,1) NOT NULL, /* id клиента */
	[inn] [varchar](12) NOT NULL, /* ИНН клиента */
	[name] [varchar](150) NOT NULL, /* Наименование клиента */
	[type] [int] NOT NULL, /* id типа клиента */
	[date_contract] [datetime] NOT NULL, /* Дата заключения договора */
	[contacts] [varchar](max) NOT NULL, /* Контактные данные */
	CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED (	[id] ASC)
)
go
ALTER TABLE [dbo].[client] ADD  CONSTRAINT [fk_Client__type] FOREIGN KEY([type])
REFERENCES [dbo].[type_client] ([id])
go
CREATE UNIQUE NONCLUSTERED INDEX IX_client_inn ON client(inn)
go
insert into [type_client] (name)
values ('физ. лицо'),('юр. лицо'),('прочие');
