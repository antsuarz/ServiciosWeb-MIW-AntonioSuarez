package com.miw.uniovi.mapservice.cylservices;

public class CyLModel {

    private String title;
    private String tipo;
    private  double cordX;
    private double cordY;

    private String provincia;

    public CyLModel() {
    }
    public CyLModel(String title, String tipo, double cordX, double cordy, String provincia) {
        this.title = title;
        this.tipo = tipo;
        this.cordX = cordX;
        this.cordY = cordy;
        this.provincia = provincia;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public double getCordX() {
        return cordX;
    }

    public void setCordX(double cordX) {
        this.cordX = cordX;
    }

    public double getCordY() {
        return cordY;
    }

    public void setCordY(double cordY) {
        this.cordY = cordY;
    }

    public String getProvincia() {
        return provincia;
    }

    public void setProvincia(String provincia) {
        this.provincia = provincia;
    }
}
