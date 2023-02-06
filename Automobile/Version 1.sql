USE master
GO

USE master
GO
IF EXISTS (SELECT 'True' FROM sys.databases WHERE name = 'Automobil')
   BEGIN
      DROP DATABASE Automobil
   END
GO   
create database Automobil
use Automobil
Go

--Tabela Tara
Create Table Tara
( IDTARA Int PRIMARY KEY
	,Denumire varchar(50)
)


--Tabela Firma
Create Table Firma
( IDFirma Int PRIMARY KEY
	,Denumire varchar(20)
	,IDTARA Int
)


--Tabela Auto
Create Table Automobil
( IDAuto Int PRIMARY KEY
	,IDFirma Int
	,Model varchar(20)
	,AnProducere Int
	,IDCuloare Int
	,CapCil Int
	,IDTipComb Int
	,Pret money
)


--Tabela Culoare
Create Table Culoare
( IDCuloare Int PRIMARY KEY
	,Denumire varchar(10)
)


--Tabela Combustibil
Create Table Combustibil
( IDTipComb Int PRIMARY KEY
	,Denumire varchar(20)
)


ALTER TABLE Automobil
   ADD CONSTRAINT FK_Automobil_IDCuloare
      FOREIGN KEY (IDCuloare) REFERENCES Culoare  (IDCuloare)
      
ALTER TABLE Automobil
	ADD CONSTRAINT FK_Automobil_IDTipComb
		FOREIGN KEY (IDTipComb) REFERENCES Combustibil (IDTipComb)


ALTER TABLE Automobil
   ADD CONSTRAINT FK_Automobil_IDFirma
      FOREIGN KEY (IDFirma) REFERENCES Firma  (IDFirma)

ALTER TABLE Firma
	ADD CONSTRAINT FK_Firma_IDTara
		FOREIGN KEY (IDTara) REFERENCES Tara (IDTara)
--Tabelul tarile 

INSERT INTO Tara(IDTARA,Denumire)
VALUES(1,'Germania');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(2,'Franta');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(3,'Japonia');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(4,'SUA');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(5,'Romania');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(6,'Rusia');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(7,'Suedia');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(8,'Englia');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(9,'China');
INSERT INTO Tara(IDTARA,Denumire)
VALUES(10,'Coreia');


--Tabele cu tipuri de firme de masini
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(1,'BMW',1);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(2,'Audi',1);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(3,'Opel',1);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(4,'Mercedes',1);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(5,'Volkswagen',1);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(6,'Renault',2);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(7,'Peugeot',2);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(8,'Citroen',2);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(9,'Mitsubishi',3);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(10,'Toyota',3);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(11,'Mazda',3);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(12,'Honda',3);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(13,'Dodge',4);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(14,'Ford',4);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(15,'Jeep',4);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(16,'Dacia',5);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(17,'Lada',6);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(18,'Volvo',7);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(19,'Rolls Royce',8);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(20,'Bentley',8);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(21,'Great Wall',9);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(22,'Kia',10);
INSERT INTO Firma(IDFirma,Denumire,IDTARA)
VALUES(23,'Hyundai',10);



--Tabelul cu tipuri de culori
INSERT INTO Culoare(IDCuloare,Denumire)
VALUES(1,'Rosu');
INSERT INTO Culoare(IDCuloare,Denumire)
VALUES(2,'Oranj');
INSERT INTO Culoare(IDCuloare,Denumire)
VALUES(3,'Galben');
INSERT INTO Culoare(IDCuloare,Denumire)
VALUES(4,'Verde');
INSERT INTO Culoare(IDCuloare,Denumire)
VALUES(5,'Albastru');
INSERT INTO Culoare(IDCuloare,Denumire)
VALUES(6,'Indigo');
INSERT INTO Culoare(IDCuloare,Denumire)
VALUES(7,'Violet');

--Tabelul Tipuri de combustibil
INSERT INTO Combustibil(IDTipComb,Denumire)
VALUES(1,'Diesel');
INSERT INTO Combustibil(IDTipComb,Denumire)
VALUES(2,'Benzin');
INSERT INTO Combustibil(IDTipComb,Denumire)
VALUES(3,'Benzin\Metan');
INSERT INTO Combustibil(IDTipComb,Denumire)
VALUES(4,'Benzin\Propan');
INSERT INTO Combustibil(IDTipComb,Denumire)
VALUES(5,'Hibrid');



--Tabel cu Marca BMW
Insert Into Automobil
values(1,1,'Series 3','2012',1,'3200',1,'25000');
Insert Into Automobil
values(2,1,'Series 4','2013',2,'3500',2,'35000');
Insert Into Automobil
values(3,1,'Series 5','2011',3,'5000',3,'40000');
Insert Into Automobil
values(4,1,'Series 6','2014',4,'5500',4,'55000');
Insert Into Automobil
values(5,1,'Series 7','2009',5,'6000',5,'90000');
Insert Into Automobil
values(6,1,'Series 8','2010',6,'5000',1,'110000');
Insert Into Automobil
values(7,1,'X3','2015',7,'3000',2,'25000');
Insert Into Automobil
values(8,1,'X5','2012',1,'4800',3,'29000');
Insert Into Automobil
values(9,1,'X6','2013',2,'6000',4,'37000');
Insert Into Automobil
values(10,1,'M5','2010',3,'5500',5,'250000');
--Tabelul cu Marca Audi
Insert Into Automobil
values(11,2,'A2','2012',1,'3200',1,'25000');
Insert Into Automobil
values(12,2,'A3','2013',2,'3500',2,'35000');
Insert Into Automobil
values(13,2,'A4','2011',3,'5000',3,'40000');
Insert Into Automobil
values(14,2,'A5','2014',4,'5500',4,'55000');
Insert Into Automobil
values(15,2,'A6','2009',5,'6000',5,'90000');
Insert Into Automobil
values(16,2,'A7','2010',6,'5000',1,'110000');
Insert Into Automobil
values(17,2,'A8','2015',7,'3000',2,'85000');
Insert Into Automobil
values(18,2,'Q3','2012',1,'4800',3,'29000');
Insert Into Automobil
values(19,2,'Q5','2013',2,'6000',4,'37000');
Insert Into Automobil
values(20,2,'Q7','2010',3,'5500',5,'200000');

--Tabelul cu Marca Opel
Insert Into Automobil
values(21,3,'Meriva','2012',1,'3200',1,'12000');
Insert Into Automobil
values(22,3,'Corsa','2013',2,'3500',2,'30000');
Insert Into Automobil
values(23,3,'Combo','2011',3,'5000',3,'35000');
Insert Into Automobil
values(24,3,'Omega','2014',4,'5500',4,'55000');
Insert Into Automobil
values(25,3,'Frontera','2009',5,'6000',5,'90000');
Insert Into Automobil
values(26,3,'Antara','2010',6,'5000',1,'110000');
Insert Into Automobil
values(27,3,'Vectra','2015',7,'3000',2,'85000');
Insert Into Automobil
values(28,3,'Astra','2012',1,'4800',3,'29000');
Insert Into Automobil
values(29,3,'Mokka','2013',2,'6000',4,'37000');
Insert Into Automobil
values(30,3,'Insignia','2010',3,'5500',5,'200000');
--Tabelul cu Marca Mercedes
Insert Into Automobil
values(31,4,'C Class','2012',1,'3200',1,'30000');
Insert Into Automobil
values(32,4,'E Class','2013',2,'3500',2,'40000');
Insert Into Automobil
values(33,4,'S Class','2011',3,'5000',3,'150000');
Insert Into Automobil
values(34,4,'Ml Class','2014',4,'5500',4,'55000');
Insert Into Automobil
values(35,4,'GL Class','2009',5,'6000',5,'120000');
Insert Into Automobil
values(36,4,'G Class','2010',6,'5000',1,'210000');
Insert Into Automobil
values(37,4,'GLE Class','2015',7,'3000',2,'85000');
Insert Into Automobil
values(38,4,'Viano','2012',1,'4800',3,'29000');
Insert Into Automobil
values(39,4,'Sprinter','2013',2,'6000',4,'37000');
Insert Into Automobil
values(40,4,'Sl Class','2010',3,'5500',5,'98000');
--Tabelul cu Marca Volkswagen
Insert Into Automobil
values(41,5,'Golf','2012',1,'3200',1,'30000');
Insert Into Automobil
values(42,5,'Passat','2013',2,'3500',2,'40000');
Insert Into Automobil
values(43,5,'Passat CC','2011',3,'5000',3,'150000');
Insert Into Automobil
values(44,5,'Jetta','2014',4,'5500',4,'55000');
Insert Into Automobil
values(45,5,'Vento','2009',5,'6000',5,'120000');
Insert Into Automobil
values(46,5,'Phaeton','2010',6,'5000',1,'210000');
Insert Into Automobil
values(47,5,'Crafter','2015',7,'3000',2,'85000');
Insert Into Automobil
values(48,5,'Amarok','2012',1,'4800',3,'29000');
Insert into Automobil
values(49,5,'Caravelle','2013',2,'6000',4,'37000');
Insert Into Automobil
values(50,5,'Touareg','2010',3,'5500',5,'98000');
--Tabelul cu Marca  Renault
Insert Into Automobil
values(51,6,'Clio','2012',1,'3200',1,'30000');
Insert Into Automobil
values(52,6,'Scenic','2013',2,'3500',2,'40000');
Insert Into Automobil
values(53,6,'Fluence','2011',3,'5000',3,'150000');
Insert Into Automobil
values(54,6,'Espace','2014',4,'5500',4,'55000');
Insert Into Automobil
values(55,6,'19','2009',5,'6000',5,'120000');
Insert Into Automobil
values(56,6,'21','2010',6,'5000',1,'210000');
Insert Into Automobil
values(57,6,'25','2015',7,'3000',2,'85000');
Insert Into Automobil
values(58,6,'Captur','2012',1,'4800',3,'29000');
Insert into Automobil
values(59,6,'Megan','2013',2,'6000',4,'37000');
Insert Into Automobil
values(60,6,'Laguna','2010',3,'5500',5,'98000');
--Tabelul cu Marca Peugeot
Insert Into Automobil
values(61,7,'206','2012',1,'3200',1,'30000');
Insert Into Automobil
values(62,7,'207','2013',2,'3500',2,'40000');
Insert Into Automobil
values(63,7,'208','2011',3,'5000',3,'30000');
Insert Into Automobil
values(64,7,'306','2014',4,'5500',4,'55000');
Insert Into Automobil
values(65,7,'307','2009',5,'6000',5,'40000');
Insert Into Automobil
values(66,7,'308','2010',6,'5000',1,'50000');
Insert Into Automobil
values(67,7,'406','2015',7,'3000',2,'85000');
Insert Into Automobil
values(68,7,'407','2012',1,'4800',3,'60000');
Insert into Automobil
values(69,7,'607','2013',2,'6000',4,'80000');
Insert Into Automobil
values(70,7,'806','2010',3,'5500',5,'98000');
--Tabelul cu Marca Toyota
Insert Into Automobil
values(71,10,'Carolla','2012',1,'3200',1,'30000');
Insert Into Automobil
values(72,10,'Avensis','2013',2,'3500',2,'40000');
Insert Into Automobil
values(73,10,'Crown','2011',3,'5000',3,'30000');
Insert Into Automobil
values(74,10,'FJ Cruiser','2014',4,'5500',4,'55000');
Insert Into Automobil
values(75,10,'Hilux','2009',5,'6000',5,'40000');
Insert Into Automobil
values(76,10,'Land Cruiser','2010',6,'5000',1,'50000');
Insert Into Automobil
values(77,10,'Land Cruiser Prado','2015',7,'3000',2,'85000');
Insert Into Automobil
values(78,10,'Rav4','2012',1,'4800',3,'60000');
Insert into Automobil
values(79,10,'Tundra','2013',2,'6000',4,'80000');
Insert Into Automobil
values(80,10,'Supra','2010',3,'5500',5,'98000');
--Tabelul cu Marca Mitsubishi
Insert Into Automobil
values(81,9,'Colt','2012',1,'3200',1,'30000');
Insert Into Automobil
values(82,9,'Eclipse','2013',2,'3500',2,'40000');
Insert Into Automobil
values(83,9,'Galant','2011',3,'5000',3,'30000');
Insert Into Automobil
values(84,9,'Lancer','2014',4,'5500',4,'55000');
Insert Into Automobil
values(85,9,'L Series','2009',5,'6000',5,'40000');
Insert Into Automobil
values(86,9,'Outlander','2010',6,'5000',1,'50000');
Insert Into Automobil
values(87,9,'Pajero','2015',7,'3000',2,'85000');
Insert Into Automobil
values(88,9,'Pajero Sport','2012',1,'4800',3,'60000');
Insert into Automobil
values(89,9,'Raider','2013',2,'6000',4,'80000');
Insert Into Automobil
values(90,9,'Sigma','2010',3,'5500',5,'98000');
--Tabelul cu Marca Dodge
Insert Into Automobil
values(91,13,'Avenger','2012',1,'3200',1,'30000');
Insert Into Automobil
values(92,13,'Challenger','2013',2,'3500',2,'40000');
Insert Into Automobil
values(93,13,'Charger','2011',3,'5000',3,'30000');
Insert Into Automobil
values(94,13,'Magnum','2014',4,'5500',4,'55000');
Insert Into Automobil
values(95,13,'Neon','2009',5,'6000',5,'40000');
Insert Into Automobil
values(96,13,'Ram','2010',6,'5000',1,'50000');
Insert Into Automobil
values(97,13,'Stratus','2015',7,'3000',2,'85000');
Insert Into Automobil
values(98,13,'Viper','2012',1,'4800',3,'60000');
Insert into Automobil
values(99,13,'Caliber','2013',2,'6000',4,'80000');
Insert Into Automobil
values(100,13,'Dakota','2010',3,'5500',5,'98000');
--Tabelul cu Marca Citroen
Insert Into Automobil
values(101,8,'Berligo','2009',2,'3200',2,'30000');
Insert Into Automobil
values(102,8,'C-Crosser','2013',1,'3500',1,'40000');
Insert Into Automobil
values(103,8,'C1','2011',3,'5000',3,'30000');
Insert Into Automobil
values(104,8,'C2','2014',4,'5500',4,'55000');
Insert Into Automobil
values(105,8,'C3','2009',5,'6000',5,'40000');
Insert Into Automobil
values(106,8,'C4','2010',6,'5000',1,'50000');
Insert Into Automobil
values(107,8,'C6','2015',7,'3000',2,'85000');
Insert Into Automobil
values(108,8,'DS3','2012',1,'4800',3,'60000');
Insert into Automobil
values(109,8,'Jumper','2013',2,'6000',4,'80000');
Insert Into Automobil
values(110,8,'Nemo','2010',3,'5500',5,'98000');
--Tabelul cu Marca Mazda
Insert Into Automobil
values(111,11,'2','2012',1,'3200',1,'30000');
Insert Into Automobil
values(112,11,'3','2013',2,'3500',2,'40000');
Insert Into Automobil
values(113,11,'5','2011',3,'5000',3,'30000');
Insert Into Automobil
values(114,11,'6','2014',4,'5500',4,'55000');
Insert Into Automobil
values(115,11,'CX-7','2009',5,'6000',5,'40000');
Insert Into Automobil
values(116,11,'MX-5','2010',6,'5000',1,'50000');
Insert Into Automobil
values(117,11,'RX-8','2015',7,'3000',2,'85000');
Insert Into Automobil
values(118,11,'BT-50','2012',1,'4800',3,'60000');
Insert Into Automobil
--Tabelul cu Marca Honda
values(121,12,'Accord','2012',1,'3200',1,'30000');
Insert Into Automobil
values(122,12,'Civic','2013',2,'3500',2,'40000');
Insert Into Automobil
values(123,12,'CR-V','2011',3,'5000',3,'30000');
Insert Into Automobil
values(124,12,'FR-V','2014',4,'5500',4,'55000');
Insert Into Automobil
values(125,12,'Jazz','2009',5,'6000',5,'40000');
Insert Into Automobil
values(126,12,'Insight','2010',6,'5000',1,'50000');
Insert Into Automobil
values(127,12,'Legend','2015',7,'3000',2,'85000');
--Tabelul cu Marca Ford
Insert Into Automobil
values(131,14,'C-Max','2012',1,'3200',1,'30000');
Insert Into Automobil
values(132,14,'Fiesta','2013',2,'3500',2,'40000');
Insert Into Automobil
values(133,14,'Focus','2011',3,'5000',3,'30000');
Insert Into Automobil
values(134,14,'Fusio','2014',4,'5500',4,'55000');
Insert Into Automobil
values(135,14,'Galaxy','2009',5,'6000',5,'40000');
Insert Into Automobil
values(136,14,'Ka','2010',6,'5000',1,'50000');
Insert Into Automobil
values(137,14,'Kuga','2015',7,'3000',2,'85000');
Insert Into Automobil
values(138,14,'Modeo','2012',1,'4800',3,'60000');
Insert into Automobil
values(139,14,'Ranger','2013',2,'6000',4,'80000');
Insert Into Automobil
values(140,14,'S-Max','2010',3,'5500',5,'98000');
--Tabelul cu Marca Jeep
Insert Into Automobil
values(141,15,'Cherokee','2012',1,'3200',1,'30000');
Insert Into Automobil
values(142,15,'Commander','2013',2,'3500',2,'40000');
Insert Into Automobil
values(143,15,'Compass','2011',3,'5000',3,'30000');
Insert Into Automobil
values(144,15,'Patriot','2014',4,'5500',4,'55000');
Insert Into Automobil
values(145,15,'Wrangler','2009',5,'6000',5,'40000');
--Tabelul Marca Dacia
Insert Into Automobil
values(151,16,'Duster','2012',1,'3200',1,'30000');
Insert Into Automobil
values(152,16,'Logan','2013',2,'3500',2,'40000');
Insert Into Automobil
values(153,16,'Logam MCV','2011',3,'5000',3,'30000');
Insert Into Automobil
values(154,16,'Logan Pick-up','2014',4,'5500',4,'55000');
Insert Into Automobil
values(155,16,'Logan Van','2009',5,'6000',5,'40000');
Insert Into Automobil
values(156,16,'Sandero','2010',6,'5000',1,'50000');
--Tabelul Marca Lada
Insert Into Automobil
values(161,17,'2106','2012',1,'3200',1,'30000');
Insert Into Automobil
values(162,17,'2107','2013',2,'3500',2,'40000');
Insert Into Automobil
values(163,17,'2108','2011',3,'5000',3,'30000');
Insert Into Automobil
values(164,17,'Priora','2014',4,'5500',4,'55000');
Insert Into Automobil
values(165,17,'Vesta','2009',5,'6000',5,'40000');
Insert Into Automobil
values(166,17,'Xray','2010',6,'5000',1,'50000');
Insert Into Automobil
values(167,17,'Niva Urban','2015',7,'3000',2,'85000');
Insert Into Automobil
values(168,17,'Niva','2012',1,'4800',3,'60000');
Insert into Automobil
values(169,17,'2101','2013',2,'6000',4,'80000');
Insert Into Automobil
values(170,17,'2102','2010',3,'5500',5,'98000');
--Tabelul Marca Volvo
Insert Into Automobil
values(171,7,'C30','2012',1,'3200',1,'30000');
Insert Into Automobil
values(172,7,'C70','2013',2,'3500',2,'40000');
Insert Into Automobil
values(173,7,'S40','2011',3,'5000',3,'30000');
Insert Into Automobil
values(174,7,'S60','2014',4,'5500',4,'55000');
Insert Into Automobil
values(175,7,'S80','2009',5,'6000',5,'40000');
Insert Into Automobil
values(176,7,'V50','2010',6,'5000',1,'50000');
Insert Into Automobil
values(177,7,'V70','2015',7,'3000',2,'85000');
Insert Into Automobil
values(178,7,'XC60','2012',1,'4800',3,'60000');
Insert into Automobil
values(179,7,'XC70','2013',2,'6000',4,'80000');
Insert Into Automobil
values(180,7,'XC90','2010',3,'5500',5,'98000');
--Tabelul Marca Rolls
Insert Into Automobil
values(181,19,'Ghost','2012',1,'3200',1,'30000');
Insert Into Automobil
values(182,19,'Phantom','2013',2,'3500',2,'40000');
--Tabelul Marca Bentley
Insert Into Automobil
values(183,20,'Arnage','2015',2,'3700',1,'30000');
Insert Into Automobil
values(184,20,'Continental','2016',3,'3800',2,'40000');
--Tabelul Marca Great Wall
Insert Into Automobil
values(185,21,'C50','2016',1,'5000',1,'30000');
Insert Into Automobil
values(186,21,'C30','2015',2,'4000',2,'40000');
Insert Into Automobil
values(187,21,'H6','2011',3,'5000',3,'30000');
Insert Into Automobil
values(188,21,'H5-E','2014',4,'5500',4,'55000');
Insert Into Automobil
values(189,21,'M4','2009',5,'6000',5,'40000');
Insert Into Automobil
values(190,21,'5','2010',6,'5000',1,'50000');
Insert Into Automobil
values(191,21,'6','2015',7,'3000',2,'85000');

--Tabelul Marca Kia
Insert Into Automobil
values(201,22,'Carens','2012',1,'3200',1,'30000');
Insert Into Automobil
values(202,22,'Carnival','2013',2,'3500',2,'40000');
Insert Into Automobil
values(203,22,'Cerato','2011',3,'5000',3,'30000');
Insert Into Automobil
values(204,22,'Rio','2014',4,'5500',4,'55000');
Insert Into Automobil
values(205,22,'Sorento','2009',5,'6000',5,'40000');
Insert Into Automobil
values(206,22,'Venga','2010',6,'5000',1,'50000');
Insert Into Automobil
values(207,22,'Soul','2015',7,'3000',2,'85000');
Insert Into Automobil
values(208,22,'Sportage','2012',1,'4800',3,'60000');
Insert into Automobil
values(209,22,'Picanto','2013',2,'6000',4,'80000');
Insert Into Automobil
values(210,22,'Magentis','2010',3,'5500',5,'98000');
Insert Into Automobil
values(211,22,'Opirus','2012',1,'3200',1,'30000');
Insert Into Automobil
values(212,22,'K2900','2013',2,'3500',2,'40000');
--Tabelul Marca Hyundai
Insert Into Automobil
values(201,23,'Accent','2012',1,'3200',1,'30000');
Insert Into Automobil
values(202,23,'Coupe','2013',2,'3500',2,'40000');
Insert Into Automobil
values(203,23,'Getz','2011',3,'5000',3,'30000');
Insert Into Automobil
values(204,23,'Grandeur','2014',4,'5500',4,'55000');
Insert Into Automobil
values(205,23,'H-1','2009',5,'6000',5,'40000');
Insert Into Automobil
values(206,23,'I10','2010',6,'5000',1,'50000');
Insert Into Automobil
values(207,23,'Sonata','2015',7,'3000',2,'85000');
Insert Into Automobil
values(208,23,'IX35','2012',1,'4800',3,'60000');
Insert into Automobil
values(209,23,'Santa Fe','2013',2,'6000',4,'80000');
Insert Into Automobil
values(210,23,'Tucson','2010',3,'5500',5,'98000');
Insert Into Automobil
values(211,23,'Veracruz','2012',1,'3200',1,'30000');
Insert Into Automobil
values(212,23,'I30','2013',2,'3500',2,'40000');





go
Create Procedure Ex3 AS
SELECT        Firma.Denumire AS Firma, Tara.Denumire AS Tara, Automobil.Model, Automobil.AnProducere, Automobil.CapCil, Combustibil.Denumire AS Combustibil, Culoare.Denumire AS Culoare, Automobil.Pret
FROM            Automobil INNER JOIN
                         Combustibil ON Automobil.IDTipComb = Combustibil.IDTipComb INNER JOIN
                         Culoare ON Automobil.IDCuloare = Culoare.IDCuloare INNER JOIN
                         Firma ON Automobil.IDFirma = Firma.IDFirma INNER JOIN
                         Tara ON Firma.IDTARA = Tara.IDTARA		
						 Order By Firma.Denumire,Automobil.Model Asc
						 go
		use Automobil				 
Select * From Combustibil
						 

Delete From Automobil where IDAuto=2

Select AVG(Automobil.Pret) as Medie
	from Automobil inner join Firma
		on firma.IDFirma=Automobil.IDFirma
			inner join Tara
			on Tara.IDTARA=Firma.IDTARA
			where Tara.Denumire='Germania'
go
Create Procedure Ex51 AS
SELECT        Firma.Denumire AS Firma, Tara.Denumire AS Tara, Automobil.Model, Automobil.AnProducere, Automobil.CapCil, Combustibil.Denumire AS Combustibil,Automobil.Pret
FROM            Automobil INNER JOIN
                         Combustibil ON Automobil.IDTipComb = Combustibil.IDTipComb INNER JOIN
                         Culoare ON Automobil.IDCuloare = Culoare.IDCuloare INNER JOIN
                         Firma ON Automobil.IDFirma = Firma.IDFirma INNER JOIN
                         Tara ON Firma.IDTARA = Tara.IDTARA	
						 where Culoare.Denumire='Verde' and Automobil.Pret=(select min(Automobil.Pret) as PretMin
																				from Automobil inner join Culoare
																				on Automobil.IDCuloare=Culoare.IDCuloare
																				where Culoare.Denumire='Verde')
																				go
Create Procedure Ex52 AS
SELECT        Firma.Denumire AS Firma, Tara.Denumire AS Tara, Automobil.Model, Automobil.AnProducere, Automobil.CapCil, Combustibil.Denumire AS Combustibil,Automobil.Pret
FROM            Automobil INNER JOIN
                         Combustibil ON Automobil.IDTipComb = Combustibil.IDTipComb INNER JOIN
                         Culoare ON Automobil.IDCuloare = Culoare.IDCuloare INNER JOIN
                         Firma ON Automobil.IDFirma = Firma.IDFirma INNER JOIN
                         Tara ON Firma.IDTARA = Tara.IDTARA	
						 where Culoare.Denumire='Verde' and Automobil.Pret=(select max(Automobil.Pret) as PretMin
																				from Automobil inner join Culoare
																				on Automobil.IDCuloare=Culoare.IDCuloare
		
																				where Culoare.Denumire='Verde')
	
	go
	Create Procedure ex6 as
	select Firma.Denumire,count(Automobil.model) as MAXIM
	from Automobil inner join Firma
	on Firma.IDFirma=Automobil.IDFirma
	group by firma.Denumire
	having count(Automobil.Model)=
	(Select max(MAXIM)
		from (select Firma.Denumire, count(Automobil.model) as MAXIM
	from Automobil inner join Firma
	on Firma.IDFirma=Automobil.IDFirma
	group by firma.Denumire)
	as t1)
	
	go
	Create Procedure ex6_1 as
	select count(Automobil.model),Firma.Denumire as MAXIM
	from Automobil inner join Firma
	on Firma.IDFirma=Automobil.IDFirma
	group by firma.Denumire
	having count(Automobil.Model)=
	(Select max(MAXIM)
		from (select Firma.Denumire, count(Automobil.model) as MAXIM
	from Automobil inner join Firma
	on Firma.IDFirma=Automobil.IDFirma
	group by firma.Denumire)
	as t1)
	go

	create procedure exerciti7 as
	Create Table Exercitiul7
	( idAuto int primary key,
		model varchar(20),
		firma varchar(20),
		tara varchar(20),
		AnProducere int,
		culoare varchar(20),
		capcil int,
		combustibil varchar(20),
		pret money)

	select * from Exercitiul7
	go
create procedure proba1 as
	SELECT        Firma.Denumire AS Firma, Tara.Denumire AS Tara, Automobil.Model, Automobil.AnProducere,Culoare.Denumire, Automobil.CapCil, Combustibil.Denumire AS Combustibil,Automobil.Pret
FROM            Automobil INNER JOIN
                         Combustibil ON Automobil.IDTipComb = Combustibil.IDTipComb INNER JOIN
                         Culoare ON Automobil.IDCuloare = Culoare.IDCuloare INNER JOIN
                         Firma ON Automobil.IDFirma = Firma.IDFirma INNER JOIN
                         Tara ON Firma.IDTARA = Tara.IDTARA	
						 where UPPER(Firma.Denumire)='AUDI' or UPPER(Firma.Denumire)='BMW'
						 order by firma.Denumire

						 drop procedure proba1


SELECT        Firma.Denumire AS Firma, Tara.Denumire AS Tara, Automobil.Model, Automobil.AnProducere,Culoare.Denumire, Automobil.CapCil, Combustibil.Denumire AS Combustibil,Automobil.Pret
FROM            Automobil INNER JOIN
                         Combustibil ON Automobil.IDTipComb = Combustibil.IDTipComb INNER JOIN
                         Culoare ON Automobil.IDCuloare = Culoare.IDCuloare INNER JOIN
                         Firma ON Automobil.IDFirma = Firma.IDFirma INNER JOIN
                         Tara ON Firma.IDTARA = Tara.IDTARA	
						 where pret<500000
						 order by firma.Denumire



create table Pass
(loghin varchar(20),passw varchar(20))
insert into pass values('123', '123')
go
create procedure logh as
select loghin from pass

go
create procedure pas as
select passw from Pass