////function initialize() {
////    var latlng = new google.maps.LatLng(40.716948, -74.003563);
////    var options = {
////        zoom: 14, center: latlng,
////        mapTypeId: google.maps.MapTypeId.ROADMAP
////    };
////    var map = new google.maps.Map(document.getElementById("map"), options);
////}


function saveAsFile(filename, fileContent) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}

function downloadPdfTool(mimeType, base64String, fileName){
    var fileDataUrl = "data:" + mimeType + ";base64," + base64String;
    fetch(fileDataUrl)
        .then(response => response.blob())
        .then(blob => {
            var link = window.document.createElement("a");
            link.href = window.URL.createObjectURL(blob, { type: mimeType });
            link.download = fileName;

            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        });
}




//function downloadPdfTool(filename, fileContent) { //, fileContent) {
//    var link = document.createElement('a');
//    link.href = "data:application/pdf"; // + encodeURIComponent(fileContent);
//    link.download = filename; //filename;    
//    //link.dispatchEvent(new MouseEvent('click'));
//    document.body.appendChild(link);
//    link.click();
//    document.body.removeChild(link);
//}