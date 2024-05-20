package org.pucp.retailsoft.logistica.model;

public class Vehiculo {
    private int idVehiculo;
    private String placa;
    private String descripcion;
    private byte[] SOAT;
    private Almacen almacen;
    private TipoVehiculo tipoVehiculo;
    private boolean activo;
    
    public Vehiculo(){}

    public Vehiculo(String placa, String descripcion, byte[] SOAT, Almacen almacen, TipoVehiculo tipoVehiculo) {
        this.placa = placa;
        this.descripcion = descripcion;
        this.SOAT = SOAT;
        this.almacen = almacen;
        this.tipoVehiculo = tipoVehiculo;
        this.activo = true;
    }

    public int getIdVehiculo() {
        return idVehiculo;
    }

    public void setIdVehiculo(int idVehiculo) {
        this.idVehiculo = idVehiculo;
    }

    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public byte[] getSOAT() {
        return SOAT;
    }

    public void setSOAT(byte[] SOAT) {
        this.SOAT = SOAT;
    }
    
    public Almacen getAlmacen() {
        return almacen;
    }

    public void setAlmacen(Almacen almacen) {
        this.almacen = almacen;
    }

    public TipoVehiculo getTipoVehiculo() {
        return tipoVehiculo;
    }

    public void setTipoVehiculo(TipoVehiculo tipoVehiculo) {
        this.tipoVehiculo = tipoVehiculo;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

}
