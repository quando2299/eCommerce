$('.table').on('input', '.quantity', function () {
    var totalSum = 0;
    $('.table .prc').each(function () {
        var inputVal = $(this).val();
        if ($.isNumeric(inputVal)) {
            totalSum += parseFloat(inputVal);
        }
    });
    $('#result').text(totalSum);
});