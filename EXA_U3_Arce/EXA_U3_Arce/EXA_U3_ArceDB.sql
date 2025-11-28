CREATE DATABASE EXA_U3_ArceDB;
GO
USE EXA_U3_ArceDB;
GO
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Rol NVARCHAR(10) NOT NULL
);
GO
INSERT INTO Usuarios (Username, Password, Rol) VALUES ('admin', 'admin123', 'admin');
INSERT INTO Usuarios (Username, Password, Rol) VALUES ('user', 'user123', 'user');
GO