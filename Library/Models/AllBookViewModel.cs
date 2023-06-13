using Library.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class AllBookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public decimal? Rating { get; set; }
        public string? Description { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
//• Has Id – a unique integer, Primary Key
//• Has Title – a string with min length 10 and max length 50 (required)
//• Has Author – a string with min length 5 and max length 50 (required)
//• Has Description – a string with min length 5 and max length 5000 (required)
//• Has ImageUrl – a string (required)
//• Has Rating – a decimal with min value 0.00 and max value 10.00 (required)
//• Has CategoryId – an integer, foreign key (required)
//• Has Category – a Category (required)
//• Has UsersBooks – a collection of type IdentityUserBook

//< div class= "text-center row" >
//    @foreach(var book in Model.Books)
//    {
//        < div class= "card col-4" style = "width: 20rem; " >
//            < img class= "card-img-top" style = "width: 18rem;"
//             src = "@book.ImageUrl" alt = "Book Image" >
//            < div class= "card-body" >

//                < h5 class= "card-title mt-1" > @book.Title </ h5 >
//                < p class= "mb-0" > Author: @book.Author </ p >
//                < p class= "mb-0" > Rating: @book.Rating </ p >
//                < p > Category: @book.Category </ p >
//            </ div >

//            < form class= "input-group-sm" asp - controller = "Book" asp - action = "AddToCollection" asp - route - id = "@book.Id" >
//                < input type = "submit" value = "Add to Collection" class= "fs-6 btn btn-success mb-3 p-2" />
//            </ form >
//        </ div >
//    }
//</ div >