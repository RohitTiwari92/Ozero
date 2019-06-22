IF OBJECT_ID('dbo.QuestionsSettings', 'U') IS NOT NULL 
  DROP TABLE dbo.QuestionsSettings; 
CREATE TABLE QuestionsSettings (
QuestionSettingID int not null  IDENTITY(1,1)  primary key,
EventID int FOREIGN KEY REFERENCES Event(EventID),
UserCanSwitchQuestion bit,
RealTimeAnsState bit,
MultipleAttemptAllowed bit,
MaxAttemptAllowed int,
NegativeMarksForWrongAns decimal,
ResultCanBeinNegative bit,
MaxMarks decimal
);