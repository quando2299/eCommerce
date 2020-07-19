function showMess() {
    var x = document.getElementById("submit_payment");
    x.className = "show";
    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
}