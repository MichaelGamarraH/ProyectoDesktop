package org.pucp.retailsoft.rrhh.model;

public class Cargo{
    private int idCargo;
    private String tipoCargo;
    private boolean activo;
    
    public Cargo(){};
    
    public Cargo(String tipoCargo) {
        this.tipoCargo = tipoCargo;
        this.activo = true;
    }

    public int getIdCargo() {
        return idCargo;
    }

    public void setIdCargo(int idCargo) {
        this.idCargo = idCargo;
    }

    public String getTipoCargo() {
        return tipoCargo;
    }

    public void setTipoCargo(String tipoCargo) {
        this.tipoCargo = tipoCargo;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}
