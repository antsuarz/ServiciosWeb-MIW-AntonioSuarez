<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Botones enlaces</title>
    <link rel="stylesheet" href="estilos/style.css" />
    <style>
        header{
            margin-bottom: 1rem;
        }
        div {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin: 0;
        }

        .button-link {
            display: block;
            width: 15rem;
            padding: 1rem;
            text-align: center;
            text-decoration: none;
            font-size: 16px;
            margin: 0.5rem;
            cursor: pointer;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #f0f0f0;
            color: #333;
        }
    </style>
</head>

<body>
<header>
    <h1>Mapa de Puntos de Carga</h1>
    <h2>Master Universitario en Ingeniería Web</h2>
</header>
<div>
    <a href="${pageContext.request.contextPath}/asturias" class="button-link">Asturias</a>
    <a href="pagina2.jsp" class="button-link">Castilla y León</a>
</div>

<footer>
    <p>Master en Ingeniería Web - Servicios Web 2024</p>
    <p>Antonio Suárez Crespo - UO270543</p>
</footer>
</body>
</html>
