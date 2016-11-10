(function (app) {
    app.filter('statusFilter', function () {
        return function (status)
        {
            if (status)
                return 'Kích hoạt';
            else
                return 'Khóa';
        }
    });
    

})(angular.module('catshop.common'));