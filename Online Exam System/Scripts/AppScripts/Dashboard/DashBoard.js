$(document).ready(function () {

    $('#sidebarCollapse').on('click',
        function () {
            $('#sidebar').toggleClass('active');
        });


    $("#LoadOrganizationAddPage").click(function () {

        $.ajax({
            type: "GET",
            url: "../../Organization/GetOrganizationCreatePartial",
            contentType: "application/JSON; charset=utf-8",
            data: JSON.stringify(),
            success: function (rData) {

                $("#PartialDiv").html(rData);
            }

        });
    });


    $("#LoadOrganizationListPage").click(function () {

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

    $("#LoadCourseAddPage").click(function () {

        $.ajax({
            type: "GET",
            url: "../../Course/GetCourseCreatePartial",
            contentType: "application/JSON; charset=utf-8",
            data: JSON.stringify(),
            success: function (rData) {

                $("#PartialDiv").html(rData);
            }

        });
    });
    $("#LoadCourseListPage").click(function () {

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

    $("#LoadCourseListPage").click(function () {

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