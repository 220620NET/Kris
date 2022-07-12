
/*
 * the * references all the columns in the table
 * */
select * from music.artists;
select * from music.albums;
select * from music.playlists;
select * from music.songs;
select * from music.playlists_songs;
/*
 * Any time you use a DQL Statement, it is going to return a result set
 * 
 * What is a result set?
 * 	- a temporary table given back from a DQL statement
 * */
select name from music.artists;
select id,name from music.artists;

/*
 * What is an alias?
 * 	- nicknames you can give entities in your statement
 * 
 * you can put aliases on column names and table names
 * */
select name as artist_names from music.artists;

select fluffybunny.name from music.artists as fluffybunny;

-- the where keyword allows us to filter records in a table
select * from music.songs where album_fk = 1.0;
select * from music.songs where album_fk in (1,2,3,4);
select * from music.songs where album_fk BETWEEN 1 AND 4;
select * from music.songs where name != 'Papercut';
select * from music.songs where name <> 'Papercut';
select * from music.songs where not name = 'Papercut';

--Like keyword finds patterns in columns
/*
 * % wildcard is a standin for 0 or more characters
 * */
select * from music.songs where name like 'b%';

select * from music.songs order by name asc;
select * from music.songs order by name desc;
select * from music.songs order by album_fk desc,name asc;

/*
 * aggregate functino
 * 		- aggregate functions do a calculation on a grouping of records producing one result
 * 
 * count()
 * 
 * group by
 * 	-allows aggregate functions to work on smaller pockets of records
 * 
 * differences between where and having
 * 		- where filters on the original result set
 * 		- having filters after the new result set
 */

select count(*) as song_count from music.songs where album_fk = 1;
select sum(album_fk) from music.songs where name like 'b%';
select max(album_fk) from  music.songs;
select count(name) from music.songs group by album_fk;
select count(name) from music.songs group by album_fk having count(album_fk)>11;

/*
 * scalar functions
 * 		-manipulate the data in one specific record
 * 		
 */
 
select 'Hello World';

-- numbers
select abs(-99);
select floor(8321.231);
select ceiling(88.77);
select round(88.77,0);
select upper('nasod');
select len('asnao');
select upper(name) from music.songs;
select name, len(name) from music.songs;
/*
 * What is a join?
 * 	joins are a way of combining two or more tables given a common column
 * */
select * from music.songs as s
inner join music.albums as a on s.album_fk =a.id
inner join music.artists as a2 on a.artist_fk =a2.id
right join music.playlists_songs ps on s.id=ps.song_fk order by s.id ASC  ;

select * from music.songs s right join music.albums a on s.album_fk =a.id;


/* sets can combine the rows of 2 tables together in the same columns
 * 
 * Requirement:
 * 	- you need the same amount of columns
 * 	- columns need to be the same datatype
 * 
 * Types of sets:
 * 	- union: combines all from both tables
 * 	- intersect: displays only equal records from both tables
 * 	- except: displays everything from the first table and removes records that they both have in common
 * */
select * from music.playlists p 
union
select * from music.artists a;

select * from music.playlists p 
intersect
select * from music.artists a;

select * from music.playlists p 
except
select * from music.artists a;