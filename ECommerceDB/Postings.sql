CREATE TABLE [dbo].[Postings]
(
	[PostingId] INT NOT NULL IDENTITY(1,1), 
    [SellerNum] INT NOT NULL, 
    [ItemNum] INT NOT NULL, 
    FOREIGN KEY ([SellerNum]) REFERENCES [Participants]([ParticipantId]), 
    FOREIGN KEY ([ItemNum]) REFERENCES [Items]([ItemId]) on delete cascade, 
    CONSTRAINT [PK_Postings] PRIMARY KEY ([PostingId]) 
)
