USE [Rewarding]
GO

CREATE PROCEDURE AddUser
	@IDUser int,
	@FirstName varchar(255),
	@LastName varchar(255),
	@DateOfBirth date,
	@Age int
AS
BEGIN
		INSERT INTO Users(IDUser, FirstName, LastName, DateOfBirth, Age)
		VALUES(@IDUser, @FirstName, @LastName, @DateOfBirth, @Age)
END


CREATE PROCEDURE DeleteUser
	@IDUser int
AS
	DELETE FROM Users
	WHERE IDUser = @IDUser
GO


CREATE PROCEDURE AddAward
	@Title varchar(255)
AS
BEGIN
		INSERT INTO Awards(Title)
		VALUES(@Title)
END


CREATE PROCEDURE AddAwardToUser
	@IDUser int,
	@IDAward int
AS
BEGIN
		INSERT INTO ListOfAwards(IDUser, IDAward)
		VALUES(@IDUser, @IDAward)
END


--CREATE PROCEDURE GetAllUsersWithAwards
--AS
--BEGIN
--		SELECT Users.IDUser, Users.FirstName, Users.LastName, Users.DateOfBirth, Users.Age, Awards.Title AS Award
--		FROM Users
--		LEFT JOIN ListOfAwards ON Users.IDUser = ListOfAwards.IDUser
--		LEFT JOIN Awards ON Awards.IDAward = ListOfAwards.IDAward
--END


CREATE PROCEDURE GetAllUsers
AS
BEGIN
		SELECT * FROM Users
END


CREATE PROCEDURE GetAllAwards
AS
BEGIN
		SELECT * FROM Awards
END

CREATE PROCEDURE GetAllUsersWithAwards
AS
BEGIN
		SELECT * FROM ListOfAwards
END


