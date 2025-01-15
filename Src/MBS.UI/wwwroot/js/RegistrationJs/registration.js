$(document).ready(function () {
    $('#districtId').attr("disabled", true);
    $('#subDistrictId').attr("disabled", true);
    loadDivisionDropdown();

});

function loadDivisionDropdown() {
    //divisionId
    var divison = null;

    $.ajax({

        url: "/PublicUser/Home/GetAllDivision/",
        method: "GET",
        type: "json",
        async: false,
        success: function (data) {
            divison = data.data;
            $('#divisionId').empty();
            $('#divisionId').append('<option selected disabled>--Select-- </option>');
           $.each(data.data, function (i, obj) {
                $('#divisionId').append('<option value=' + obj.id + '>' + obj.divisionName + ' </option>');
            })

        }
    })
}


$('#divisionId').change(function () {

    $('#districtId').attr("disabled", false);

    var id = $('#divisionId option:selected').val();
    

    $.ajax({

        url: "/PublicUser/Home/GetAllDistrictById/"+id,
        method: "GET",
        type: "json",
        async: false,
        success: function (data) {
            divison = data.data;
            
            $('#districtId').empty();
            $('#districtId').append('<option selected disabled>--Select-- </option>');
            $.each(data.data, function (i, obj) {
                $('#districtId').append('<option value=' + obj.id + '>' + obj.districtName + ' </option>');
            })

        }
    })
});



$('#districtId').change(function () {

    $('#subDistrictId').attr("disabled", false);

    var id = $('#districtId option:selected').val();
    debugger

    $.ajax({

        url: "/PublicUser/Home/GetAllSubDistrictById/" + id,
        method: "GET",
        type: "json",
        async: false,
        success: function (data) {
            divison = data.data;
            debugger
            $('#subDistrictId').empty();
            $('#subDistrictId').append('<option selected disabled>--Select-- </option>');
            $.each(data.data, function (i, obj) {
                $('#subDistrictId').append('<option value=' + obj.id + '>' + obj.subDistrictName + ' </option>');
            })

        }
    })
});




