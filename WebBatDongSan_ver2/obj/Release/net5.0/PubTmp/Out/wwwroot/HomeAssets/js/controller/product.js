var user = {
    init: function () {
        user.registerEvents();
    },

    registerEvents: function () {
        $(document).ready(function () {
            $.ajax({
                url: '/api/Products/',
                type: 'GET',
                cache: false,
                dataType: 'json',
                success: function (data) {
                    var markup = '<div class="row text-center">';
                    var newID = 0;
                    for (var index = 0; index < data.length; index++) {
                        markup = '<div class="col-md-4 pb-1 pb-md-0">';
                        markup = '<div class="card">';
                        markup = '<img class="card-img-top" src="' + data[index].PathImage + '" alt="Card image cap">';
                        markup = '<div class="card-body">';
                        markup = '<h5 class="card-title">' + data[index].Name + '</h5>';
                        markup = '<p class="card-text">Giá: ' + data[index].Price + '</p>';
                        markup = '<p class="card-text"> Diện tích: ' + data[index].Acreage + 'm2</p>';
                        markup = '<p class="card-text"> Khu vực: ' + data[index].Description + '</p>';
                        markup = '<a href="#" class="btn btn-primary+">Chi tiết</a>';
                        markup = ' </div>';
                        markup = '</div>';
                        markup = '</div>';

                        newID++;
                    }
                    $('#mainrows .addrow').html(markup);
                },
                error: function (request, message, error) {
                    handleException(request, message, error);
                }
                //error: function (xhr, ajaxOptions, thrownError) {
                //    //some errror, some show err msg to user and log the error  
                //    alert(xhr.responseText);
                //}
            });
        });
    },

}
user.init();