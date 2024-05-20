package org.pucp.retailsoft.rrhh.model;

public class EstadoCandidato {
    private int idEstadoCandidato;
    private String nombre;
    private boolean activo;

    public EstadoCandidato() {
    }

    public EstadoCandidato(String nombre) {
        this.nombre = nombre;
        this.activo = true;
    }

    public int getIdEstadoCandidato() {
        return idEstadoCandidato;
    }

    public void setIdEstadoCandidato(int idEstadoCandidato) {
        this.idEstadoCandidato = idEstadoCandidato;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
