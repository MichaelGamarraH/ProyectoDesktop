package org.pucp.retailsoft.logistica.model;

public class MarcaProducto {
    private int idMarcaProducto;
    private String nombre;
    private byte[] icono;
    private boolean activo;

    public MarcaProducto() {}

    public MarcaProducto(String nombre, byte[] icono) {
        this.nombre = nombre;
        this.icono = icono;
        this.activo = true;
    }

    public int getIdMarcaProducto() {
        return idMarcaProducto;
    }

    public void setIdMarcaProducto(int idMarcaProducto) {
        this.idMarcaProducto = idMarcaProducto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public byte[] getIcono() {
        return icono;
    }

    public void setIcono(byte[] icono) {
        this.icono = icono;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
