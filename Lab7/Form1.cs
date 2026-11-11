using System.ComponentModel;

namespace Lab7
{
    public partial class Form1 : Form
    {
        Models.SeCocktailsContext context = new Models.SeCocktailsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cocktailBindingSource.DataSource = context.Cocktails.ToList();
        }

        private void cocktailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cocktailBindingSource.Current == null) return;

            Models.Cocktail selectedCocktail = (Models.Cocktail)cocktailBindingSource.Current;

            var lllll = from x in context.Recipes
                        where x.CocktailFk == selectedCocktail.CocktailSk
                        select new { 
                            x.RecipeSk,
                            x.MaterialFkNavigation.Name,
                            x.Quantity,
                            x.MaterialFkNavigation.Price
                        };

            dataGridView1.DataSource = lllll.ToList();


        }
    }


}
