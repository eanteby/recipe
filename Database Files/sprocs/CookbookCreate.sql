create or alter proc dbo.CookbookCreate(
@CookbookId int = 0 output,
@HeartyHearthUserId int,
@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0
	select @CookbookId = isnull(@CookbookId, 0)
	
	if dbo.NumRecipesPerUser(@HeartyHearthUserId) < 1
	begin
		select @Return = 1, @Message = 'Cannot create cookbook- user has no recipes.'
		goto finished
	end

	else 
	begin
		begin try
			begin tran
					Insert CookBook (HeartyHearthUserId, CookBookName, CookBookPrice, IsActive)
					select hhu.HeartyHearthUserId, concat('Recipes by ', hhu.UserFirstName, ' ', hhu.UserLastName), count(r.RecipeId) * 1.33, 1
					from HeartyHearthUser hhu 
					join Recipe r 
					on hhu.HeartyHearthUserId = r.HeartyHearthUserId 
					where hhu.HeartyHearthUserId = @HeartyHearthUserId
					group by hhu.HeartyHearthUserId, hhu.UserFirstName, hhu.UserLastName

					select @CookbookId = SCOPE_IDENTITY() 

					insert CookBookRecipe (CookBookId, RecipeID, RecipeSequence)
					select cb.CookBookId, r.RecipeId, row_number() over(order by RecipeId)
					from Recipe r 
					join CookBook cb 
					on r.HeartyHearthUserId = cb.HeartyHearthUserId
					where r.HeartyHearthUserId = @HeartyHearthUserId
					and cb.CookbookId = @CookbookId
					order by r.RecipeName
			commit
		end try

		begin catch
			rollback;
			throw
		end catch
	end
	finished:
	return @Return
end

