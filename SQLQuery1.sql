CREATE TABLE [dbo].[JobData] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [TitleCompany]      NVARCHAR(255)  NOT NULL,   
    [ClosingType]       NVARCHAR(255)  NOT NULL, 
    [InternalReference] NVARCHAR(MAX)  NOT NULL,
    [KBARequired]       BIT            NOT NULL, 
    [PropertyAddress1]  NVARCHAR(MAX)  NOT NULL,
    [PropertyAddress2]  NVARCHAR(MAX)  NOT NULL,
    [PropertyCity]      NVARCHAR(MAX)  NOT NULL,
    [PropertyState]     NVARCHAR(MAX)  NOT NULL,
    [PropertyZipCode]   NVARCHAR(MAX)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
