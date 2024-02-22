package com.miw.uniovi.mapservice.converter;

import com.miw.uniovi.mapservice.astservices.CargadorModel;
import com.miw.uniovi.mapservice.cylservices.CyLModel;
import com.miw.uniovi.model.ClientCargadorModel;

public class ClyConverter {

    public static ClientCargadorModel fromClyModel(CyLModel cyLModel){
        String title = cyLModel.getTitle();
        String tipo = cyLModel.getTipo();
        double cordX = cyLModel.getCordX();
        double cordY = cyLModel.getCordY();
        String provincia = cyLModel.getProvincia();
        return new ClientCargadorModel(title,cordX,cordY,tipo, provincia);
    }
}
