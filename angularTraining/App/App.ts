module AngularTraining {
    "use strict";

    let app = angular.module("AngularTraining", [
        "AngularTraining.Controllers",
        "AngularTraining.Models",
        "ngRoute"
    ]);

    app.config([
        "$routeProvider",
        ($routeProvider: ng.route.IRouteProvider) => {
            $routeProvider
                .when("/restaurants", {
                    templateUrl: "/App/Controllers/Restaurants/RestaurantsView.html",
                    controller: "restaurantsController"
                })
                .when("/restaurant/:restaurantId", {
                    templateUrl: "/App/Controllers/Restaurant/RestaurantView.html",
                    controller: "restaurantController"
                })
                .otherwise({
                    redirectTo: "/restaurants"
                });
        }
    ]);

    app.run(() => { });
}