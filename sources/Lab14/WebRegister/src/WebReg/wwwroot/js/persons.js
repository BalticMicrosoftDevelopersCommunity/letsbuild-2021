import * as table from './table.js';

window.onload = function () {
    table.on_sort_click();
    table.on_first_page_click();
    table.on_last_page_click();
    table.on_page_click();
    table.on_prev_page_click();
    table.on_next_page_click();
}