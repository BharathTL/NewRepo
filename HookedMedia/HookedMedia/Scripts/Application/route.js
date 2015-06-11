hooked.config(['$routeProvider',
        function ($routeProvider) {
            $routeProvider.
                    when('/new', {
                        templateUrl: 'Content/Templates/newcampaign.html',
                        controller: 'newcampaign'
                    }).
                    when('/route2', {
                        //templateUrl: 'angular-route-template-2.jsp',
                        //controller: 'RouteController'
                    }).
                    otherwise({
                        redirectTo: '/'
                    });
        }]);