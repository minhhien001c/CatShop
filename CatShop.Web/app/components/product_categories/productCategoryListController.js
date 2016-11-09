﻿(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope','apiService'];
    function productCategoryListController($scope, apiService)
    {
        $scope.productCategories = [];
        $scope.getProductCategories = getProductCategories;
        function getProductCategories()
        {
            apiService.get('/api/productcategory/getall', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Load product categories fail.');
            });
        }
        //goi khi controller khoi tao
        $scope.getProductCategories();
    }

})(angular.module('catshop.product_categories'));