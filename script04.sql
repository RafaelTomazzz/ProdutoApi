IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230620124906_InitialCreate', N'7.0.7');
GO

COMMIT;
GO

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

BEGIN TRANSACTION;
GO

ALTER TABLE [Produtos] ADD [Validade] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

UPDATE [Produtos] SET [Validade] = '2023-12-05T00:00:00.0000000'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Produtos] SET [Validade] = '2023-10-20T00:00:00.0000000'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Produtos] SET [Validade] = '2024-10-10T00:00:00.0000000'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Produtos] SET [Validade] = '2024-01-27T00:00:00.0000000'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230621003015_MigracaoValidade', N'7.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [Produtos] SET [Validade] = '2023-05-12T00:00:00.0000000'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Produtos] SET [Validade] = '2023-09-08T00:00:00.0000000'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Produtos] SET [Validade] = '2024-01-01T00:00:00.0000000'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230621011203_MigracaoValidade02', N'7.0.7');
GO

COMMIT;
GO

