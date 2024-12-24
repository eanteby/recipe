--IMPORTANT create login in Master
--use master
drop login (login)
create login (login) with password = (password)

--IMPORTANT switch to HeartyHearthDB
drop user dev_User
create user dev_User from login (login)

alter role db_datareader add member dev_User
alter role db_datawriter add member dev_User
