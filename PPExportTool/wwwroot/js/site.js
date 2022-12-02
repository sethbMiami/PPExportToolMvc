// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $("#exporttable").click(function (e) {
        var table = $("#htmltable");
        if (table && table.length) {
            $(table).table2excel({
                exclude: ".noExl",
                name: "Excel Document Name",
                filename: "PPExportApi" + new Date().toISOString().replace(/[\-\:\.]/g, "") + ".xls",
                fileext: ".xls",
                exclude_img: true,
                exclude_links: true,
                exclude_inputs: true,
                preserveColors: false
            });
        }
    });

});
