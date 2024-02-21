package com.miw.uniovi.mapservice.converter;
import com.miw.uniovi.mapservice.astservices.CargadorModel;
import com.miw.uniovi.model.ClientCargadorModel;

public class AsturiasConverter {

     public static ClientCargadorModel fromAsturiasModel(CargadorModel asturiasModel){
         String title = asturiasModel.getTitle().getValue();
         String tipo = asturiasModel.getTipo().getValue();
         double cordX = Double.parseDouble(asturiasModel.getCordX().getValue());
         double cordY = Double.parseDouble(asturiasModel.getCordY().getValue());
         return new ClientCargadorModel(title,cordX,cordY,tipo);
     }
}
