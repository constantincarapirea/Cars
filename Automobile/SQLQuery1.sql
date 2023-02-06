use master
GO

USE master
GO
IF EXISTS (SELECT 'True' FROM sys.databases WHERE name = 'Password')
   BEGIN
   ALTER DATABASE Password SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
      DROP DATABASE Password
   END
GO   

Create DataBase Password
go
use Password
go
create table Pass
(loghin varchar(20),passw varchar(20))
insert into pass values('Carapirea', 'Costea123')
go
create procedure logh as
select loghin from pass

go
create procedure pas as
select passw from Pass
--drop table Pass

Select * from Pass