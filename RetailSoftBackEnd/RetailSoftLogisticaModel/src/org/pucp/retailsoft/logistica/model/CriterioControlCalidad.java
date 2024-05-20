package org.pucp.retailsoft.logistica.model;

public class CriterioControlCalidad {
    private int idCriterioControlCalidad;
    private String nombre;
    private String descripcion;
    private boolean activo;

    public CriterioControlCalidad() {}

    public CriterioControlCalidad(String nombre, String descripcion) {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.activo = true;
    }

    public int getIdCriterioControlCalidad() {
        return idCriterioControlCalidad;
    }

    public void setIdCriterioControlCalidad(int idCriterioControlCalidad) {
        this.idCriterioControlCalidad = idCriterioControlCalidad;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}
