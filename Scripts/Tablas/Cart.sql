IF NOT EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[Carts]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
	/* Create Tables */
	--Almacena los diferentes carritos dados de alta en el sistema
	CREATE TABLE [dbo].[Carts]
	(
		[Id]			INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Identificador �nico del carrito
		[Created_At]	DATETIME NOT NULL DEFAULT GETDATE(), --Fecha de creaci�n del carrito
		[Updated_At]	DATETIME NOT NULL DEFAULT GETDATE() --Fecha de �ltima actualizaci�n del carrito
	)
END


/* Create Table Comments */
IF EXISTS (SELECT * FROM ::fn_listextendedproperty ('MS_Description', 'SCHEMA', 'dbo', 'table', 'Carts', NULL, NULL))
BEGIN
  EXEC sys.sp_updateextendedproperty 'MS_Description', 'Almacena los diferentes carritos dados de alta en el sistema', 'SCHEMA', 'dbo', 'table', 'Carts'
END 
ELSE
BEGIN
  EXEC sys.sp_addextendedproperty 'MS_Description', 'Almacena los diferentes carritos dados de alta en el sistema', 'SCHEMA', 'dbo', 'table', 'Carts'
END
GO


/*  Comentarios para las columnas */
-- Descripci�n para la columna Id
IF NOT EXISTS (SELECT * 
               FROM ::fn_listextendedproperty ('MS_Description', 'SCHEMA', 'dbo', 'table', 'Carts', 'column', 'Id'))
    EXEC sp_addextendedproperty 'MS_Description', 'Identificador �nico del carrito', 'Schema', 'dbo', 'table', 'Carts', 'column', 'Id';

-- Descripci�n para la columna Created_At
IF NOT EXISTS (SELECT * 
               FROM ::fn_listextendedproperty ('MS_Description', 'SCHEMA', 'dbo', 'table', 'Carts', 'column', 'Created_At'))
    EXEC sp_addextendedproperty 'MS_Description', 'Fecha de creaci�n del carrito', 'Schema', 'dbo', 'table', 'Carts', 'column', 'Created_At';

-- Descripci�n para la columna Updated_At
IF NOT EXISTS (SELECT * 
               FROM ::fn_listextendedproperty ('MS_Description', 'SCHEMA', 'dbo', 'table', 'Carts', 'column', 'Updated_At'))
    EXEC sp_addextendedproperty 'MS_Description', 'Fecha de �ltima actualizaci�n del carrito', 'Schema', 'dbo', 'table', 'Carts', 'column', 'Updated_At';
