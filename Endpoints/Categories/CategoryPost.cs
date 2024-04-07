using IWantApp.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace IWantApp.Controller.Categories;
public class CategoryPost
{

    public static string Template => "/Categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context)
    {
        return Results.Ok("OK");
    }
}
