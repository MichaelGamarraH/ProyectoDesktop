package org.pucp.retailsoft.logistica.model;

public class CategoriaProducto {
    private int idCategoriaProducto;
    private String nombre;
    private byte[] icono;
    private boolean activo;

    public CategoriaProducto() {}

    public CategoriaProducto(String nombre, byte[] icono) {
        this.nombre = nombre;
        this.icono = icono;
        this.activo = true;
    }

    public int getIdCategoriaProducto() {
        return idCategoriaProducto;
    }

    public void setIdCategoriaProducto(int idCategoriaProducto) {
        this.idCategoriaProducto = idCategoriaProducto;
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
