package org.pucp.retailsoft.rrhh.model;

import java.util.Date;

public class DeduccionxColaborador {
    private int idDeduccionxColaborador;
    private Colaborador colaborador;
    private Deduccion deduccion;
    private Date fechaRegistro;
    private boolean activo;

    public DeduccionxColaborador() {
    }

    public Deduccion getDeduccion() {
        return deduccion;
    }

    public void setDeduccion(Deduccion deduccion) {
        this.deduccion = deduccion;
    }

    public DeduccionxColaborador(Colaborador colaborador, Date fechaRegistro) {
        this.colaborador = colaborador;
        this.fechaRegistro = fechaRegistro;
        this.activo = true;
    }

    public int getIdDeduccionxColaborador() {
        return idDeduccionxColaborador;
    }

    public void setIdDeduccionxColaborador(int idDeduccionxColaborador) {
        this.idDeduccionxColaborador = idDeduccionxColaborador;
    }

    public Colaborador getColaborador() {
        return colaborador;
    }

    public void setColaborador(Colaborador colaborador) {
        this.colaborador = colaborador;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
