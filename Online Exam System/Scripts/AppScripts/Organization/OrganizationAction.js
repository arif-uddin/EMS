$(function () {
    $("a.deleteLink").click(function (e) {
        e.preventDefault();
        $.post($(this).attr("href"), function (data) {

            $.ajax({
                type: "GET",
                url: "../../Organization/GetOrganizationListPartial",
                contentType: "application/JSON; charset=utf-8",
                data: JSON.stringify(),
                success: function (rData) {

                    $("#PartialDiv").html(rData);
                }

            });

        });

    });



    $(".updateLink").click(function () {
        var url = $(this).attr("data-url");
        $.post(url, function (rData) {
            $("#PartialDiv").html(rData);
        });

    });


    //Organization Details 
    $(".detailsLink").click(function() {
        var url = $(this).attr("data-url");
        $.post(url,
            function(rData) {
                $("#PartialDiv").html(rData);
            });

    });


    $(document).on("submit", "#OrganizationEditPage", function (e) {

        e.preventDefault();

        $.ajax({
            type: "POST",
            url: "../../Organization/Update",
            data: $(this).serialize(),
            datatype: "html",
            success: function (data) {
//                $(document).ajaxSuccess(function() {
//                    alert("Organization Added Successfully");
                
                
                $.ajax({
                    type: "GET",
                    url: "../../Organization/GetOrganizationListPartial",
                    contentType: "application/JSON; charset=utf-8",
                    data: JSON.stringify(),
                    success: function (rData) {

                        $("#PartialDiv").html(rData);
                    }

                });
            }
        });
    });


});