function appendCurrentYear(element) {
    var currentValue = document.getElementById(element).innerHTML;
    var currentYear = new Date().getFullYear();
    document.getElementById(element).innerHTML = currentValue + " " + currentYear;
}