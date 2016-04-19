(function () {
    var app = angular.module('chat-app', []);

    app.controller('LiveQueueController', function ($scope) {
        // scope variables
        $scope.liveQueue = [];

        $scope.chatDashboardHub = null; // holds the reference to hub

        $scope.chatDashboardHub = $.connection.chatDashboardHub; // initializes hub
        $.connection.hub.start(); // starts hub

        // register a client method on hub to be invoked by the server

        chat.client.broadcastLiveQueue = function (data) {

            data.forEach(function (dataItem) {
            });



        }
    })
});