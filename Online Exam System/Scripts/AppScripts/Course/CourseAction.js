
$(function () {

    $("a.coursedeleteLink").click(function (e) {
        e.preventDefault();
        $.post($(this).attr("href"), function (data) {

            $.ajax({
                type: "GET",
                url: "../../Course/GetCourseListPartial",
                contentType: "application/JSON; charset=utf-8",
                data: JSON.stringify(),
                success: function (rData) {

                    $("#PartialDiv").html(rData);
                }

            });

        });

    });

    $(".courseupdateLink").click(function () {
        var url = $(this).attr("data-url");
        $.post(url, function (rData) {
            $("#PartialDiv").html(rData);
        });

    });

    $(document).on("submit", "#CourseEditPage", function (e) {

        e.preventDefault();

        $.ajax({
            type: "POST",
            url: "../../Course/Update",
            data: $(this).serialize(),
            datatype: "html",
            success: function (data) {

                    // alert("Course Added Successfully");
                    $.ajax({
                        type: "GET",
                        url: "../../Course/GetCourseListPartial",
                        contentType: "application/JSON; charset=utf-8",
                        data: JSON.stringify(),
                        success: function (rData) {

                            $("#PartialDiv").html(rData);
                        }

                    });
            }
        });


    });

    //Course Details 
    $(".coursedetailsLink").click(function () {
        var url = $(this).attr("data-url");
        $.post(url,
            function (rData) {
                $("#PartialDiv").html(rData);
            });

    });
    
});