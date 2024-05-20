package org.pucp.retailsoft.ventas.model;

public class Boleta extends DocumentoVenta {
    private int idBoleta;
    private boolean activo;

    public Boleta(){}
    
    public int getIdBoleta() {
        return idBoleta;
    }

    public void setIdBoleta(int idBoleta) {
        this.idBoleta = idBoleta;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
    
}
