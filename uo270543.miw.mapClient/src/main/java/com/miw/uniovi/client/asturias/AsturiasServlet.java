package com.miw.uniovi.client.asturias;

import com.miw.uniovi.mapservice.converter.LeafletConverter;
import com.miw.uniovi.model.ClientCargadorModel;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;
import java.util.List;

import static com.miw.uniovi.mapservice.services.AsturiasWService.getCargadores;

@WebServlet("/asturias")
public class AsturiasServlet extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        List<ClientCargadorModel> cargadores = getCargadores();
        request.setAttribute("markers", LeafletConverter.convertToLeafletMarkersJson(cargadores));
        request.getRequestDispatcher("/asturias.jsp").forward(request, response);
    }
}
