function appendCurrentYear(element) {
    var currentValue = document.getElementById(element).innerHTML;
    var currentYear = new Date().getFullYear();
    document.getElementById(element).innerHTML = currentValue + " " + currentYear;
}

function validateString(value) {
    if (value != "") {
        return 1
    } else {
        return 0
    };
}

function validateGUID(value) {
    if (value != "00000000-0000-0000-0000-000000000000") {
        return 1
    } else {
        return 0
    };
}

function loadDataTableWithSearchAndPagination(tableId) {
    $(tableId).DataTable({
        "ordering": false
    });
}