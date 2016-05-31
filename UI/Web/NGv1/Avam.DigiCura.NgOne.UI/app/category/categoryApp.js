var categoryApp = angular.module('categoryApp', ['ngRoute']);

categoryApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/categories', {
            templateUrl: '/app/category/category-list.html',
            controller: 'CategoryListCtrl',
            controllerAs : 'vm'
        })
        .when('/categories/category/:id', {
            templateUrl: '/app/category/category.html',
            controller: 'CategoryCtrl',
            controllerAs: 'vm'
        })
        .otherwise({
            redirectTo: '/categories'
        });


}]);