using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename )
        {
            string sql = "select r.RecipeId, r.RecipeName, h.UserName, r.NumCalories, c.CuisineType, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from recipe r join heartyhearthuser h on r.heartyhearthuserid = h.heartyhearthuserid join cuisine c on r.cuisineid = c.cuisineid where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable LoadForm(int recipeid)
        {
            string sql = "select * from recipe r join heartyhearthuser h on r.heartyhearthuserid = h.heartyhearthuserid join cuisine c on r.cuisineid = c.cuisineid where r.recipeid = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static void SaveRecipe(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"HeartyHearthUserId = '{r["HeartyHearthUserId"]}',",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"NumCalories = '{r["NumCalories"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}'",
                    $"where RecipeId = '{r["RecipeId"]}'");
            }
            else
            {
                sql = "insert Recipe(RecipeName, HeartyHearthUserId, CuisineId, NumCalories, DateDrafted) ";
                sql += $"select '{r["RecipeName"]}', {r["HeartyHearthUserId"]}, {r["CuisineId"]}, {r["NumCalories"]}, '{r["DateDrafted"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
        }

        public static void DeleteRecipe(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where recipeId =" + id;
            SQLUtility.ExecuteSQL(sql);
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select cuisineid, cuisinetype from cuisine");
        }

        public static DataTable GetUsersList()
        {
            return SQLUtility.GetDataTable("select HeartyHearthUserId, UserName from HeartyHearthUser");
        }
    }
}
