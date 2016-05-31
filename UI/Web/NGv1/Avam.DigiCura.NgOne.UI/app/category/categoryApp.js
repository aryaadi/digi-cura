var categoryApp = angular.module('categoryApp', ['ngRoute']);

categoryApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/categories', {
            templateUrl: '/app/category/category-list.html',
            controller: 'CategoryListCtrl',
            controllerAs : 'vm'
        })
        .otherwise({
            redirectTo: '/categories'
        });


}]);