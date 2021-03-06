USE [QHStudyEnglish]
GO
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'allow', N'(v) cho phép', 1, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'arrow', N'(n) mũi tên', 1, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'camel', N'(n) lạc đà', 17, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'donkey', N'(n) con lừa', 18, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'fox', N'(n) cáo, chồn', 7, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'hippo', N'(n) hà mã', 17, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'horse', N'(n) con ngựa', 18, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'kangaroo', N'(n) con kang-gu-ru ở Úc', 11, NULL, NULL)
INSERT [dbo].[Vocabulary] ([name], [meaning], [id_set], [total], [answerRight]) VALUES (N'zebra', N'(n) ngựa vằn', 18, NULL, NULL)

Insert into Vocabulary (name, meaning, id_set) values ('heterotrophic', N'(n) dị dưỡng', 2)


--- --------------------------------------------
Delete from Vocabulary

--recursive for vocabulary
CREATE PROCEDURE SelectAllVocabularyChild @id_set int
AS
begin
WITH
  cteReports (id, name, parent)
  AS
  (
    SELECT id, name, parent
    FROM VocaSet
    WHERE id = @id_set
    UNION ALL
    SELECT vs.id, vs.name, vs.parent
    FROM VocaSet vs
      INNER JOIN cteReports r
        ON vs.parent = r.id
  )

  Select *, dbo.TinhTiLeTraLoiDung(vb.answerRight, vb.total) as Tile
  from Vocabulary vb
  where vb.id_set in
  (Select id from cteReports)
  order by Tile asc, vb.total asc, rand()
  end

  exec SelectAllVocabularyChild 13

----------------------------------------------------------------
Update Vocabulary set total = 0, answerRight = 0 where total is Null


--Select all child
exec SelectAllVocaSetChild 2


Go 
Select *, dbo.TinhTiLeTraLoiDung(v.answerRight, v.total) as TiLe
from Vocabulary v
where v.id_set = 18;

exec SelectAllVocaSetChild null
exec SelectAllVocabularyDescendants 2

-- Set value
create procedure UpdateVocabularyTraLoiDung @voca_name varchar(100), @id_set int, @value int
as
begin
	update Vocabulary set answerRight = answerRight + @value, total = total + @value
	where name = @voca_name and id_set = @id_set
end

create procedure UpdateVocabularyTraLoiSai @voca_name varchar(100), @id_set int, @value int
as
begin
	update Vocabulary set total = total + @value
	where name = @voca_name and id_set = @id_set
end

exec UpdateVocabularyTraLoiSai 'animal', 2, 1

Select *from Vocabulary