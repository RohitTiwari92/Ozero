IF OBJECT_ID('dbo.EventType', 'U') IS NOT NULL 
  DROP TABLE dbo.EventType; 
CREATE TABLE EventType (
   EventTypeID int not null primary key,
   Name varchar(100) not null
   );