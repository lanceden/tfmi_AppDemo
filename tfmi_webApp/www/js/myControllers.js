/**
 * Created by Lance on 2016/6/26.
 */

var app = angular.module("myApp", ["ionic"]);
app.config(function ($stateProvider) {
        $stateProvider
            .state('news', {
                templateUrl: '../www/tab/news.html'
            })
            .state('productList', {
                templateUrl: '../www/tab/productList.html'
            })
            .state('services', {
                templateUrl: '../www/tab/services.html'
            })
            .state('news1', {
                templateUrl: '../www/news/news1.html'
            })
            .state('news2', {
                templateUrl: '../www/news/news2.html'
            })
            .state('news3', {
                templateUrl: '../www/news/news3.html'
            })
            .state('onlineStore', {
                templateUrl: '../www/onlineStore.html'
            })
            .state('feedBack', {
                templateUrl: '../www/FeedBack.html'
            })
            .state('companyInfo', {
                templateUrl: '../www/companyInfo.html'
            })
            .state('investor', {
                templateUrl: '../www/charityList.html'
            });
    })
  .controller("IndexController", function ($scope, $state, $ionicSideMenuDelegate, $ionicPopup, $http) {
    $state.go("news");
    $scope.formModel = {};
    $scope.appTitle = "台灣產物保險股份有限公司";
    $scope.newsList = [];
      $http.get("http://localhost:55962/tfmi/News/GetNewsList")
      .success(function (data) {
        $scope.newsList = data;
      }).catch(function (err) {
        console.log(err);
    });
    $scope.charityList = [];
      $http.get("http://localhost:55962/tfmi/Charity/GetCharityList")
      .success(function (data) {
          $scope.charityList = data;
      }).catch(function (err) {
          console.log(err);
      });
      $scope.servicesList = [];
      $http.get("http://localhost:55962/tfmi/Services/GetServicesList")
      .success(function (data) {
          $scope.servicesList = data;
      }).catch(function (err) {
          console.log(err);
      });
    $scope.toggleLeftSideMenu = function () {
      $ionicSideMenuDelegate.toggleLeft();
    };
    $scope.submit = function () {
        //console.log($scope.formModel);
        $http.post('http://localhost:55962/tfmi/Feedback/Post', $scope.formModel)
            .then(function successCallback(response) {
            if (!jsonData.success) {
                return false;
            }
            $ionicPopup.alert({
                title: 'Thanks',
                template: $scope.formModel.name + '君您好,感謝您的建議!祝平安.'
            })
            .then(function () {
                  console.log($scope.formModel);
                  $scope.formModel = {};
            });
        }, function errorCallback(err) {
            $ionicPopup.alert({
                title: 'System Error',
                template: err
            })
              .then(function (err) {
                  console.log(err);
                  $scope.formModel = {};
              });
        });
    }
  });
