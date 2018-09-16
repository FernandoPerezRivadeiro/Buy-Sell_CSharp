CREATE TABLE [dbo].[Orders]
(
	[BuyerNum] INT NOT NULL , 
    [ItemNum] INT NOT NULL  , 
    [OrderId] INT NOT NULL IDENTITY(1,1), 
    FOREIGN KEY ([BuyerNum]) REFERENCES [Participants]([ParticipantId]), 
    FOREIGN KEY ([ItemNum]) REFERENCES [Items]([ItemId]) on delete cascade, 
    CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId]) 
)
