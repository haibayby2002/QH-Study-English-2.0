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




--- --------------------------------------------
Delete from Vocabulary

--recursive


    ;with cte 
    as (select *
        from dbo.Vocabulary as v
        where v.id_set = 2
        UNION ALL
        select t.BookGroupId
        from #t as t 
        join cte 
        on t.ParentGroupId = cte.BookGroupId)
    select *
    from cte
    order by ;

--Tinh ti le tra loi dung

Go 
Select *, dbo.TinhTiLeTraLoiDung(v.answerRight, v.total) as TiLe
from Vocabulary v
where v.id_set = 18;