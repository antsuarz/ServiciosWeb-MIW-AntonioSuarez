package com.miw.uniovi.client.cyl;

import com.miw.uniovi.mapservice.converter.LeafletConverter;
import com.miw.uniovi.model.ClientCargadorModel;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;
import java.util.List;

import static com.miw.uniovi.mapservice.services.CyLWService.getCargadores;

@WebServlet("/cyl")
public class CyLServlet extends HttpServlet {

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        List<ClientCargadorModel> cargadores = getCargadores("");
        request.setAttribute("markers", LeafletConverter.convertToLeafletMarkersJson(cargadores));
        request.setAttribute("x",41.623455);
        request.setAttribute("y",-4.750183);
        request.setAttribute("distance", 7);
        request.getRequestDispatcher("/cyl/cyl.jsp").forward(request, response);
    }

}
