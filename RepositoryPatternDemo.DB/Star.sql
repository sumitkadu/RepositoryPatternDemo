CREATE TABLE [dbo].[Star]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(30) NULL, 
    [Surname] VARCHAR(30) NULL, 
    [Nationality] VARCHAR(30) NULL, 
    [BirthDate] DATETIME NULL, 
    [WonNationalAward] BIT NULL
)
