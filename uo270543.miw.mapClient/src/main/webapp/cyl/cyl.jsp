
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="java.util.List" %>
<%@ page import="com.miw.uniovi.model.ClientCargadorModel" %>
<jsp:useBean id="markers" scope="request" type="java.lang.String"/>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Puntos de Carga: Castilla y León</title>
    <link rel="stylesheet" href="https://unpkg.com/leaflet/dist/leaflet.css" />
    <link rel="stylesheet" href="estilos/style.css" />
</head>
<body>

<header>
    <h1>Puntos de Carga: Castilla Y León</h1>
</header>

<nav>
    <a href="${pageContext.request.contextPath}/">Inicio</a>
    <a href="${pageContext.request.contextPath}/cyl/leon">León</a>
    <a href="${pageContext.request.contextPath}/cyl/zam">Zamora</a>
    <a href="${pageContext.request.contextPath}/cyl/sal">Salamanca</a>
    <a href="${pageContext.request.contextPath}/cyl/pal">Palencia</a>
    <a href="${pageContext.request.contextPath}/cyl/bur">Burgos</a>
    <a href="${pageContext.request.contextPath}/cyl/vall">Valladolid</a>
    <a href="${pageContext.request.contextPath}/cyl/sor">Soria</a>
    <a href="${pageContext.request.contextPath}/cyl/sego">Segovia</a>
    <a href="${pageContext.request.contextPath}/cyl/avi">Ávila</a>
</nav>

<div id="map"></div>
<p style="text-align: center; color: gray; font-style: italic">Consumiento la API de Castilla y León a través de un servicio REST propio</p>
<script src="https://unpkg.com/leaflet/dist/leaflet.js"></script>
<script>
    var cyl = L.map('map').setView([43.359833, -5.70], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '© OpenStreetMap contributors'
    }).addTo(cyl);

    var markers = ${markers};

    markers.forEach(function(marker) {
        L.marker(marker.coordinates)
            .addTo(cyl)
            .bindPopup("<b>" + marker.title + "</b>")
            .openPopup();
    });

    var x = ${x};
    var y = ${y};
    var pos = ${distance};
    cyl.setView([x,y], pos);
</script>

<footer>
    <p>Master en Ingeniería Web - Servicios Web 2024</p>
    <p>Antonio Suárez Crespo - UO270543</p>
</footer>

</body>
</html>
