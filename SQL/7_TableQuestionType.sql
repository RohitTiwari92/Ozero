IF OBJECT_ID('dbo.TableQuestionType', 'U') IS NOT NULL 
  DROP TABLE dbo.TableQuestionType; 
CREATE TABLE TableQuestionType (
   QuestionTypeID int not null  IDENTITY(1,1)  primary key,
   TypeName varchar(MAX),
);