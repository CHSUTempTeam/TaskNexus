function HttpRequest(URL, Func, json) {
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (xhr.readyState === XMLHttpRequest.DONE) {
            if (xhr.readyState === 4 && xhr.status === 200) {
                if (xhr.responseText == "error_by_connection" || xhr.responseText == "error_by_link" || xhr.responseText == "error_by_other" || xhr.responseText == "LongRequest" || xhr.responseText == "close_game") quit(xhr.responseText)
                else Func(JSON.parse(xhr.responseText))
            } else {
                console.error('ERROR BY "' + URL + '":' + xhr.responseText);
                return ''
            }
        }
    };

    xhr.open('POST', "http://localhost:5275/" + URL, true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(json));
}


function login() {
    var t1 = document.getElementById("login-input").value
    var t2 = document.getElementById("password-input").value

    let json = {
        login: document.getElementById("login-input").value,
        password: document.getElementById("password-input").value
    }

    if (t1 != "" && t2 != "") {
        HttpRequest('GetLogin', function (request) {
            
            if (request.answer == "True") {
                alert("asd")
            }
        }, json)
    }

}