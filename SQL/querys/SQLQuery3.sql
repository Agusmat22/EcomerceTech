create table Producto(
Id INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(60) NOT NULL,
Precio FLOAT NULL,
Tipo VARCHAR(60) NOT NULL,
Stock INT NULL,

)

INSERT INTO Producto (Nombre,Precio,Tipo,Stock) VALUES ('Notebook Lenovo',500,'notebook',50 )

INSERT INTO Producto (Nombre,Precio,Tipo,Stock) VALUES ('Iphone 15',2500.99,'smartphone',3 )


INSERT INTO Producto (Nombre,Precio,Tipo,Stock) VALUES ('Samsung Led 52',1899.99,'tv',50 )