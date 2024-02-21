package com.miw.uniovi.mapservice.converter;

import com.miw.uniovi.model.ClientCargadorModel;

import java.util.List;

public class LeafletConverter {
    public static String convertToLeafletMarkersJson(List<ClientCargadorModel> cargadores) {
        StringBuilder jsonBuilder = new StringBuilder("[");

        for (int i = 0; i < cargadores.size(); i++) {
            ClientCargadorModel cargador = cargadores.get(i);

            // Construir el objeto JSON para cada cargador
            String markerJson = "{"
                    + "coordinates: [" + cargador.getCorX() + ","
                    + cargador.getCorY() + "],"
                    + "title: '" + cargador.getTitle() + "'}";

            jsonBuilder.append(markerJson);

            if (i < cargadores.size() - 1) {
                jsonBuilder.append(",");
            }
        }

        jsonBuilder.append("]");

        return jsonBuilder.toString();
    }

}
