CREATE TABLE [dbo].[Member]
(
	[Member_Id] INT NOT NULL PRIMARY KEY, 
    [Group_Id] INT NULL, 
    [Member_Name] NVARCHAR(50) NULL, 
    [Score] INT NULL
)
