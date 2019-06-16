IF OBJECT_ID('dbo.TableUsers', 'U') IS NOT NULL 
  DROP TABLE dbo.TableUsers; 
CREATE TABLE TableUsers (
   UserID int not null primary key,
   UserName varchar(Max),
   Age int,
   country Varchar(Max),
   Isactive bit,
   RegistrationDate datetime,
   EndDate datetime,
   Ispremium bit,
   IsPaidUser bit,
   NoofEventWinner int,
   NoofEventparticipated int,
   IsPrivate bit
);