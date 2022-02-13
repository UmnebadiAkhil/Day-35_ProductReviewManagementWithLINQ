﻿using ProductReviewManagementWithLINQ;
using System;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Hello Welocome to Product Review management problem statement!");


            List<ProductReview> productReviewList = new List<ProductReview>()
            {

                new ProductReview() { ProductID = 1, UserID = 1, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 3, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 5, UserID = 1, Rating = 2, Review = "okay", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 6, Rating = 1, Review = "bad", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 4, Rating = 1, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 9, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 10, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 2, Rating = 8, Review = "Excellent", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 4, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 3, Rating = 5, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 4, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductID = 2, UserID = 5, Rating = 7, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 8, Rating = 3, Review = "very bad", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 3, Rating = 6, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 7, UserID = 5, Rating = 8, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 1, Rating = 7, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 4, UserID = 3, Rating = 7, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 9, UserID = 2, Rating = 4, Review = "bad", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 7, Rating = 6, Review = "okay", isLike = true },
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 8, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 9, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 5, UserID = 1, Rating = 4, Review = "bad", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 1, Rating = 7, Review = "nice", isLike = true },
            };

            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID: " + list.ProductID + "UserId: " + list.UserID + "Rating: " + list.Rating
            //        + "Review: " + list.Review + "IsLike: " + list.isLike);
            //}

            //object of management class
            Management management = new Management();
            //UC2
            //management.TopRecords(productReviewList);

            //UC3
            //Select specific records with id = 1, 4, 9 and rating > 3
            //management.SelectedRecords(productReviewList);

            //UC4
            //Counts products by product id
            //management.RetrieveCountOfRecords(productReviewList);

            //UC5
            //Gets Product id and reviews
            //management.RetrieveProductIdAndReview(productReviewList);

            //UC6
            //Get all product records except top 5
            //management.RetrieveProductsBySkippingTop5(productReviewList);

            //UC7
            //Retrieveonlyproductid
            //Management.RetrieveOnlyProductIDAndReviewOfAllRecordsUsingSelect(productReviewList);

            //UC 8
            //Created data table
            //ProductReviewDataTable.AddDataIntoDataTable();

            //UC 9
            //Retrieve all records from data table from islike
            ProductReviewDataTable.RetrieveAllRecordsWhoseIsLikeIsTrue();
        }
    }

}