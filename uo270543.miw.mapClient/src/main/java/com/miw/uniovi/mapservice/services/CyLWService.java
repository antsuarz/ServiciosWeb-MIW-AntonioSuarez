package com.miw.uniovi.mapservice.services;

import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.miw.uniovi.mapservice.converter.ClyConverter;
import com.miw.uniovi.mapservice.cylservices.CyLModel;
import com.miw.uniovi.model.ClientCargadorModel;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.HttpClients;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class CyLWService {
    private static StringBuilder getConnectionAndResponse() throws IOException {
        HttpClient httpClient = HttpClients.createDefault();
        HttpGet request = new HttpGet("http://localhost:5000/api/cargador");
        HttpResponse response = httpClient.execute(request);
        BufferedReader reader = new BufferedReader(new InputStreamReader(response.getEntity().getContent()));
        StringBuilder jsonString = new StringBuilder();
        String line;
        while ((line = reader.readLine()) != null) {
            jsonString.append(line);
        }
        return jsonString;
    }
    public static List<ClientCargadorModel> getCargadores(String provincia) throws IOException {
        StringBuilder jsonString = getConnectionAndResponse();
        ObjectMapper objectMapper = new ObjectMapper();
        JsonNode jsonNode = objectMapper.readTree(jsonString.toString());

        List<ClientCargadorModel> clientList = new ArrayList<>();
        for (JsonNode childNode : jsonNode) {
            CyLModel cyLModel = objectMapper.convertValue(childNode, CyLModel.class);
            ClientCargadorModel cargadorModel = ClyConverter.fromClyModel(cyLModel);
            if(!provincia.isBlank()){
                if(provincia.toLowerCase().equals(cargadorModel.provincia.toLowerCase())){
                    clientList.add(cargadorModel);
                }
            }
            else{
                clientList.add(cargadorModel);
            }
        }
        return clientList;
    }


}
