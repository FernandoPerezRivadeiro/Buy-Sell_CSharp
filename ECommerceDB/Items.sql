CREATE TABLE [dbo].[Items]
(
	[ItemName] NVARCHAR(50) NOT NULL, 
    [ItemPrice] MONEY NOT NULL, 
    [ItemCategory] NVARCHAR(50) NOT NULL, 
    [ItemId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Status] INT NOT NULL, 
)
