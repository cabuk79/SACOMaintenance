////function initialize() {
////    var latlng = new google.maps.LatLng(40.716948, -74.003563);
////    var options = {
////        zoom: 14, center: latlng,
////        mapTypeId: google.maps.MapTypeId.ROADMAP
////    };
////    var map = new google.maps.Map(document.getElementById("map"), options);
////}


function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}