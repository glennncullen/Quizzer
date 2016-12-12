CREATE TABLE [dbo].[User]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY,
	[username] NVARCHAR(MAX) NOT NULL, 
    [password] NVARCHAR(MAX) NOT NULL, 
    [historyHighScore] INT NULL, 
    [historyTime] DECIMAL NULL, 
    [scienceHighScore] INT NULL, 
    [scienceTime] DECIMAL NULL, 
    [geographyHighScore] INT NULL, 
    [geographyTime] DECIMAL NULL
)
