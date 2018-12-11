console.log("test");
var knap = jQuery("#minKnap"); //$

knap.click(function(){

    //consol.log("12");

    $.getJSON("/Home/Test5").done(function (data) {

        var ol = $("#minListe");
        ol.empty();
        for (var i = 0; i < data.length; i++) {
            var li = $("<li />").html(data[i].Navn);
            ol.append(li);
        }
    })
})