$("#pane").position({
    my: "centre",
    at: "centre",
    of: "#paneContainer"
})
function togglePane() {
    $("#pane").toggle("bounce", { distance: 100, times: 9 }, "slow");
}