using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
		LoadRecipes();
	}

	private void LoadRecipes()
	{
		DataTable dt = Recipe.LoadForm(0, true);
		LstRecipes.ItemsSource = dt.Rows;
	}

}