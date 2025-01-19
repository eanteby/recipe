create or alter procedure dbo.HeartyHearthUserGet(@HeartyHearthUserId int = 0, @All bit = 0, @UserLastName varchar(30) = '')
as
begin
	select h.HeartyHearthUserId, h.UserFirstName, h.UserLastName, h.UserName
	from HeartyHearthUser h 
	where h.HeartyHearthUserId = @HeartyHearthUserId
	or @All = 1
	or (@UserLastName <> '' and h.UserLastName like '%' + @UserLastName + '%')
end
go

/*
exec HeartyHearthUserGet --empty result set

exec HeartyHearthUserGet @All = 1

exec HeartyHearthUserGet @UserLastName = 'e'

declare @HeartyHearthUserId int
select top 1 @HeartyHearthUserId = h.HeartyHearthUserId from HeartyHearthUser h
exec HeartyHearthUserGet @HeartyHearthUserId = @HeartyHearthUserId
*/