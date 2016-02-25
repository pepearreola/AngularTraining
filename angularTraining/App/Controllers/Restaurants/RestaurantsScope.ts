module AngularTraining.Controllers {
    "use strict";

    export interface IRestaurantsScope extends ng.IScope {
        control: RestaurantsControl;
    }

    export class RestaurantsControl {
        public restaurants: Models.IRestaurant[];

        constructor(private $http: any) {
            debugger;
            $http.get("api/restaurants").then((data) => {
                this.restaurants = data.data;
            });
        }
    }
}