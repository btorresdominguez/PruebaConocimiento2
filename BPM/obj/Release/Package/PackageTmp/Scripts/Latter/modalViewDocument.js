function viewDocumentInModal(IdDocument,IsTemplate) {

    if (document.getElementById("DocumentPush")) {
        document.getElementById("DocumentPush").remove();
        document.getElementById("DocumentModal").remove();
    }
    
    var modal = '<button class="btn btn-primary" id="DocumentPush" data-toggle="modal" data-target="#DocumentModal">View Fullscreen Modal</button>' +
        '<div id="DocumentModal" class="modal animated bounceIn modal-fullscreen-md-down" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">' +
        '<div class="modal-dialog">' +
        '<div class="modal-content">' +
        '<div class="modal-body">' +
        '<iframe src="https://docs.google.com/document/d/' + IdDocument + '/edit?usp=sharing/pubhtml?widget=false&amp;chrome=false&amp;headers=false" style="height: 84vh !important;" width="100%"></iframe>' +
        '</div>' +
        '<div class="modal-footer">' +
        '<button class="btn btn-primary" data-dismiss="modal">Cerrar</button>' +
        '</div>' +
        '</div>' +
        '</div>' +
        '</div>';

    var baseUrl = window.location.origin;
    var prefix = window.location.pathname.split('/');

    if (prefix[1] === 'BPM2')
        baseUrl += '/BPM2';
    baseUrl += "/api/LattersApi/PremisionsDocuments?IdDocument=" + IdDocument +'&IsTemplate='+IsTemplate;
    
    $.get(baseUrl, function (data) {
        var newDiv = document.createElement("div");
        newDiv.innerHTML = modal;
        var currentDiv = document.getElementById("div1");
        document.body.insertBefore(newDiv, currentDiv);
        document.getElementById("DocumentPush").click();
    });
}

function ChargeDownLoadDocx(IdDocument) {
    var baseUrl = window.location.origin;
    var prefix = window.location.pathname.split('/');

    if (prefix[1] === 'BPM2')
        baseUrl += '/BPM2';
    baseUrl += "/api/LattersApi/GetDocumentDocx?IdDocument=" + IdDocument;
    $.get(baseUrl, function (data) {
        downloadFiles(data.nameFile, 'data:' + data.mimetype + ';base64,' + data.fileBase64);
    });
}

function downloadFiles(filename, text) {
    var element = document.createElement('a');
    element.setAttribute('href', text);
    element.setAttribute('download', filename);
    element.style.display = 'none';
    document.body.appendChild(element);
    element.click();
    document.body.removeChild(element);
}
