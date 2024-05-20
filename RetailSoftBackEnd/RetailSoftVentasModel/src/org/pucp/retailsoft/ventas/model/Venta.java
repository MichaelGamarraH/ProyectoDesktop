package org.pucp.retailsoft.ventas.model;
import org.pucp.retailsoft.rrhh.model.Colaborador;
import java.util.ArrayList;
import java.util.Date;

public class Venta {
    private int idVenta;
    private double montoTotal;
    private Date fechaVenta;
    private boolean activo;
    private Colaborador promotor;
    private Cliente cliente;
    private ArrayList<LineaVenta> lineasVenta;
    
    public Venta(){}
    
    public int getIdVenta() {
        return idVenta;
    }

    public void setIdVenta(int idVenta) {
        this.idVenta = idVenta;
    }

    public double getMontoTotal() {
        return montoTotal;
    }

    public void setMontoTotal(double montoTotal) {
        this.montoTotal = montoTotal;
    }
    
    public Date getFechaVenta() {
        return fechaVenta;
    }

    public void setFechaVenta(Date fechaVenta) {
        this.fechaVenta = fechaVenta;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public Colaborador getPromotor() {
        return promotor;
    }

    public void setPromotor(Colaborador promotor) {
        this.promotor = promotor;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public ArrayList<LineaVenta> getLineasVenta() {
        return lineasVenta;
    }

    public void setLineasVenta(ArrayList<LineaVenta> lineasVenta) {
        this.lineasVenta = lineasVenta;
    }
    
    
    
}
