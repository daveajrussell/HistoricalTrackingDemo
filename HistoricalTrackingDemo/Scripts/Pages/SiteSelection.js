var SiteSelection = {

    Init: function () {
        $(function () {
            $('#site-selection .site-selection-item').each(function (index) {
                if (index == 1) {
                    $(this).find('.link').addClass('active');
                }
            });
        });
    }

};

SiteSelection.Init();