angular.module('categoryApp').controller('CategoryListCtrl',
    ['CategoryDataService', '$location',
        function (CategoryDataService, $location) {
            'use strict';
            var vm = this;
            this.title = "Category List";
            this.categories = [];
            CategoryDataService.getCategories().then(function (data) {
                vm.categories = data;
            });
            this.onEdit = function (category) {
                $location.path('/categories/category/' + category.id)
            }
            this.onNew = function () {
                $location.path('/categories/category/new');
            }
            this.onDelete = function (category) {
                var id = category.id;
                CategoryDataService.remove(category.id).then(function (response) {
                    var idx =
                    vm.categories.findIndex(function (elem, idx) {
                        return elem.id === id;
                    });
                    vm.categories.splice(idx, 1);
                })
            }
}]);