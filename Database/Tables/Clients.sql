CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),

	[FirstName] NVARCHAR (127),

	[LastNane] NVARCHAR(127),

	[PhoneNumber] NVARCHAR(16),

	[NIP] NVARCHAR(16),

	[Address] NVARCHAR(256)
	
)
