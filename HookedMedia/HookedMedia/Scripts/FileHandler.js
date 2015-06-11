function Upload() {
    var fileUpload = document.getElementById("testId");
    var regex = /^([a-zA-Z0-9\s_\\.\-:])+(.csv|.txt)$/;
    if (regex.test(fileUpload.value.toLowerCase())) {
        if (typeof (FileReader) != "undefined") {
            var reader = new FileReader();
            reader.onload = function (e) {
                document.getElementById("white1").value = e.target.result;
            }
            reader.readAsText(fileUpload.files[0]);
        } else {
            alert("This browser does not support HTML5. Please upgrade or copy paste your CSV file into text box");
        }
    } else {
        alert("Please upload a valid CSV file.");
    }
}