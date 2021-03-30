
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
