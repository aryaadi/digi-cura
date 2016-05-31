angular.module('categoryApp').factory('CategoryDataService', ['$http', '$q', '$log', function ($http, $q, $log) {
    'use strict';
    return {
        getCategories : function () {
            var deferred = $q.defer();
            $http
                .get('/api/categories')
                .success(function (response) {
                    deferred.resolve(response);
                })
                .error(function (msg, code) {
                    deferred.reject(msg);
                    $log.error(msg, code)
                });
            return deferred.promise;
        },
        getCategory: function (id) {
            var deferred = $q.defer();
            $http
                .get('/api/category/' + id)
                .success(function (response) {
                    deferred.resolve(response);
                })
                .error(function (msg, code) {
                    deferred.reject(msg);
                    $log.error(msg, code)
                });
            return deferred.promise;
        },
        save: function (category) {
            var deferred = $q.defer();
            var options = {
                method: 'POST',
                url: '/api/category/save',
                data: category
            };
            $http(options)
                .success(function (response) {
                    deferred.resolve(response);
                })
                .error(function (msg, code) {
                    deferred.reject(msg);
                    $log.error(msg, code)
                });
            return deferred.promise;
        },
        remove: function (id) {
            var deferred = $q.defer();
            var options = {
                method: 'DELETE',
                url: '/api/category/' + id
            };
            $http(options)
                .success(function (response) {
                    deferred.resolve(response);
                })
                .error(function (msg, code) {
                    deferred.reject(msg);
                    $log.error(msg, code)
                });
            return deferred.promise;
        }
    }
}]);