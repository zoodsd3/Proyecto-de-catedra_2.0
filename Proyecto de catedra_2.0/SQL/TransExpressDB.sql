USE TransExpressDB;
GO

-- 2. Tabla Buses
CREATE TABLE Buses (
    BusID INT IDENTITY(1,1) PRIMARY KEY,
    RutaBus NVARCHAR(100) NOT NULL,
    NumeroUnidades INT NULL,
    HoraLlegada TIME NULL,
    HoraSalida TIME NULL,
    UnidadesDisponibles INT NULL,
    UnidadesFuera INT NULL,
    LugarSalida NVARCHAR(100) NULL,
    PuntoLlegada NVARCHAR(100) NULL
);

-- índice / restricción para evitar rutas duplicadas
CREATE UNIQUE INDEX UX_Buses_RutaBus ON Buses(RutaBus);

-- 3. Tabla Boletos
CREATE TABLE Boletos (
    BoletoID INT IDENTITY(1,1) PRIMARY KEY,
    ValorBoleto DECIMAL(10,2) NOT NULL,
    DestinoFinal NVARCHAR(100) NOT NULL,
    HoraSalida TIME NOT NULL,
    Ruta NVARCHAR(100) NOT NULL,
    FechaCompra DATETIME NOT NULL DEFAULT GETDATE()
);

-- 4. Insertar datos de ejemplo (opcional)
INSERT INTO Buses (RutaBus, NumeroUnidades, HoraLlegada, HoraSalida, UnidadesDisponibles, UnidadesFuera, LugarSalida, PuntoLlegada)
VALUES ('SanSalvador - SantaAna', 5, '08:00', '06:00', 4, 1, 'Terminal Centro', 'Terminal Santa Ana');

INSERT INTO Boletos (ValorBoleto, DestinoFinal, HoraSalida, Ruta)
VALUES (3.50, 'Santa Ana', '06:00', 'SanSalvador - SantaAna');
GO