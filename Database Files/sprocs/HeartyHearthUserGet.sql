create or alter procedure dbo.HeartyHearthUserGet(
@HeartyHearthUserId int = 0, 
@All bit = 0, 
@UserName varchar(30) = ''
)
as
begin
	select h.HeartyHearthUserId, h.UserFirstName, h.UserLastName, h.UserName
	from HeartyHearthUser h 
	where h.HeartyHearthUserId = @HeartyHearthUserId
	or @All = 1
	or (@UserName <> '' and h.UserName like '%' + @UserName + '%')
end
go
