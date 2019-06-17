IF OBJECT_ID('dbo.AnsLog', 'U') IS NOT NULL 
  DROP TABLE dbo.AnsLog; 
CREATE TABLE AnsLog (
   AnsLogID int not null primary key,
   EventID int FOREIGN KEY REFERENCES Event(EventID),
   QuestionID int FOREIGN KEY REFERENCES TableQuestions(QuestionID),
   EventUsersID int FOREIGN KEY REFERENCES TableEventUsers(EventUserID),
   Ans varchar(MAX),
   AnsStatus bit,
   AttemptCount int
);