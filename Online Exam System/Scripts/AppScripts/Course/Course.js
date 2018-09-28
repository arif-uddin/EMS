$(document).ready(function () {

    $(document).on("submit", "#CourseAddPage", function (e) {

        e.preventDefault();

        $.ajax({
            type: "POST",
            url: "../../Course/GetCourseCreatePartial",
            data: $(this).serialize(),
            datatype: "html",
            success: function (data) {
                $(document).ajaxSuccess(function () {
                    // alert("Course Added Successfully");
                    $('#CourseAddPage')[0].reset();
                });
            }
        });


    });

});
