package com.miw.uniovi.model;

public class ClientCargadorModel {

    public String title;

    public double corX;

    public double corY;

    public String tipo;

    public String provincia;


    public ClientCargadorModel(String title, double corX, double corY, String tipo) {
        this.title = title;
        this.corX = corX;
        this.corY = corY;
        this.tipo = tipo;
        this.provincia = "Asturias";
    }

    public ClientCargadorModel(String title, double corX, double corY, String tipo, String provincia) {
        this.title = title;
        this.corX = corX;
        this.corY = corY;
        this.tipo = tipo;
        this.provincia = provincia;
    }
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public double getCorX() {
        return corX;
    }

    public void setCorX(double corX) {
        this.corX = corX;
    }

    public double getCorY() {
        return corY;
    }

    public void setCorY(double corY) {
        this.corY = corY;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getProvincia() {
        return provincia;
    }

    public void setProvincia(String provincia) {
        this.provincia = provincia;
    }
}
