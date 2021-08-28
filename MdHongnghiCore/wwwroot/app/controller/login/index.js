var loginController = function () {
    this.initiallize = function () {
        registerEvents();
    }
    var registerEvents = function () {
        $('#btnLogin').on('click', function (e) {
            e.preventDefault();
            var user = $('#txtUsername').val();
            var password = $('#txtPassword').val();
            login(user, password);
        })

    }
    var login = function (user, password) {
        $.ajax({
            type: 'POST',
            data: {
                UserName: user,
                Password: password
            },
            dataType: 'json',
            url: '/admin/login/authen',
            success: function (res) {
                if (res.Success) {
                    window.location.href = "/Admin/Home/Index";
                }
                else {
                    hn.notify('Sai thông tin đăng nhập','error');
                }
            }
        })
    }
}