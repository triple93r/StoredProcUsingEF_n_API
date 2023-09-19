USE [thewebdoctor]
GO

/****** Object:  StoredProcedure [dbo].[sp_Patients]    Script Date: 19/09/2023 6:35:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_Patients]
@Id int=0,
@FirstName varchar(100)='',
@LastName varchar(100)='',
@Age varchar(100)='',
@Adrress varchar(100)='',
@PatientType varchar(100)='',
@bednum varchar(100)='',
@diagnosis varchar(100)='',
@ttype varchar(100)
as
begin
if(@ttype = 'insert')
begin
insert into Patients(FirstName, LastName, Age, Adrress, PatientType, bednum, diagnosis) values(@FirstName,@LastName,@Age, @Adrress ,@PatientType ,@bednum ,@diagnosis)
end
else if(@ttype = 'update')
begin
update Patients set Age=@Age, Adrress=@Adrress where Id=@Id
end
else if(@ttype = 'select')
begin
select Id, FirstName, LastName, Age, Adrress, PatientType, bednum, diagnosis from Patients
end
else if(@ttype = 'delete')
begin
 delete from Patients where Id=@id
end

end
GO


