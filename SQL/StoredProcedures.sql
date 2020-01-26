USE MusicSalon
GO
--dlya klientov
--Pokazat' preiskurant
CREATE PROCEDURE Pricelist AS
SELECT Title, Cost From HallsCost
UNION
SELECT Title, Cost From InstrumentsCost
UNION
SELECT Title, Cost From EquipmentCost
UNION
SELECT Post, Pay From Jobs

EXEC Pricelist
GO

--dobavit' dogovor
CREATE PROCEDURE AddDeal(@Nick AS varchar(20), @Day AS Date, @TimeB AS Time, @TimeE AS Time)
AS
declare @id AS int
SELECT @id=Id FROM Clients WHERE Nickname=@Nick
INSERT INTO Contracts (DateOfDeal, TimeOfBegin, TimeOfEnd, Id) VALUES (@Day, @TimeB, @TimeE, @id)

EXEC AddDeal 'lennon', '2020-01-29', '12:00', '16:00'
GO

--dobavit' soderzhanie
CREATE PROCEDURE AddContent(@deal AS int, @type AS int, @title AS varchar(50))
AS
declare @id AS int
declare @timeB AS time
declare @timeE AS time
declare @day AS date
SELECT @timeB=TimeOfBegin, @timeE=TimeOfEnd, @day=DateOfDeal FROM Contracts WHERE Number=@deal
IF @type=0 begin 
SELECT TOP 1 @id=Halls.NumHall FROM Halls WHERE Halls.Title=@title AND Halls.Ready=1 AND NOT EXISTS
	(SELECT Halls.NumHall FROM Halls 
		JOIN Contents ON Halls.NumHall=Contents.NumHall AND Contents.NumHall IS NOT NULL 
			AND Halls.Title=@title AND Halls.Ready=1
		JOIN Contracts ON Contracts.Number=Contents.Number AND Contracts.DateOfDeal = @day 
			AND NOT (@timeB<Contracts.TimeOfBegin AND @timeE<Contracts.TimeOfEnd 
			OR @timeB>Contracts.TimeOfBegin AND @timeE>Contracts.TimeOfEnd))
ORDER BY NEWID()
IF @id is NOT NULL INSERT INTO Contents (NumHall, Number) VALUES (@id, @deal)
end
IF @type=1 begin 
SELECT TOP 1 @id=Instruments.NumInst FROM Instruments WHERE Instruments.Title=@title AND Instruments.Ready=1 AND NOT EXISTS
	(SELECT Instruments.NumInst FROM Instruments 
		JOIN Contents ON Instruments.NumInst=Contents.NumInst AND Contents.NumInst IS NOT NULL 
			AND Instruments.Title=@title AND Instruments.Ready=1
		JOIN Contracts ON Contents.Number=Contracts.Number AND Contracts.DateOfDeal= @day 
			AND NOT (@timeB<Contracts.TimeOfBegin AND @timeE<Contracts.TimeOfEnd 
			OR @timeB>Contracts.TimeOfBegin AND @timeE>Contracts.TimeOfEnd))
ORDER BY NEWID()
IF @id is NOT NULL INSERT INTO Contents (NumInst, Number) VALUES (@id, @deal)
end
IF @type=2 begin 
SELECT TOP 1 @id=Equipment.NumEq FROM Equipment WHERE Equipment.Title=@title AND Equipment.Ready=1 AND NOT EXISTS
	(SELECT Equipment.NumEq FROM Equipment 
		JOIN Contents ON Equipment.NumEq=Contents.NumEq AND Contents.NumEq IS NOT NULL 
			AND Equipment.Title=@title AND Equipment.Ready=1
		JOIN Contracts ON Contracts.Number=Contents.Number AND Contracts.DateOfDeal = @day 
			AND NOT (@timeB<Contracts.TimeOfBegin AND @timeE<Contracts.TimeOfEnd 
			OR @timeB>Contracts.TimeOfBegin AND @timeE>Contracts.TimeOfEnd))
ORDER BY NEWID()
IF @id is NOT NULL INSERT INTO Contents (NumEq, Number) VALUES (@id, @deal)
end
IF @type=3 begin 
SELECT TOP 1 @id=Staff.Id FROM Staff WHERE Staff.Post=@title AND NOT EXISTS
	(SELECT Staff.Id FROM Staff JOIN Contents ON Staff.Id=Contents.Id AND Contents.Id IS NOT NULL AND Staff.Post=@title
		JOIN Contracts ON Contracts.Number=Contents.Number AND Contracts.DateOfDeal = @day 
		AND NOT (@timeB<Contracts.TimeOfBegin AND @timeE<Contracts.TimeOfEnd 
		OR @timeB>Contracts.TimeOfBegin AND @timeE>Contracts.TimeOfEnd))
ORDER BY NEWID()
IF @id is NOT NULL INSERT INTO Contents (Id, Number) VALUES (@id, @deal)
end

EXEC AddContent 6, 0, 'Small hall'
GO

--udalit' dannye o dogovore
CREATE PROCEDURE DeleteDeal (@Num AS int)
AS
DELETE FROM Contents FROM Contents WHERE Contents.Number=@Num
DELETE FROM Contracts FROM Contracts WHERE Contracts.Number=@Num

GO

--pokazat' dogovori, dostupnie dlya udaleniya
CREATE PROCEDURE ShowDeals (@Nick AS varchar(20))
AS
SELECT Number, DateOfDeal, TimeOfBegin, TimeOfEnd FROM Contracts, Clients 
	WHERE  Contracts.Id=Clients.Id AND Clients.Nickname=@Nick AND Contracts.DateOfDeal>GETDATE()
SELECT  max(Number) FROM Contracts
EXEC ShowDeals 'lennon'

SELECT  max(Number) FROM Contracts
GO

--posmotret' dogovori za period
CREATE PROCEDURE DealsPerTime(@Nick AS varchar(20), @DayB AS Date, @DayE AS Date)
AS
(SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Halls.Title, Cost FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Halls ON Contents.NumHall=Halls.NumHall AND Contents.NumHall IS NOT NULL 
	JOIN HallsCost ON Halls.Title=HallsCost.Title
UNION
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Instruments.Title, Cost FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Instruments ON Contents.NumInst=Instruments.NumInst AND Contents.NumInst IS NOT NULL 
	JOIN InstrumentsCost ON Instruments.Title=InstrumentsCost.Title
UNION
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Equipment.Title, Cost FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Equipment ON Contents.NumEq=Equipment.NumEq AND Contents.NumEq IS NOT NULL 
	JOIN EquipmentCost ON Equipment.Title=EquipmentCost.Title
UNION
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Staff.Post, Pay FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Staff ON Contents.Id=Staff.Id AND Contents.Id IS NOT NULL 
	JOIN Jobs ON Staff.Post=Jobs.Post)
GO

--posmotret' dogovori za period v2
CREATE PROCEDURE DealsPerTimeV2(@Nick AS varchar(20), @DayB AS Date, @DayE AS Date)
AS
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, SUM(su) AS Summa FROM
(SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, SUM(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*HallsCost.Cost) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Halls ON Contents.NumHall=Halls.NumHall AND Contents.NumHall IS NOT NULL 
	JOIN HallsCost ON Halls.Title=HallsCost.Title
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd
UNION ALL
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd,Sum(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*InstrumentsCost.Cost) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Instruments ON Contents.NumInst=Instruments.NumInst AND Contents.NumInst IS NOT NULL 
	JOIN InstrumentsCost ON Instruments.Title=InstrumentsCost.Title
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd
UNION ALL
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd,Sum( datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*EquipmentCost.Cost) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Equipment ON Contents.NumEq=Equipment.NumEq AND Contents.NumEq IS NOT NULL 
	JOIN EquipmentCost ON Equipment.Title=EquipmentCost.Title
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd
UNION ALL
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd,Sum(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*Jobs.Pay) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Clients.Nickname = @Nick 
		AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Staff ON Contents.Id=Staff.Id AND Contents.Id IS NOT NULL 
	JOIN Jobs ON Staff.Post=Jobs.Post
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd
)a
GROUP BY a.DateOfDeal, a.TimeOfBegin, a.TimeOfEnd

EXEC DealsPerTimeV2 'lennon', '2019-12-22', '2019-12-25'
GO

--dlya sotrudnika
--uznat' grafik raboti za period
CREATE PROCEDURE WhenWork(@Nick AS varchar(20), @DayB AS Date, @DayE AS Date)
AS
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Contracts.Number, Clients.FIO FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number
	JOIN Staff ON Contents.Id=Staff.Id AND Contents.Id IS NOT NULL
WHERE Staff.Nickname = @Nick

EXEC WhenWork 'todd', '2019-12-22', '2019-12-25'
GO

--soobshchit' o neispravnosti
CREATE PROCEDURE ObjectBreak(@Num AS int, @type AS int)
AS
if @type = 0 UPDATE Halls SET Ready=0 WHERE NumHall=@Num
if @type = 1 UPDATE Instruments SET Ready=0 WHERE NumInst=@Num
if @type = 2 UPDATE Equipment SET Ready=0 WHERE NumEq=@Num

EXEC ObjectBreak 6, 1
GO

--poluchit' informaziyu o klientah
CREATE PROCEDURE ClientsInfo(@Nick AS varchar(20))
AS
SELECT Clients.FIO, Clients.Mail, Contracts.Number, DateOfDeal, TimeOfBegin, TimeOfEnd FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id
	JOIN Contents ON Contracts.Number=Contents.Number
	JOIN Staff ON Contents.Id=Staff.Id AND Contents.Id IS NOT NULL
WHERE Staff.Nickname = @Nick

EXEC ClientsInfo 'harmon'
GO

--dlya directora
--dobavit' novogo sotrudnika
CREATE PROCEDURE CreateNewWorker (@FIO AS varchar(50), @Mail AS varchar(50), @Nick AS varchar(20), @Pswd AS varchar(10), @Post AS varchar(50) )
AS
IF @Post NOT IN (SELECT Post FROM Jobs) 
	INSERT INTO Jobs(Post, Pay, Salary) VALUES (@Post, 400, 35000)
if @Nick NOT IN (SELECT Nickname FROM Staff) 
	INSERT INTO Staff(Post, FIO, Mail, Nickname, Pswd) VALUES (@Post, @FIO, @Mail, @Nick, @Pswd)

GO

--uznat' pribil' za period
CREATE PROCEDURE IncomePerTime(@DayB AS Date, @DayE AS Date)
AS
SELECT SUM(su) FROM
(SELECT SUM(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*HallsCost.Cost) su FROM Contracts 
	JOIN Contents ON Contracts.Number=Contents.Number AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Halls ON Contents.NumHall=Halls.NumHall AND Contents.NumHall IS NOT NULL 
	JOIN HallsCost ON Halls.Title=HallsCost.Title
UNION ALL
SELECT Sum(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*InstrumentsCost.Cost) su FROM Contracts
	JOIN Contents ON Contracts.Number=Contents.Number AND  Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Instruments ON Contents.NumInst=Instruments.NumInst AND Contents.NumInst IS NOT NULL 
	JOIN InstrumentsCost ON Instruments.Title=InstrumentsCost.Title
UNION ALL
SELECT Sum( datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*EquipmentCost.Cost) su FROM Contracts
	JOIN Contents ON Contracts.Number=Contents.Number AND  Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE  
	JOIN Equipment ON Contents.NumEq=Equipment.NumEq AND Contents.NumEq IS NOT NULL 
	JOIN EquipmentCost ON Equipment.Title=EquipmentCost.Title
UNION ALL
SELECT Sum(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*Jobs.Pay) su FROM Contracts
	JOIN Contents ON Contracts.Number=Contents.Number AND  Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE
	JOIN Staff ON Contents.Id=Staff.Id
	JOIN Jobs ON Staff.Post=Jobs.Post
)a

EXEC IncomePerTime '2019-12-22', '2019-12-25'
GO

CREATE PROCEDURE IncomePerTimeTable(@DayB AS Date, @DayE AS Date)
AS
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, FIO, SUM(su) AS Summa FROM
(SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO, SUM(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*HallsCost.Cost) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id  AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Halls ON Contents.NumHall=Halls.NumHall AND Contents.NumHall IS NOT NULL 
	JOIN HallsCost ON Halls.Title=HallsCost.Title
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO
UNION ALL
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO, Sum(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*InstrumentsCost.Cost) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id  AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Instruments ON Contents.NumInst=Instruments.NumInst AND Contents.NumInst IS NOT NULL 
	JOIN InstrumentsCost ON Instruments.Title=InstrumentsCost.Title
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO
UNION ALL
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO, Sum( datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*EquipmentCost.Cost) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Equipment ON Contents.NumEq=Equipment.NumEq AND Contents.NumEq IS NOT NULL 
	JOIN EquipmentCost ON Equipment.Title=EquipmentCost.Title
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO
UNION ALL
SELECT DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO, Sum(datediff(hour, Contracts.TimeOfBegin, Contracts.TimeOfEnd)*Jobs.Pay) su FROM Clients 
	JOIN Contracts ON Clients.Id=Contracts.Id AND Contracts.DateOfDeal>=@DayB AND Contracts.DateOfDeal<=@DayE 
	JOIN Contents ON Contracts.Number=Contents.Number 
	JOIN Staff ON Contents.Id=Staff.Id AND Contents.Id IS NOT NULL 
	JOIN Jobs ON Staff.Post=Jobs.Post
GROUP BY Contracts.DateOfDeal, TimeOfBegin, TimeOfEnd, Clients.FIO
)a
GROUP BY a.DateOfDeal, a.TimeOfBegin, a.TimeOfEnd, FIO

EXEC IncomePerTimeTable '2019-12-22', '2019-12-25'
GO

--kupit' novyj ob'ekt
CREATE PROCEDURE BuyNew(@type AS int, @price AS int, @title AS varchar(50), @arenda AS int)
AS
declare @today date
set @today = getdate()
declare @Num int
if @type = 0 begin IF @title NOT IN (SELECT Title FROM HallsCost) INSERT INTO HallsCost(Title, Cost) VALUES (@title, @arenda) 
                   INSERT INTO Halls(Title, Ready) VALUES (@title, 1)
                   SELECT @Num =  MAX(NumHall) FROM Halls
				   INSERT INTO RepairCost (NumHall, Date_of_repair, Cost) VALUES (@Num, @today, @price) end
if @type = 1 begin IF @title NOT IN (SELECT Title FROM InstrumentsCost) INSERT INTO InstrumentsCost(Title, Cost) VALUES (@title, @arenda) 
                   INSERT INTO Instruments(Title, Ready) VALUES (@title, 1)
                   SELECT @Num =  MAX(NumInst) FROM Instruments
				   INSERT INTO RepairCost (NumInst, Date_of_repair, Cost) VALUES (@Num, @today, @price) end
if @type = 2 begin IF @title NOT IN (SELECT Title FROM EquipmentCost) INSERT INTO EquipmentCost(Title, Cost) VALUES (@title, @arenda) 
                   INSERT INTO Equipment(Title, Ready) VALUES (@title, 1)
                   SELECT @Num =  MAX(NumEq) FROM Equipment
				   INSERT INTO RepairCost (NumEq, Date_of_repair, Cost) VALUES (@Num, @today, @price) end
GO

--snyat' pometku o neispravnosti
CREATE PROCEDURE ObjectRepair(@Num AS int, @type AS int, @price AS int)
AS
declare @today date
set @today = getdate()
if @type = 0 begin UPDATE Halls SET Ready=1 WHERE NumHall=@Num 
	INSERT INTO RepairCost (NumHall, Date_of_repair, Cost) VALUES (@Num, @today, @price) end
if @type = 1 begin UPDATE Instruments SET Ready=1 WHERE NumInst=@Num 
	INSERT INTO RepairCost (NumInst, Date_of_repair, Cost) VALUES (@Num, @today, @price) end
if @type = 2 begin UPDATE Equipment SET Ready=1 WHERE NumEq=@Num 
	INSERT INTO RepairCost (NumEq, Date_of_repair, Cost) VALUES (@Num, @today, @price) end

Exec ObjectRepair 6, 1, 590
GO

--izmenit' stoimost' arendy
CREATE PROCEDURE ChangeArenda(@title AS varchar(50), @type AS int, @price AS int)
AS
if @type = 0 begin UPDATE HallsCost SET Cost=@price WHERE Title=@title end
if @type = 1 begin UPDATE InstrumentsCost SET Cost=@price WHERE Title=@title end
if @type = 2 begin UPDATE EquipmentCost SET Cost=@price WHERE Title=@title end
GO

--poschitat' rashody za period
CREATE PROCEDURE LostPerTimeTable(@DayB AS Date, @DayE AS Date)
AS
SELECT Date_of_repair, Cost, RepairCost.NumHall AS ObjectId, Title FROM RepairCost 
	JOIN Halls ON RepairCost.NumHall=Halls.NumHall 
	WHERE RepairCost.Date_of_repair<=@DayE AND RepairCost.Date_of_repair>=@DayB AND RepairCost.NumHall IS NOT NULL
UNION
SELECT Date_of_repair, Cost, RepairCost.NumInst AS ObjectId, Title FROM RepairCost 
	JOIN Instruments ON RepairCost.NumInst=Instruments.NumInst
	WHERE RepairCost.Date_of_repair<=@DayE AND RepairCost.Date_of_repair>=@DayB AND RepairCost.NumInst IS NOT NULL
UNION
SELECT Date_of_repair, Cost, RepairCost.NumEq AS ObjectId, Title FROM RepairCost 
	JOIN Equipment ON RepairCost.NumEq=Equipment.NumEq 
	WHERE RepairCost.Date_of_repair<=@DayE AND RepairCost.Date_of_repair>=@DayB AND RepairCost.NumEq IS NOT NULL
GO

--poschitat' rashody za period
CREATE PROCEDURE LostPerTime(@DayB AS Date, @DayE AS Date)
AS
SELECT SUM(RepairCost.Cost) AS Summa FROM RepairCost 
	WHERE RepairCost.Date_of_repair<=@DayE AND RepairCost.Date_of_repair>=@DayB

EXEC LostPerTime '2018-12-22', '2019-12-25'
GO

--uvolit' sotrudnika
CREATE PROCEDURE DeleteWorker(@Id AS int)
AS
DELETE FROM Contents WHERE Id=@Id
DELETE FROM Staff WHERE Id=@Id
GO

--izmenit' zarplatu
CREATE PROCEDURE ChangeSalary(@post AS varchar(50), @salary AS int)
AS
UPDATE Jobs SET Salary=@salary WHERE Post=@post
GO

--izmenit' platu
CREATE PROCEDURE ChangePay(@post AS varchar(50), @pay AS int)
AS
UPDATE Jobs SET Pay=@pay WHERE Post=@post
GO

--poluchit' informaziyu o sotrudnikah
CREATE PROCEDURE InfoAboutWorkers
AS
SELECT Id, FIO, Staff.Post, Pay, Salary, Mail, Nickname, Pswd FROM Staff 
	JOIN Jobs ON Staff.Post=Jobs.Post
GO

--vyvesti spisok slomannyh ob'ektov
CREATE PROCEDURE BrokenObjects AS
SELECT Title, NumHall AS Num From Halls WHERE Ready=0
UNION
SELECT Title, NumInst AS Num From Instruments WHERE Ready=0
UNION
SELECT Title, NumEq AS Num From Equipment WHERE Ready=0
GO

--uznat' parol' po loginu
CREATE PROCEDURE GetPassword (@Nick AS varchar(20))
AS
SELECT Pswd FROM Clients WHERE Nickname =@Nick
GO


CREATE PROCEDURE GetPasswordS (@Nick AS varchar(20))
AS
SELECT Pswd FROM Staff WHERE Nickname =@Nick

EXEC GetPasswordS 'todd'
