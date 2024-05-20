package org.pucp.retailsoft.rrhh.model;

import java.util.Date;

public class BeneficioxColaborador {
    private int idBeneficioxColaborador;
    private Colaborador colaborador;
    private Beneficio beneficio;
    private Date fechaRegistro;
    private boolean activo;

    public BeneficioxColaborador() {
    }

    public Beneficio getBeneficio() {
        return beneficio;
    }

    public void setBeneficio(Beneficio beneficio) {
        this.beneficio = beneficio;
    }

    public int getIdBeneficioxColaborador() {
        return idBeneficioxColaborador;
    }

    public void setIdBeneficioxColaborador(int idBeneficioxColaborador) {
        this.idBeneficioxColaborador = idBeneficioxColaborador;
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
