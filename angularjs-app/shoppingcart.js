var app = angular.module('shoppingcart', []).factory('ShoppingCart', ['$rootScope', '$http', '$q', function ($rootScope, $http, $q) {
    var obj = {};

    $rootScope.products = [{ "id": "product1", "price": 50000, "productName": "Iphone8" },
    { "id": "product2", "price": 25000, "productName": "Mi Mix 2" },
    { "id": "product3", "price": 35000, "productName": "Samsung S8" },
    { "id": "product4", "price": 33000, "productName": "One Plus5" },
    ];

    $rootScope.addedProducts = localStorage.getItem("Products") != undefined ? JSON.parse(localStorage.getItem("Products")) : [];
    console.log($rootScope.addedProducts);
    obj.deleteProduct = function (product) {
        $rootScope.addedProducts.pop(product);
        localStorage.setItem("Products", JSON.stringify($rootScope.addedProducts));
    }

    obj.addProduct = function (product) {
        for (var p of $rootScope.addedProducts) {
            if (p.id == product.id) {
                p.quantity = parseInt(p.quantity) + parseInt(product.quantity);
                p.totalprice = p.unitprice * p.quantity
                product = p;
                $rootScope.addedProducts.pop(p);
            }
        }

        $rootScope.addedProducts.push(product);
        localStorage.setItem("Products", JSON.stringify($rootScope.addedProducts));
    }

    obj.checkout = function () {
        $rootScope.totalprice = 0;
        for (var p of $rootScope.addedProducts) {
            $rootScope.totalprice += p.totalprice;
        }
        console.log($rootScope.totalprice);
    }

    return obj;
}]);

app.controller("productsCtrl", ['$rootScope', '$scope', 'ShoppingCart', '$http', function ($rootScope, $scope, ShoppingCart, $http) {

    $scope.addProduct = function (product) {

        for (var p of $rootScope.products) {
            if (p.productName === product) {
                product = p;
            }
        }

        var productToAdd = {
            "id": product.id,
            "name": product.productName,
            "quantity": $scope.quantity,
            "unitprice": product.price,
            "totalprice": product.price * $scope.quantity
        }
        ShoppingCart.addProduct(productToAdd);
    }

    $scope.deleteProduct = function (product) {
        ShoppingCart.deleteProduct(product);
    }

    $scope.checkout = function () {
        ShoppingCart.checkout();
    }


}]);


