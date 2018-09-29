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

    //JS code for tags
    //$('#inputtags').on('beforeItemAdd', function (event) {
    //    var tag = event.item;
    //    // Do some processing here

    //    if (!event.options || !event.options.preventPost) {
    //        $.ajax('/ajax-url', ajaxData, function (response) {
    //            if (response.failure) {
    //                // Remove the tag since there was a failure
    //                // "preventPost" here will stop this ajax call from running when the tag is removed
    //                $('#tags-input').tagsinput('remove', tag, { preventPost: true });
    //            }
    //        });
    //    }
    //});

});
