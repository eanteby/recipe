using CPUFramework;
using RecipeSystem;
using System.Data;

namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            RecipeDBManager.SetConnectionString("Server=tcp:eanteby.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;User ID=eanteby;Password=CpuAdmin123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select r.RecipeId, r.RecipeName, h.UserName, r.NumCalories, c.CuisineType, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from recipe r join heartyhearthuser h on r.heartyhearthuserid = h.heartyhearthuserid join cuisine c on r.cuisineid = c.cuisineid");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "cannot delete recipe, no recipes in database.");
            TestContext.WriteLine("existing president with id " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure app can delete " + recipeid);
            Recipe.DeleteRecipe(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in database");
            TestContext.WriteLine("record with recipeid " + recipeid + " does not exist in database");
        }

        [Test]
        [TestCase("blondies", 200, "2025-01-01")]
        //[TestCase("steak", 300, "2026-01-01")]
        public void InsertNewRecipe(string newrecipename, int numcalories, DateTime datedrafted)
        {
            DataTable dt = SQLUtility.GetDataTable("Select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "no cuisines in database, can't run test");
            int userid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 heartyhearthuserid from heartyhearthuser");
            Assume.That(userid > 0, "no users in database, can't run test");
            newrecipename = newrecipename + " " + DateTime.Now.ToString();
            TestContext.WriteLine("insert recipe with name " + newrecipename);
            r["cuisineid"] = cuisineid;
            r["heartyhearthuserid"] = userid;
            r["recipename"] = newrecipename;
            r["numcalories"] = numcalories;
            r["datedrafted"] = datedrafted;
            Recipe.SaveRecipe(dt);
            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = '" + newrecipename + "'");
            Assert.IsTrue(newid > 0, "recipe with name, " + newrecipename + "and pk, " + newid + " is not found in database");
            TestContext.WriteLine("recipe with name, " + newrecipename + "and pk, " + newid + " is found in database");            
        }

        [Test]
        public void ChangeExistingRecipeNumCalories()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 * from recipe");
            Assume.That(recipeid > 0);
            int numcalories = SQLUtility.GetFirstColumnFirstRowValue("select numcalories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("numcalories for recipeid " + recipeid + " is " + numcalories);
            numcalories += 55;
            TestContext.WriteLine("change numcalories to " + numcalories);
            DataTable dt = Recipe.LoadForm(recipeid);

            dt.Rows[0]["numcalories"] = numcalories;
            Recipe.SaveRecipe(dt);

            int newnumcalories = SQLUtility.GetFirstColumnFirstRowValue("select numcalories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newnumcalories == numcalories, "numcalories for recipeid " + recipeid + " is still " + newnumcalories);
            TestContext.WriteLine("numcalories for recipeid " + recipeid + " has been updated to " + newnumcalories);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
            Assume.That(recipeid > 0);
            TestContext.WriteLine("existing recipe with id " + recipeid);
            TestContext.WriteLine("ensure app loads recipe with id" + recipeid);
            DataTable dt = Recipe.LoadForm(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " does not equal recipeid " + recipeid);
            TestContext.WriteLine("successfully loaded recipe with id " + recipeid);
        }

        [Test]
        [TestCase("cuisine")]
        [TestCase("heartyhearthuser")]
        public void LoadRelatedTable(string tablename)
        {
            int tablecount = SQLUtility.GetFirstColumnFirstRowValue("Select total = count(*) from " + tablename);
            Assume.That(tablecount > 0, "no " + tablename + "s in database");
            TestContext.WriteLine("num of rows in database = " + tablecount);
            TestContext.WriteLine("ensure that num of rows returned by app matches " + tablecount);
            DataTable dt = Recipe.GetCuisineList();
            if (tablename == "heartyhearthuser")
            {
                dt = Recipe.GetUsersList();
            }
            Assert.IsTrue(dt.Rows.Count == tablecount, "num rows returned by app, " + dt.Rows.Count + " <> " + tablecount);
            TestContext.WriteLine("number of rows in " + tablename + " = " + dt.Rows.Count);
        }

        private string GetFirstColumnFirstValueAsString(string sql)
        {
            string s = "";
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            return s;
        }

        [Test]
        public void DeleteRecipeWithChildTableRecord()
        {
            DataTable dt = SQLUtility.GetDataTable("select r.RecipeId, r.RecipeName, h.UserName, r.NumCalories, c.CuisineType, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic from recipe r join heartyhearthuser h on r.heartyhearthuserid = h.heartyhearthuserid join cuisine c on r.cuisineid = c.cuisineid");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "cannot delete recipe, no recipes in database.");
            TestContext.WriteLine("existing president with id " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure app cannot delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(()=> Recipe.DeleteRecipe(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeletePublishedRecipeOrArchivedLessThanThirtyDays()
        {
            string sql = @"select r.RecipeId, r.RecipeName, h.UserName, r.NumCalories, c.CuisineType, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic 
from recipe r 
join heartyhearthuser h 
on r.heartyhearthuserid = h.heartyhearthuserid 
join cuisine c 
on r.cuisineid = c.cuisineid
where (r.RecipeStatus = 'published' 
or 
(r.RecipeStatus = 'archived' 
and datediff(day, r.DateArchived, getdate()) <30))";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "cannot delete recipe, no published/archived less than 30 days recipes in database.");
            TestContext.WriteLine("existing recipe with id " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure app cannot delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.DeleteRecipe(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeToInvalidNumCalories()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 * from recipe");
            Assume.That(recipeid > 0);
            int numcalories = SQLUtility.GetFirstColumnFirstRowValue("select numcalories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("numcalories for recipeid " + recipeid + " is " + numcalories);
            numcalories = -5;
            TestContext.WriteLine("change numcalories to " + numcalories);
            DataTable dt = Recipe.LoadForm(recipeid);

            dt.Rows[0]["numcalories"] = numcalories;
            Exception ex = Assert.Throws<Exception> (()=> Recipe.SaveRecipe(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeToDifferentExistingRecipeName()
        {
            string recipename = GetFirstColumnFirstValueAsString("select top 1 recipename from recipe");
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe where recipename = '" + recipename + "'");
            string newrecipename = GetFirstColumnFirstValueAsString("select top 1 recipename from recipe where recipename <> '" + recipename + "'");
            Assume.That(recipename != "" && newrecipename != "", "not enough info to perform test");
            TestContext.WriteLine("change recipe name from " + recipename + " to " + newrecipename + " which already exists"  );
            DataTable dt = Recipe.LoadForm(recipeid);

            dt.Rows[0]["recipename"] = newrecipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.SaveRecipe(dt));
            TestContext.WriteLine(ex.Message);
        }

    }
}