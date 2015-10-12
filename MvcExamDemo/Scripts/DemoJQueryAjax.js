$("#btnRequest").click(function () {
    $.ajax({
        url: "JQueryAjax",
        type: "POST",
        success: function (data, textStatus, xhr) {
            var successMsg = "Request Complete: " + textStatus;
            alert(successMsg);
            $("#resultContainer").html(data);
        },
        error: function (xhr, status, error) {
            var errorMsg = "Request Failed: " + error;
            alert(errorMsg);
        },
        statusCode: {
            404: function () {
                alert("Error: Page not found)");
            }
        },
        complete: function (xhr, textStatus) {
            var doneMsg = "Finished with status: " + textStatus;
            alert(doneMsg);
        }
    });
})

$("#btn1").click(function () {
    $.ajax({
        url: "JQueryAjaxPartial",
        type: "POST",
        success: function (result) {            
            $("#XHResponse").html(result);
        },
        error: function (xhr, status, error) {
            var errorMsg = "Request Failed: " + error;
            $("#XHResponse").html(errorMsg);
        },
        complete: function (xhr, status) {
            var doneMsg = "Finished with status: " + status;
            alert(doneMsg);
        }
    });
})
