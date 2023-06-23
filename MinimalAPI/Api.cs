
namespace MinimalAPI
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            //all API endpoint mapping
            app.MapGet("/Products", GetProducts);
            app.MapGet("/Products/{id}", GetProduct);
            app.MapPost("/Products", InsertProduct);
            app.MapPut("/Products", UpdateProduct);
            app.MapDelete("/Products", DeleteProduct);
        }

        private static async Task<IResult> GetProducts(IProductData data)
        {
            try
            {
                return Results.Ok(await data.GetProducts());
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetProduct(int id, IProductData data)
        {
            try
            {
                var results = await data.GetProduct(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertProduct(ProductModel product, IProductData data)
        {
            try
            {
                await data.InsertProduct(product);
                return Results.Ok();
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateProduct(ProductModel product, IProductData data)
        {
            try
            {
                await data.UpdateProduct(product);
                return Results.Ok();
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteProduct(int id, IProductData data)
        {
            try
            {
                await data.DeleteProduct(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }
    }
}
