ALTER TABLE Movies
	ADD ReleaseYear int NULL

ALTER TABLE Movies
	ADD Teaser varchar(200) NOT NULL

EXEC sp_rename 'Movies.RunningTime', 'RuntimeMinutes'

