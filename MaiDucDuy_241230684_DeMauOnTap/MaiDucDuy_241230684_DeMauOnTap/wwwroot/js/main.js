// BookHub - hiệu ứng giao diện cơ bản (nút "lên đầu trang")
$(function () {
    $(window).on('scroll', function () {
        $('.to-top').toggle($(this).scrollTop() > 200);
    });
    $('.to-top').on('click', function () {
        $('html, body').animate({ scrollTop: 0 }, 400);
    });
    $('.search-box input').on('focus', function () { $(this).select(); });
    $('.nav-category').on('click', function (e) {
        e.preventDefault();
        if ($('#main-content').length == 0) {
            window.location.href = '/Home/Index';
            return
        }
        $('.menu li').removeClass('active');
        $(this).parent('li').addClass('active');
        var maTL = $(this).data('id');
        $.ajax({
            url: '/Home/GetSachByTheLoai',
            type: 'GET',
            data: { maTL: maTL },
            success: function (response) {
                $('#main-content').html(response);
            },
            error: function () {
                alert('Không thể tải dữ liệu sách!');
            }

        });
    });
});

