
create database MovieProject

use  MovieProject
 
create table Genre(GenreID int primary key identity(1,1),Name varchar(50))

create table Movie(  MovieID int primary key identity(1,1), Title varchar(50), 
ReleasedDate datetime,
GenreID int foreign key references Genre(GenreID)
 on delete cascade on update cascade
)
insert into Genre Values('Drama')
insert into Genre Values('Comedy')
insert into Genre Values('Action')




insert into Movie values('Drama1',getdate(),1)
insert into Movie values('Drama2',getdate(),1)
insert into Movie values('Drama3',getdate(),1)

insert into Movie values('Comedy1',getdate(),2)
insert into Movie values('Comedy2',getdate(),2)
insert into Movie values('Comedy3',getdate(),2)

insert into Movie values('Action1',getdate(),3)
insert into Movie values('Action2',getdate(),3)
insert into Movie values('Action3',getdate(),3)
--drop table Genre
--drop table movie
--update Genre set Name = 'Action' where GenreID = 3
select * from Genre
select * from Movie


select top 1  * from Genre


