package com.miw.uniovi.mapservice.services;

import com.miw.uniovi.mapservice.astservices.CargadorModel;
import com.miw.uniovi.mapservice.astservices.IApplicationServices;
import com.miw.uniovi.mapservice.astservices.IApplicationServices_Service;
import com.miw.uniovi.model.ClientCargadorModel;
import com.miw.uniovi.mapservice.converter.AsturiasConverter;

import java.util.ArrayList;
import java.util.List;

public class AsturiasWsService {
    public static List<ClientCargadorModel> getCargadores(){
        List<CargadorModel> modelList = conectionService();
        List<ClientCargadorModel> result = new ArrayList<>();
        for(CargadorModel c: modelList){
            result.add(AsturiasConverter.fromAsturiasModel(c));
        }
        return result;
    }

    private static List<CargadorModel> conectionService() {
        IApplicationServices_Service service = new IApplicationServices_Service();
        IApplicationServices asturias_service = service.getBasicHttpBindingIApplicationServices();
        List<CargadorModel> modelList = asturias_service.getCargadores().getCargadorModel();
        return modelList;
    }

    public static List<ClientCargadorModel> getCargadoresOviedo(){
        List<CargadorModel> modelList = conectionService();
        List<ClientCargadorModel> result = new ArrayList<>();
        for(CargadorModel c: modelList){
            ClientCargadorModel cargador = AsturiasConverter.fromAsturiasModel(c);
            if(cargador.getCorY()< -5.7) {
                result.add(AsturiasConverter.fromAsturiasModel(c));
            }
        }
        return result;
    }

    public static List<ClientCargadorModel> getCargadoresGijon(){
        List<CargadorModel> modelList = conectionService();
        List<ClientCargadorModel> result = new ArrayList<>();
        for(CargadorModel c: modelList){
            ClientCargadorModel cargador = AsturiasConverter.fromAsturiasModel(c);
            if(cargador.getCorY()> -5.7) {
                result.add(AsturiasConverter.fromAsturiasModel(c));
            }
        }
        return result;
    }
}
