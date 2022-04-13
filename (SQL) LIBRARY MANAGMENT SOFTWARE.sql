create database hfs_lib_man
use hfs_lib_man

create table bok_isu
(
Id int identity (1,1),
Gr_# varchar(50),
Borrowers_Name varchar(50),
Class varchar(50),
Book_Name varchar (50),
Book_Id varchar (50),
Issuing_Date varchar(50),
Due_Date varchar(50),
Received varchar(50)
)
select * from bok_isu
delete from bok_isu


-------------------------------------------

create table bok_isu_rec
(
Id int identity (1,1),
Gr_# varchar(50),
Borrowers_Name varchar(50),
Class varchar(50),
Book_Name varchar (50),
Book_Id varchar (50),
Issuing_Date varchar(50),
Due_Date varchar(50),
Received varchar(50)
)
select * from bok_isu_rec
delete from bok_isu_rec
------------------------------------------
select * from bok_isu 
select * from bok_isu_rec
-----------------------------------
truncate table bok_isu
truncate table bok_isu_rec
------------------------------
create table userr
(
Id int identity(1,1),
Userr_Name varchar(50),
Passwordd varchar(50)
)
select * from bok_isu where Id like '61' or Gr_# like '8' or Class like'7' or Borrowers_Name like 'zain'
drop table userr


---Book_Name Book_Id Issuing_Date Due_Date Received---



