package org.pucp.retailsoft.rrhh.model;
import java.util.Date;

public class TrazabilidadCandidato {
    private int idTrazabilidadCandidato;
    private Candidato candidato;
    private EstadoCandidato estadoCandidato;
    private Date fecha;
    private String observacion;

    public TrazabilidadCandidato() {
    }
    
    public Candidato getCandidato() {
        return candidato;
    }

    public void setCandidato(Candidato candidato) {
        this.candidato = candidato;
    }

    public EstadoCandidato getEstadoCandidato() {
        return estadoCandidato;
    }

    public void setEstadoCandidato(EstadoCandidato estadoCandidato) {
        this.estadoCandidato = estadoCandidato;
    }

    
    public int getIdTrazabilidadCandidato() {
        return idTrazabilidadCandidato;
    }

    public void setIdTrazabilidadCandidato(int idTrazabilidadCandidato) {
        this.idTrazabilidadCandidato = idTrazabilidadCandidato;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public String getObservacion() {
        return observacion;
    }

    public void setObservacion(String observacion) {
        this.observacion = observacion;
    }
}