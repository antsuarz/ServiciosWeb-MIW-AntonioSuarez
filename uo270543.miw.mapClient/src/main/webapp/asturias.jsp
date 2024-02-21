<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="java.util.List" %>
<%@ page import="com.miw.uniovi.model.ClientCargadorModel" %>
<jsp:useBean id="markers" scope="request" type="java.lang.String"/>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Puntos de Carga: Oviedo y Gijón</title>
    <link rel="stylesheet" href="https://unpkg.com/leaflet/dist/leaflet.css" />
    <link rel="stylesheet" href="estilos/asturias.css" />
</head>
<body>

<header>
    <h1>Puntos de Carga: Oviedo y Gijón</h1>
</header>

<nav>
    <!-- Agrega tus elementos de navegación aquí -->
    <a href="#">Atrás</a>
    <a href="${pageContext.request.contextPath}/oviedo">Oviedo</a>
    <a href="${pageContext.request.contextPath}/gijon">Gijón</a>
</nav>

<div id="map"></div>

<script src="https://unpkg.com/leaflet/dist/leaflet.js"></script>
<script>
    var asturias = L.map('map').setView([43.359833, -5.70], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '© OpenStreetMap contributors'
    }).addTo(asturias);

    var markers = ${markers};

    markers.forEach(function(marker) {
        L.marker(marker.coordinates)
            .addTo(asturias)
            .bindPopup("<b>" + marker.title + "</b>")
            .openPopup();
    });

    asturias.setView([43.409833, -5.73], 10);
</script>

<footer>
    <p>&copy; 2024 Puntos de Carga</p>
</footer>

</body>
</html>
