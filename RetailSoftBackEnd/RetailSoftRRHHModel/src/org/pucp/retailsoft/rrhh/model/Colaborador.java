package org.pucp.retailsoft.rrhh.model;
//import org.pucp.retailsoft.ventas.model.Pedido;
import java.sql.Time;
import java.util.ArrayList;

public class Colaborador extends Persona {
    private int idColaborador;
    private Cargo cargo;
    private Time horaIngreso;
    private Time horaSalida;
    private ArrayList<Beneficio> beneficios;
    private byte[] imagen;
    private String usuario;
    private String contrasenha;
    private boolean activo;
    
    public Colaborador(){}

    public ArrayList<Beneficio> getBeneficios() {
        return beneficios;
    }

    public void setBeneficios(ArrayList<Beneficio> beneficios) {
        this.beneficios = beneficios;
    }

    public int getIdColaborador() {
        return idColaborador;
    }

    public void setIdColaborador(int idColaborador) {
        this.idColaborador = idColaborador;
    }

    public Cargo getCargo() {
        return cargo;
    }

    public void setCargo(Cargo cargo) {
        this.cargo = cargo;
    }

    public Time getHoraIngreso() {
        return horaIngreso;
    }

    public void setHoraIngreso(Time horaIngreso) {
        this.horaIngreso = horaIngreso;
    }

    public Time getHoraSalida() {
        return horaSalida;
    }

    public void setHoraSalida(Time horaSalida) {
        this.horaSalida = horaSalida;
    }

    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getContrasenha() {
        return contrasenha;
    }

    public void setContrasenha(String contrasenha) {
        this.contrasenha = contrasenha;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
}
