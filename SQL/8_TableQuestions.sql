IF OBJECT_ID('dbo.TableQuestions', 'U') IS NOT NULL 
  DROP TABLE dbo.TableQuestions; 
CREATE TABLE TableQuestions (
   QuestionID int not null  IDENTITY(1,1)  primary key,
   EventID int FOREIGN KEY REFERENCES Event(EventID),
   Question varchar(MAX),
   QuestionType int FOREIGN KEY REFERENCES TableQuestionType(QuestionTypeID),
   QuestionSettingID int FOREIGN KEY REFERENCES QuestionsSettings(QuestionSettingID),
   Option1 varchar(MAX),
   Option2 varchar(MAX),
   Option3 varchar(MAX),
   Option4 varchar(MAX),
   Ans varchar(MAX),
   Remark varchar(MAX)
);