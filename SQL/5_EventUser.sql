IF OBJECT_ID('dbo.EventUser', 'U') IS NOT NULL 
  DROP TABLE dbo.EventUser; 
CREATE TABLE EventUser (
		EventUserID int not null primary key,
		EventID int FOREIGN KEY REFERENCES Event(EventID),
		Userid int,
		AttemptCount int,
		MaxMarks decimal,
		RegistrationDate datetime
);