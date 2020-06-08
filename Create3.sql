USE [Rewarding]

CREATE TABLE Users (
IDUser int CONSTRAINT PK_User PRIMARY KEY NOT NULL,
FirstName varchar(255) NOT NULL,
LastName varchar(255) NOT NULL,
DateOfBirth date NOT NULL,
Age int NOT NULL
)

CREATE TABLE Awards (
IDAward int IDENTITY(1,1) CONSTRAINT PK_Award PRIMARY KEY NOT NULL,
Title varchar(255) NOT NULL
)

CREATE TABLE ListOfAwards (
IDUser int NOT NULL references Rewarding.dbo.Users(IDUser) on delete cascade on update cascade,
IDAward int NOT NULL references Rewarding.dbo.Awards(IDAward) on delete cascade on update cascade
)

ALTER TABLE ListOfAwards ADD CONSTRAINT FK_ListOfAwards_IDUser
FOREIGN KEY(IDUser) REFERENCES Users(IDUser)

ALTER TABLE ListOfAwards ADD CONSTRAINT FK_ListOfAwardss_IDAward
FOREIGN KEY(IDAward) REFERENCES Awards(IDAward)


INSERT INTO Users (IDUser, FirstName, LastName, DateOfBirth, Age)
VALUES (121345, 'Алескей', 'Иванов', '01-12-1995', 25),
(125674, 'Николай', 'Куйбышев', '13-05-1991', 29),
(126735, 'Анна', 'Анисимова', '01-12-1989', 31)

INSERT INTO Awards (Title)
VALUES ('Диплом'),
('Медаль'),
('Премия')

INSERT INTO ListOfAwards (IDUser, IDAward)
VALUES (121345, 1),
(121345, 3),
(126735, 3)