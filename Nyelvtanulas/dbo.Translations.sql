CREATE TABLE [dbo].[Translations] (
    [Translated_Language]  NVARCHAR (50) NOT NULL,
    [Translation_Language] NVARCHAR (50) NOT NULL,
    [Translated_Word]      NVARCHAR (50) NOT NULL,
    [Translation]          NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Translated_Language],[Translation_Language],[Translated_Word],[Translation] ASC)
);

