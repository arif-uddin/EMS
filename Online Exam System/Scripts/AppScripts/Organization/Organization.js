
$(document).ready(function () {



    $(document).on("submit", "#OrganizationAddPage", function (e) {

        e.preventDefault();

        $.ajax({
            type: "POST",
            url: "../../Organization/GetOrganizationCreatePartial",
            data: $(this).serialize(),
            datatype: "html",
            success: function (data) {
                //$(document).ajaxSuccess(function () {
                //    alert("Organization Added Successfully");
                //});
            }
        });


    });
    

});

