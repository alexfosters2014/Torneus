

window.ObtenerAnchoPantalla = () => {
    return window.innerWidth;
};

function getIdTokenFromFragment() {
    var fragment = window.location.hash.substr(1);
    var params = new URLSearchParams(fragment);
    var idToken = params.get("id_token");
    return idToken;
}

function obtenerNumero() {
    return "num 5";
}

