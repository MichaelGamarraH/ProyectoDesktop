package org.pucp.retailsoft.rrhh.model;

import java.util.Date;

public class BeneficioxPuesto {
    private int idBeneficioPuesto;
    private PuestoTrabajo puestoTrabajo;
    private Beneficio beneficio;
    private Date fechaRegistro;
    private boolean activo;

    public BeneficioxPuesto() {
    }

    public Beneficio getBeneficio() {
        return beneficio;
    }

    public void setBeneficio(Beneficio beneficio) {
        this.beneficio = beneficio;
    }

    public BeneficioxPuesto(PuestoTrabajo puestoTrabajo, Date fechaRegistro) {
        this.puestoTrabajo = puestoTrabajo;
        this.fechaRegistro = fechaRegistro;
        this.activo = true;
    }

    public int getIdBeneficioPuesto() {
        return idBeneficioPuesto;
    }

    public void setIdBeneficioPuesto(int idBeneficioPuesto) {
        this.idBeneficioPuesto = idBeneficioPuesto;
    }

    public PuestoTrabajo getPuestoTrabajo() {
        return puestoTrabajo;
    }

    public void setPuestoTrabajo(PuestoTrabajo puestoTrabajo) {
        this.puestoTrabajo = puestoTrabajo;
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
