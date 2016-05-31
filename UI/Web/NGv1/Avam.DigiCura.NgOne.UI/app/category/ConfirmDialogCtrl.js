angular.module('categoryApp').controller('ConfirmDialogCtrl', ['$uibModalInstance', 'category', function (modelInstance,category) {
    'use strict';
    this.title = 'Delete Category [' + category.name + "]";

    this.onYes = function () {
        modelInstance.close('yes');
    }
    this.onNo = function () {
        modelInstance.dismiss('cancel');
    }
}]);