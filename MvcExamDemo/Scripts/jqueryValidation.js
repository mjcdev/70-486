$(document).ready(function () {
    $('#propertyName').rules("add",
        {
            required: true,
            messages : {
                required: "Please Enter"
            }
        }
})