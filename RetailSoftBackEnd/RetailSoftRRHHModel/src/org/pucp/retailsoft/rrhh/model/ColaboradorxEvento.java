package org.pucp.retailsoft.rrhh.model;

public class ColaboradorxEvento {
    private int idColaboradorxEvento;
    private Colaborador colaborador;
    private Evento evento;
    private boolean asistencia;

    public ColaboradorxEvento() {
    }

    public Evento getEvento() {
        return evento;
    }

    public void setEvento(Evento evento) {
        this.evento = evento;
    }

    public int getIdColaboradorxEvento() {
        return idColaboradorxEvento;
    }

    public void setIdColaboradorxEvento(int idColaboradorxEvento) {
        this.idColaboradorxEvento = idColaboradorxEvento;
    }

    public Colaborador getColaborador() {
        return colaborador;
    }

    public void setColaborador(Colaborador colaborador) {
        this.colaborador = colaborador;
    }

    public boolean isAsistencia() {
        return asistencia;
    }

    public void setAsistencia(boolean asistencia) {
        this.asistencia = asistencia;
    }
    
    
}
