(function () {
    angular.module('catshop.product_categories', ['catshop.common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories', {
            url: '/product_categories',
            templateUrl: '/app/components/product_categories/productCategoryListView.html',
            controller: 'productCategoryListController'
        });
    }
})();