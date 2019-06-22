IF OBJECT_ID('dbo.EventType', 'U') IS NOT NULL 
  DROP TABLE dbo.EventType; 
CREATE TABLE EventType (
   EventTypeID int not null  IDENTITY(1,1)  primary key,
   Name varchar(100) not null
   );