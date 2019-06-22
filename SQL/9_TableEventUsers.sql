IF OBJECT_ID('dbo.TableEventUsers', 'U') IS NOT NULL 
  DROP TABLE dbo.TableEventUsers; 
CREATE TABLE TableEventUsers (
   EventUserID int not null  IDENTITY(1,1)  primary key,
   EventID int FOREIGN KEY REFERENCES Event(EventID),
   Userid int FOREIGN KEY REFERENCES TableUsers(Userid),
   Approved bit,
   Approver varchar(MAX),
   EventRank int
);