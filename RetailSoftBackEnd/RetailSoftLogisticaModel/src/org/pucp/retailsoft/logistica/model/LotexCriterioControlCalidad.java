package org.pucp.retailsoft.logistica.model;

import java.util.Date;

public class LotexCriterioControlCalidad {
    private int idLotexCriterioControlCalidad;
    private boolean resultado;
    private Date fechaInspeccion;
    private String observacion;
    private CriterioControlCalidad criterioControlCalidad;
    private boolean activo;
    
    public LotexCriterioControlCalidad() {}

    public LotexCriterioControlCalidad(boolean resultado, Date fechaInspeccion, String observacion, CriterioControlCalidad criterioControlCalidad) {
        this.resultado = resultado;
        this.fechaInspeccion = fechaInspeccion;
        this.observacion = observacion;
        this.criterioControlCalidad = criterioControlCalidad;
        this.activo = true;
    }

    public int getIdLotexCriterioControlCalidad() {
        return idLotexCriterioControlCalidad;
    }

    public void setIdLotexCriterioControlCalidad(int idLotexCriterioControlCalidad) {
        this.idLotexCriterioControlCalidad = idLotexCriterioControlCalidad;
    }

    public boolean isResultado() {
        return resultado;
    }

    public void setResultado(boolean resultado) {
        this.resultado = resultado;
    }

    public Date getFechaInspeccion() {
        return fechaInspeccion;
    }

    public void setFechaInspeccion(Date fechaInspeccion) {
        this.fechaInspeccion = fechaInspeccion;
    }

    public String getObservacion() {
        return observacion;
    }

    public void setObservacion(String observacion) {
        this.observacion = observacion;
    }

    public CriterioControlCalidad getCriterioControlCalidad() {
        return criterioControlCalidad;
    }

    public void setCriterioControlCalidad(CriterioControlCalidad criterioControlCalidad) {
        this.criterioControlCalidad = criterioControlCalidad;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

}
