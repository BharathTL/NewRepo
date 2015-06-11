hooked.controller("newcampaign", function ($scope, $http) {

    $http.get("api/masterapi").success(
                        function (response) {
                            var parsedJSON = response.masterRepository;
                            for (var i = 0; i < parsedJSON.length; i++) {
                                //alert(parsedJSON[i].keys);
                                //alert(parsedJSON[i].value);
                            }
                            $scope.campaignCode = response.CampaignCode;
                           
                        }).error(
                        function (response) {

                            alert(response);
                        });


    $scope.addCreative = function () {
        $http.post("api/creative?campaignCode="+$scope.campaignCode+"&creativeTitle="+$scope.creativeTitle+"&creativeType="+$scope.creativeType+"&vastUrl="+$scope.vastUrl+"&xmlContent="+$scope.xmlContent).success(
                         function (response) {
                             alert(response);

                         }).error(
                         function (response) {

                             alert(response);
                         });
    };

    $scope.campaignSubmit = function () {
        alert($scope.campaignData);
        $http.post("api/CreateCampaign",$scope.campaignData).success(
                        function (response) {

                        }).error(
                        function (response) {
                        });
    }
    
})