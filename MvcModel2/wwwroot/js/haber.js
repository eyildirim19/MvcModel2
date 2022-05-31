
function HaberSlider() {

    var syc = 0;
    setInterval(function () {


        //document.getElementsByClassName("namebox").length;
        var len = $(".namebox").length;


        if (syc >= len) {
            //syc = 0;
            // $("#haberSlider").css("margin-top", "0px");
            var rr = $("#haberSlider").html();
            $("#r").after(rr);
        }

        //document.getElementById("haberSlider").style.marginTop = -(30 * syc++) + "px";
        //$("#haberSlider").css("margin-top", -(30 * syc++) + "px");
        $("#haberSlider").animate({
            marginTop: -(30 * syc++) + "px"
        }, 2000);



        console.log(syc);
        console.log(len);

    }, 2000);

}



$(document).ready(function () {

    HaberSlider();

});