$("#pane").position({
    my: "centre",
    at: "centre",
    of: "#paneContainer"
})
function togglePane() {
    $("#pane").toggle("bounce", { distance: 100, times: 9 }, "slow");
}

function changeVal() {
    var textVal = $('#field1').val();
    $('#display').html(textVal);
}

function changeStyle() {
    $('#display').css('background-color', '#01ff03');
}

function clearAll() {
    $('#display').html('Sample message appears here');
    $('#display').css('background-color', '#efeeef');
}

function initPicker() {
    $('#dp').datepicker();
}

function toggleList1() {
    $('#list1').toggle("fold", 1500);
}

function toggleList2() {
    $('#list2').toggle("fold", 300);
}