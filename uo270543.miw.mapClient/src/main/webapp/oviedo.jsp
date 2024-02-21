<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="java.util.List" %>
<%@ page import="com.miw.uniovi.model.ClientCargadorModel" %>
<jsp:useBean id="markers" scope="request" type="java.lang.String"/>
<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Puntos de Carga: Oviedo</title>
  <link rel="stylesheet" href="https://unpkg.com/leaflet/dist/leaflet.css" />
  <style>
    body {
      margin: 0;
      padding: 0;
      font-family: 'Arial', sans-serif;
      background-color: lightblue;
    }

    header {
      background-color: #333;
      color: white;
      text-align: center;
      padding: 1em;
    }

    nav {
      background-color: #333;
      color: white;
      padding: 1em;
      text-align: center;
      margin-bottom: 1rem;
    }

    #map {
      height: 60vh;
      width: 80vw;
      margin: 0 auto;
      display: block;
    }

    footer {
      background-color: #333;
      color: white;
      text-align: center;
      padding: 1em;
      position: fixed;
      bottom: 0;
      width: 100%;
    }
  </style>
</head>
<body>

<header>
  <h1>Puntos de Carga: Oviedo</h1>
</header>

<nav>
  <a href="#">Inicio</a>
  <a href="${pageContext.request.contextPath}/asturias">Asturias</a>
  <a href="${pageContext.request.contextPath}/gijon">Gijón</a>
</nav>

<div id="map"></div>

<script src="https://unpkg.com/leaflet/dist/leaflet.js"></script>
<script>
  var oviedo = L.map('map').setView([43.359833, -5.852479], 13);

  L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '© OpenStreetMap contributors'
  }).addTo(oviedo);

  var markers = ${markers};

  markers.forEach(function(marker) {
    L.marker(marker.coordinates)
            .addTo(oviedo)
            .bindPopup("<b>" + marker.title + "</b>")
            .openPopup();
  });

  oviedo.setView([43.359833, -5.852479], 12);
</script>

<footer>
  <p>&copy; 2024 Puntos de Carga</p>
</footer>

</body>
</html>
