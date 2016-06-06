
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2016 11:36:52
-- Generated from EDMX file: C:\Users\roudry2\Desktop\CTEsP\GIT\DesemvolvimentoAplicacoes\Projeto_StandAuto\StandAuto\StandAuto\ModelDoProf.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [StandAuto];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParcelaSet'
CREATE TABLE [dbo].[ParcelaSet] (
    [IdParcela] int IDENTITY(1,1) NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoIdServicos] nvarchar(max)  NOT NULL,
    [Serviço_IdServicos] int  NOT NULL
);
GO

-- Creating table 'ServiçoSet'
CREATE TABLE [dbo].[ServiçoSet] (
    [IdServicos] int IDENTITY(1,1) NOT NULL,
    [DataEntrada] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [DtaSaida] nvarchar(max)  NOT NULL,
    [CarroOficinaIdCliente] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VendaSet'
CREATE TABLE [dbo].[VendaSet] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroVenda_IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarroSet'
CREATE TABLE [dbo].[CarroSet] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AluguerSet'
CREATE TABLE [dbo].[AluguerSet] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] nvarchar(max)  NOT NULL,
    [DataFim] nvarchar(max)  NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroAluguer_IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarroSet_CarroOficina'
CREATE TABLE [dbo].[CarroSet_CarroOficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarroSet_CarroVenda'
CREATE TABLE [dbo].[CarroSet_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarroSet_CarroAluguer'
CREATE TABLE [dbo].[CarroSet_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdParcela] in table 'ParcelaSet'
ALTER TABLE [dbo].[ParcelaSet]
ADD CONSTRAINT [PK_ParcelaSet]
    PRIMARY KEY CLUSTERED ([IdParcela] ASC);
GO

-- Creating primary key on [IdServicos] in table 'ServiçoSet'
ALTER TABLE [dbo].[ServiçoSet]
ADD CONSTRAINT [PK_ServiçoSet]
    PRIMARY KEY CLUSTERED ([IdServicos] ASC);
GO

-- Creating primary key on [IdVenda] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [PK_VendaSet]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet'
ALTER TABLE [dbo].[CarroSet]
ADD CONSTRAINT [PK_CarroSet]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [PK_AluguerSet]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet_CarroOficina'
ALTER TABLE [dbo].[CarroSet_CarroOficina]
ADD CONSTRAINT [PK_CarroSet_CarroOficina]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet_CarroVenda'
ALTER TABLE [dbo].[CarroSet_CarroVenda]
ADD CONSTRAINT [PK_CarroSet_CarroVenda]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet_CarroAluguer'
ALTER TABLE [dbo].[CarroSet_CarroAluguer]
ADD CONSTRAINT [PK_CarroSet_CarroAluguer]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdCliente] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[VendaSet]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'CarroSet_CarroOficina'
ALTER TABLE [dbo].[CarroSet_CarroOficina]
ADD CONSTRAINT [FK_ClienteCarroOficina]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarroOficina'
CREATE INDEX [IX_FK_ClienteCarroOficina]
ON [dbo].[CarroSet_CarroOficina]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [FK_ClienteAluguer]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAluguer'
CREATE INDEX [IX_FK_ClienteAluguer]
ON [dbo].[AluguerSet]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [Serviço_IdServicos] in table 'ParcelaSet'
ALTER TABLE [dbo].[ParcelaSet]
ADD CONSTRAINT [FK_ParcelaServiço]
    FOREIGN KEY ([Serviço_IdServicos])
    REFERENCES [dbo].[ServiçoSet]
        ([IdServicos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParcelaServiço'
CREATE INDEX [IX_FK_ParcelaServiço]
ON [dbo].[ParcelaSet]
    ([Serviço_IdServicos]);
GO

-- Creating foreign key on [CarroVenda_IdCarro] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([CarroVenda_IdCarro])
    REFERENCES [dbo].[CarroSet_CarroVenda]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[VendaSet]
    ([CarroVenda_IdCarro]);
GO

-- Creating foreign key on [CarroAluguer_IdCarro] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [FK_AluguerCarroAluguer]
    FOREIGN KEY ([CarroAluguer_IdCarro])
    REFERENCES [dbo].[CarroSet_CarroAluguer]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AluguerCarroAluguer'
CREATE INDEX [IX_FK_AluguerCarroAluguer]
ON [dbo].[AluguerSet]
    ([CarroAluguer_IdCarro]);
GO

-- Creating foreign key on [IdCarro] in table 'CarroSet_CarroOficina'
ALTER TABLE [dbo].[CarroSet_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarroSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'CarroSet_CarroVenda'
ALTER TABLE [dbo].[CarroSet_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarroSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'CarroSet_CarroAluguer'
ALTER TABLE [dbo].[CarroSet_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarroSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------