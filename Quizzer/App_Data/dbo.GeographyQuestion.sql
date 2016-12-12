CREATE TABLE [dbo].[GeographyQuestion] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [createdBy]     NVARCHAR (MAX) NULL,
    [question]      NVARCHAR (MAX) NOT NULL,
    [answerOne]     NVARCHAR (MAX) NOT NULL,
    [answerTwo]     NVARCHAR (MAX) NOT NULL,
    [answerThree]   NVARCHAR (MAX) NOT NULL,
    [answerFour]    NVARCHAR (MAX) NOT NULL,
    [correctAnswer] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

