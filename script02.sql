BEGIN TRANSACTION;
GO

CREATE TABLE [Produtos] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Valor] int NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome', N'Valor') AND [object_id] = OBJECT_ID(N'[Produtos]'))
    SET IDENTITY_INSERT [Produtos] ON;
INSERT INTO [Produtos] ([Id], [Nome], [Valor])
VALUES (1, N'Produto01', 20),
(2, N'Produto02', 30),
(3, N'Produto03', 5),
(4, N'Produto04', 50);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome', N'Valor') AND [object_id] = OBJECT_ID(N'[Produtos]'))
    SET IDENTITY_INSERT [Produtos] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230620171511_MigracaoProduto', N'7.0.7');
GO

COMMIT;
GO

