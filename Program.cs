//c# http post and get

using Newtonsoft.Json;
using PlayGround;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main(string[] args)
    {

        string Title = "test";
        string Body = "hello world";
        int Userid = 10;
        //http client allows you to facilitate gets and posts methods (its a standard object in c#)
        //using statements are used when we want to dispose of objects like connections we dont want to keep arround

        using (var client = new HttpClient())
        {
            //first things first get the url of the api you want to call
            Uri url = new Uri("https://jsonplaceholder.typicode.com/posts");
            var newPosts = new PostModels(Title, Body, Userid);
           


            //var newPosts = new PostModels();
            //newPosts.UID = 31;
            //newPosts.Title = "Test";
            //newPosts.Body = "hello world";


            //convet the strings to JSON we use the serialize object function in the json convert class
            var newPostJSON = JsonConvert.SerializeObject(newPosts);

            //send the data over to the api (this is called a payload
            var payLoad = new StringContent(newPostJSON,Encoding.UTF8,"application/json");/*lets decode any special char*/

            var result = client.PostAsync(url, payLoad).Result.Content.ReadAsStringAsync();

            //or we do it like this



            // var result =  client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;  //THIS IS A GET METHOD

        } //will be disposed off when we hit thiss curly brace
    }
}