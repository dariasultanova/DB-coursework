USE MusicSalon

--1 vyvesti imena klientov, dogovory s kotorymi zaklyucheny v ukazannyj peroid
SELECT DISTINCT FIO FROM Clients
	JOIN Contracts On Contracts.Id=Clients.Id
	WHERE Contracts.DateOfDeal BETWEEN '2019-12-15' AND '2020-01-31'

--2 vyvesti imena klientov, s kotorymi ne zaklyuchen ni odin dogovor
SELECT Clients.FIO FROM Clients
	JOIN Contracts ON Contracts.Id=Clients.Id 
	WHERE Contracts.Number IS NULL

--3 vyvesti klientov, kotorye zaklyuchili minimum dva dogovora
SELECT Clients.FIO FROM Clients
	JOIN Contracts ON Contracts.Id=Clients.Id 
	GROUP BY FIO HAVING COUNT(FIO)>1

--4 vyvesti oborudovanie, arenda kotorogo deshevle 400
(SELECT Title, Cost FROM InstrumentsCost WHERE Cost<400)
UNION
(SELECT Title, Cost FROM EquipmentCost WHERE Cost<400)
UNION
(SELECT Title, Cost FROM HallsCost WHERE Cost<400)

--5 vyvesti slomannoe oborudovanie
(SELECT NumInst, Title FROM Instruments WHERE Ready=0)
UNION
(SELECT NumEq, Title FROM Equipment WHERE Ready=0)
UNION
(SELECT NumHall, Title FROM Halls WHERE Ready=0)

--6 vyvesti rabotnikov, kotorye zanyaty v ukazannyj den'
SELECT FIO FROM Staff
	WHERE Staff.Id IN 
	(SELECT Contents.Id FROM Contents
		JOIN Contracts ON Contents.Number=Contracts.Number
		WHERE Contracts.DateOfDeal='2020-01-26')