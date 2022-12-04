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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221130153824_migration-1')
BEGIN
    CREATE TABLE [client] (
        [Id] int NOT NULL IDENTITY,
        [name] nvarchar(max) NOT NULL,
        [LasName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_client] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221130153824_migration-1')
BEGIN
    CREATE TABLE [vehicle] (
        [Id] int NOT NULL IDENTITY,
        [Brand] nvarchar(max) NOT NULL,
        [Model] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_vehicle] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221130153824_migration-1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221130153824_migration-1', N'6.0.11');
END;
GO

COMMIT;
GO

