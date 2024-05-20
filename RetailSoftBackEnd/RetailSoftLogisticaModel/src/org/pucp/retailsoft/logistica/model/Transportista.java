package org.pucp.retailsoft.logistica.model;

public class Transportista {
    private int idTransportista;
    private String numBrevete;
    private String tipoBrevete;
    private byte[] brevete;
    private Vehiculo vehiculo;
    private boolean activo;

    public Transportista() {}
    
    public Transportista(String numBrevete, String tipoBrevete, byte[] brevete, Vehiculo vehiculo) {
        this.numBrevete = numBrevete;
        this.tipoBrevete = tipoBrevete;
        this.brevete = brevete;
        this.vehiculo = vehiculo;
        this.activo = true;
    }

    public int getIdTransportista() {
        return idTransportista;
    }

    public void setIdTransportista(int idTransportista) {
        this.idTransportista = idTransportista;
    }

    public String getNumBrevete() {
        return numBrevete;
    }

    public void setNumBrevete(String numBrevete) {
        this.numBrevete = numBrevete;
    }

    public String getTipoBrevete() {
        return tipoBrevete;
    }

    public void setTipoBrevete(String tipoBrevete) {
        this.tipoBrevete = tipoBrevete;
    }

    public byte[] getBrevete() {
        return brevete;
    }

    public void setBrevete(byte[] brevete) {
        this.brevete = brevete;
    }

    public Vehiculo getVehiculo() {
        return vehiculo;
    }

    public void setVehiculo(Vehiculo vehiculo) {
        this.vehiculo = vehiculo;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
