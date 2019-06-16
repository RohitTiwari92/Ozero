IF OBJECT_ID('dbo.TableQuestionType', 'U') IS NOT NULL 
  DROP TABLE dbo.TableQuestionType; 
CREATE TABLE TableQuestionType (
   QuestionTypeID int not null primary key,
   TypeName varchar(MAX),
);