using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web.Http;
using System;
using System.Net;
using System.Net.Http;

namespace angularTraining.Controllers.api
{
    public class RestaurantsController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public HttpResponseMessage GetRestaurants()
        {
            var result = new JArray {
                new JObject {
                    { "Id", 1 },
                    { "Name", "Cheesecake Factory" },
                    { "City", "Bellevue" },
                    { "Price", "$$" },
                    { "Logo", "https://pbs.twimg.com/profile_images/493827744271052800/-4AKJWIQ.jpeg" }
                },
                new JObject {
                    { "Id", 2 },
                    { "Name", "Red Robin" },
                    { "City", "Bellevue" },
                    { "Price", "$" },
                    { "Logo", "http://cdn.patch.com/users/22821257/2015/02/T800x600/20150254ce85b5cdbdf.png" }
                },
                new JObject {
                    { "Id", 3 },
                    { "Name", "Five Guys" },
                    { "City", "Redmond" },
                    { "Price", "$" },
                    { "Logo", "http://www.sunridgemall.com/system/store_fronts/4492/original/five-guys-burgers-fries_0.jpg?1453391524" }
                }
            };
            return this.Request.CreateResponse(
                    statusCode: HttpStatusCode.OK,
                    value: result
                );
        }

        // GET api/<controller>/5
        [HttpGet]
        public HttpResponseMessage GetRestaurant(int restaurantId)
        {
            JObject result = null;
            switch (restaurantId)
            {
                case 1:
                    result = new JObject {
                        { "Id", 1 },
                        { "Name", "Cheesecake Factory" },
                        { "City", "Bellevue" },
                        { "Price", "$$" },
                        { "Logo", "https://pbs.twimg.com/profile_images/493827744271052800/-4AKJWIQ.jpeg" }
                    };
                    break;
                case 2:
                    result = new JObject {
                        { "Id", 2 },
                        { "Name", "Red Robin" },
                        { "City", "Bellevue" },
                        { "Price", "$" },
                        { "Logo", "http://cdn.patch.com/users/22821257/2015/02/T800x600/20150254ce85b5cdbdf.png" }
                    };
                    break;
                case 3:
                    result = new JObject {
                        { "Id", 3 },
                        { "Name", "Five Guys" },
                        { "City", "Redmond" },
                        { "Price", "$" },
                        { "Logo", "http://www.sunridgemall.com/system/store_fronts/4492/original/five-guys-burgers-fries_0.jpg?1453391524" }
                    };
                    break;
            }

            return this.Request.CreateResponse(
                    statusCode: (result != null) ? HttpStatusCode.OK : HttpStatusCode.NotFound,
                    value: result
                );
        }
    }
}