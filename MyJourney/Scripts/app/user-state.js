$(function () {
        //If register link clicked
        $("#registerLink").click(function () {
            $('#myModal').appendTo("body");
            $("#myModal").load('/MyJourney/Session/Register');
        });

        //if login link clicked
        $("#loginLink").click(function () {
            $('#myModal').appendTo("body");
            //$("#myModal").load('/MyJourney/Session/Register');
            $("#myModal").load('<h1>Login</h1>');
        });
});