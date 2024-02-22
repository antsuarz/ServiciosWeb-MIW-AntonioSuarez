<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="java.util.List" %>
<%@ page import="com.miw.uniovi.model.ClientCargadorModel" %>
<jsp:useBean id="markers" scope="request" type="java.lang.String"/>
<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Puntos de Carga: Gijón</title>
  <link rel="stylesheet" href="https://unpkg.com/leaflet/dist/leaflet.css" />
  <link rel="stylesheet" href="estilos/style.css" />
</head>
<body>

<header>
  <h1>Puntos de Carga: Gijón</h1>
</header>

<nav>
  <a href="${pageContext.request.contextPath}/">Inicio</a>
  <a href="${pageContext.request.contextPath}/oviedo">Oviedo</a>
  <a href="${pageContext.request.contextPath}/asturias">Asturias</a>

</nav>

<div id="map"></div>

<script src="https://unpkg.com/leaflet/dist/leaflet.js"></script>
<script>
  var gijon = L.map('map').setView([43.359833, -5.852479], 13);

  L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '© OpenStreetMap contributors'
  }).addTo(gijon);

  var markers = ${markers};

  markers.forEach(function(marker) {
    L.marker(marker.coordinates)
            .addTo(gijon)
            .bindPopup("<b>" + marker.title + "</b>")
            .openPopup();
  });

  gijon.setView([43.537385, -5.660194], 12);
</script>

<footer>
  <p>Master en Ingeniería Web - Servicios Web 2024</p>
  <p>Antonio Suárez Crespo - UO270543</p>
</footer>

</body>
</html>
