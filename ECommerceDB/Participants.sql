CREATE TABLE [dbo].[Participants]
(
	[ParticipantId] INT NOT NULL IDENTITY(1,1), 
    [Balance] MONEY NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY ([ParticipantId]), 
)
