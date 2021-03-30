
var set_first_page = function () {
    $('[name="PageNumber"]').val("1");
    $('[name="PageIndex"]').val("1");
}

export function on_sort_click() {
    $('table th').click(function (event) {

        event.preventDefault();

        let sortColumn = $(this).data("column").toString();
        let previousColumn = $('[name="SortColumn"]').val().toString();
        let previousOrder = $('[name="SortOrder"]').val();
        let sortOrder = "asc";
        if (sortColumn === previousColumn) {
            sortOrder = (previousOrder == "desc") ? "asc" : "desc";
        }

        $('[name="SortColumn"]').val(sortColumn);
        $('[name="SortOrder"]').val(sortOrder);
        $('[name="PageNumber"]').val("1");
        $('[name="PageIndex"]').val("1");
        $('#form').submit();
    });
}

export function on_page_size_click() {
    $('.search-toolbar .page-size button').click(function (event) {
        event.preventDefault();
        let selectedPageSize = $(this).text();
        $('[name="PageSize"]').val(selectedPageSize);
        set_first_page();

        $('#form').submit();
    });
}

export function on_first_page_click() {
    $('.pager .btn-first').click(function (event) {
        event.preventDefault();
        set_first_page();
        $('#form').submit();
    });
}

export function on_last_page_click() {
    $('.pager .btn-last').click(function (event) {
        event.preventDefault();
        let totalPages = $('[name="TotalPages"]').val();
        let pagerSize = $('[name="PagerSize"]').val();
        $('[name="PageNumber"]').val(totalPages);
        $('[name="PageIndex"]').val(pagerSize);
        $('#form').submit();
    });
}

export function on_page_click() {
    $('.pager .btn-number').click(function (event) {
        event.preventDefault();
        let selectedPage = $(this).text();
        let pageIndex = $(this).data("id");
        $('[name="PageNumber"]').val(selectedPage);
        $('[name="PageIndex"]').val(pageIndex);
        $('#form').submit();
    });
}

export function on_prev_page_click() {
    $('.pager .btn-prev').click(function (event) {
        event.preventDefault();
        let btn = $('.pager .btn-number.active');
        let selectedPage = parseInt(btn.text(), 10) - 1;
        let pageIndex = parseInt(btn.data("id"), 10) - 1;
        if (pageIndex < selectedPage && pageIndex < 2) pageIndex = 2;
        if (pageIndex < 1) pageIndex = 1;
        $('[name="PageNumber"]').val(selectedPage);
        $('[name="PageIndex"]').val(pageIndex);
        $('#form').submit();
    });
}

export function on_next_page_click() {
    $('.pager .btn-next').click(function (event) {
        event.preventDefault();
        let btn = $('.pager .btn-number.active');
        let totalPages = parseInt($('[name="TotalPages"]').val(), 10);
        let pagerSize = parseInt($('[name="PagerSize"]').val(), 10);
        let selectedPage = parseInt(btn.text(), 10) + 1;
        let pageIndex = parseInt(btn.data("id"), 10) + 1;
        if (totalPages > pagerSize && pageIndex >= 5 && selectedPage != totalPages) pageIndex = 4;
        if (pageIndex > pagerSize) pageIndex = pagerSize;
        $('[name="PageNumber"]').val(selectedPage);
        $('[name="PageIndex"]').val(pageIndex);
        $('#form').submit();
    });
}
