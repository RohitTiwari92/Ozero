IF OBJECT_ID('dbo.SubEventType', 'U') IS NOT NULL 
  DROP TABLE dbo.SubEventType; 
CREATE TABLE SubEventType (
   SubEventTypeID int not null  IDENTITY(1,1)  primary key,
   Name varchar(100) not null
   );