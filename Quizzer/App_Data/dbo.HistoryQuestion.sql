CREATE TABLE [dbo].[HistoryQuestion]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [createdBy] NVARCHAR(MAX) NULL, 
    [question] NVARCHAR(MAX) NOT NULL, 
    [answerOne] NVARCHAR(MAX) NOT NULL, 
    [answerTwo] NVARCHAR(MAX) NOT NULL, 
    [answerThree] NVARCHAR(MAX) NOT NULL, 
    [answerFour] NVARCHAR(MAX) NOT NULL, 
    [correctAnswer] NVARCHAR(MAX) NOT NULL
)
