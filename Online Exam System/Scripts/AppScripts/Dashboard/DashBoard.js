$(document).ready(function () {
    $('#sidebarCollapse').on('click',
        function () {
            $('#sidebar').toggleClass('active');
        });
});
$("#LoadOrganizationAddPage").click(function () {

    $.ajax({
        type: "POST",
        url: "../../Organization/GetOrganizationCreatePartial",
        contentType: "application/JSON; charset=utf-8",
        data: JSON.stringify(),
        success: function (rData) {

            $("#OrganizationCreatePartialDiv").html(rData);
        }

    });

});