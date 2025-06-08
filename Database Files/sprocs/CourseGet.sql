create or alter proc dbo.CourseGet(
	@CourseId int = 0,
	@All bit = 0, 
	@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @CourseId = isnull(@CourseId, 0), @All = isnull(@All, 0)

	select c.CourseId, c.CourseName, c.CourseSequence 
	from course c
	where @All = 1 
	or c.CourseId = @CourseId 
	order by c.CourseSequence

	return @Return
end

