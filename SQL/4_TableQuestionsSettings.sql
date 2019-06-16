IF OBJECT_ID('dbo.QuestionsSettings', 'U') IS NOT NULL 
  DROP TABLE dbo.QuestionsSettings; 
CREATE TABLE QuestionsSettings (
QuestionSettingID int not null primary key,
EventID int FOREIGN KEY REFERENCES Event(EventID),
UserCanSwitchQuestion bit,
RealTimeAnsState bit,
MultipleAttemptAllowed bit,
MaxAttemptAllowed int,
NegativeMarksForWrongAns int,
ResultCanBeinNegative bit
);