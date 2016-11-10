﻿(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope','apiService'];
    function productCategoryListController($scope, apiService)
    {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.getProductCategories = getProductCategories;
        function getProductCategories(page)
        {
            page = page || 0;
            var config = {
                params: {
                    page: page,
                    pageSize: 2
                }
            };

            apiService.get('/api/productcategory/getall', config, function (result) {
                $scope.productCategories = result.data.Items;
                $scope.page=result.data.Page,
                $scope.pagesCount = result.data.TotalPage;
                $scope.totalCount = result.data.TotalRow;
            }, function () {
                console.log('Load product categories fail.');
            });
        }
        //function getProductCategories(page) {
        //    page = page || 0; //page = null thi se thay bang 0
        //    var config = {
        //        params: {                   
        //            page: page, //bien page nay giong nhu ten trong productCategoryController 
        //            pageSize: 2
        //        } //dinh dang de truyen parameter
        //    }
        //    apiService.get('/api/productcategory/getall', config, function (result) {
               
        //        $scope.productCategories = result.data.Items;
        //        $scope.page = result.data.Page;
        //        $scope.pagesCount = result.data.TotalPage;
        //        $scope.totalCount = result.data.TotalCount;
        //    }, function () {
        //        console.log("Load product categories fail");
        //    });
        //}
        //goi khi controller khoi tao
        $scope.getProductCategories();
    }

})(angular.module('catshop.product_categories'));