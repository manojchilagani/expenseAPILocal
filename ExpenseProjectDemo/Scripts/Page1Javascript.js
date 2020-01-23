
//function ShowInModal(e) {
//    $("#ShowExpensetable").html("");
//    var dataItems = $(e).parent().parent().clone();
//    dataItems.find('td:last-child').remove();
//    datarow = $("<tr>").append(dataItems);

//    var items = []; datarow.find("td").each(function () { console.log($(this).text() + " "); items.push($(this).text()); });
//    $.each(items, function (i, val) { $("#ShowExpensetable").append($("<tr><td>" + val + "</td></tr>")); })
//}
        //$("#Year").change(function () {

        //    var y = $("#Year").val();
        //    //alert(y);
        //    $.ajax({
        //        method: "POST",
        //        url: "/Demo/Extractdata",
        //        contentType: "application/json; charset=utf-8",
        //        data: '{"year":' + y + '}',
        //        dataType: "json",
        //        async: false,
        //        success: function (data) {

        //            //alert(data[0].Allocated);

        //            var s = '';
        //            console.log(data);
        //            for (var i = 0; i < data.length; i++) {
        //                //url = "/Demo/de";
        //                s += '<tr><td title ="' +
        //                    data[i].Allocated +
        //                    " " + data[i].Expense + '">' +
        //                    data[i].Category + '</td><td>' +
        //                    data[i].Allocated + '</td><td>' +
        //                    data[i].Expense + '</td><td>' +
        //                    data[i].Remaining +
        //                    '</td><td>' +
        //                    '<button id="btnExpense' + i + '" class="btn btn-dark float-md-right" type="button" data-target="#ShowExpense" data-toggle="modal" onclick="ShowInModal(this); return false;" > Expenses</button></td></tr>';
        //               
        //            }
        //            $("#tblbody").html(s);
        //        }

        //    })

        //})
            
   

