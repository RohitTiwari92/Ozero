IF OBJECT_ID('dbo.Event', 'U') IS NOT NULL 
  DROP TABLE dbo.Event; 
CREATE TABLE Event (
   EventID int not null  IDENTITY(1,1)  primary key,
   EventType int FOREIGN KEY REFERENCES EventType(EventTypeID),
   SubEventType int FOREIGN KEY REFERENCES SubEventType(SubEventTypeID),
   StartDate datetime,
   EventRegistrationDate datetime,
   OwnerID int,
   RealTimeDashboard bit,
   duration int, -- in minute
   MaxAttamptAllowed int,
   Ispublic bit
);