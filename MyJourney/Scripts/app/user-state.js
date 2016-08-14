$(function () {

        //Fake wait
        setTimeout(function () {
            Top10Adverts();
        }, 10000);

       
        //If register link clicked
        $("#registerLink").click(function () {
            $('#myModal').appendTo("body");
            $("#myModal").load('/MyJourney/Session/Register');
        });

        //if login link clicked
        $("#loginLink").click(function () {
            //to-do Login dialog
        });

        function Top10Adverts() {
            $.ajax({
                url: '/MyJourney/Advertisement/Top10Advert',
                data: {
                    format: 'json'
                },
                error: function () {
                    $('#imgLoader').hide();
                    $('#divTop10').html('<p>An error has occurred</p>');
                },
                success: function (data) {
                    $('#imgLoader').hide();
                    for (var i = 0; i < data.length - 1; i++) {
                        $('#divTop10').append("<a href='/MyJourney/Advertisement/Detail/" + data[i].Title.replace(" ", "-") + "'><h4>" + data[i].Title + "</h4>" + "<img src='/MyJourney/advs/" + data[i].Image + "' width='100px' /></a>");
                    }
                },
                type: 'GET'
            });
        }
});

