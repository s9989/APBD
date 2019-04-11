INSERT INTO apbd.Studies (Name) VALUES ('pja');

INSERT INTO apbd.Student (FirstName, LastNAme, Address, IndexNumber, IdStudies) VALUES 
('Jakub', 'Kuryłowicz', 'Warszawa', 's9989', (SELECT IdStudies FROM apbd.Studies WHERE Name = 'pja')),
('Andrzej', 'Piotrowicz', 'Gdańsk', 's9999', (SELECT IdStudies FROM apbd.Studies WHERE Name = 'pja'));