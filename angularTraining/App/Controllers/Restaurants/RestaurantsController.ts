/// <reference path="..\..\_controllersDefinition.ts"/>

module AngularTraining.Controllers {
    "use strict";

    export class RestaurantsController {

        public static $inject: string[] = [
            "$scope",
            "$http"
        ];

        constructor($scope: IRestaurantsScope,
            $http: ng.IHttpProvider) {
            $scope.control = new RestaurantsControl($http);
        }
    }

    angular.module("AngularTraining.Controllers").controller("restaurantsController", RestaurantsController);
}
