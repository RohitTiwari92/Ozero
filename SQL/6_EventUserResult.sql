IF OBJECT_ID('dbo.EventResult', 'U') IS NOT NULL 
  DROP TABLE dbo.EventResult; 
CREATE TABLE EventResult (
		ResultID int not null primary key,
		EventID int FOREIGN KEY REFERENCES Event(EventID),
		Userid int,
		Attempt int,
		Marks decimal,
		DateTime datetime
);