package org.pucp.retailsoft.logistica.model;
import java.util.ArrayList;
import java.util.Date;

public class Lote {
    private int idLote;
    private Date fechaCompra;
    private Date fechaLlegada;
    private double peso;
    private String observacion;
    private double costoTotal;
    private int estado;
    private Proveedor proveedor;
    private Almacen almacen;
    private Producto producto;
    private int cantidad;
    private double costoUnitario;
    private ArrayList<LotexCriterioControlCalidad> listaCriterios;
    private boolean activo;
    
    public Lote(){}

    public Lote(Date fechaCompra, Date fechaLlegada, double peso, String observacion, double costoTotal, int estado, Proveedor proveedor, Almacen almacen, Producto producto,int cantidad, double costoUnitario, ArrayList<LotexCriterioControlCalidad> listaCriterios) {
        this.fechaCompra = fechaCompra;
        this.fechaLlegada = fechaLlegada;
        this.peso = peso;
        this.observacion = observacion;
        this.costoTotal = costoTotal;
        this.estado = estado;
        this.proveedor = proveedor;
        this.almacen = almacen;
        this.producto = producto;
        this.cantidad = cantidad;
        this.costoUnitario = costoUnitario;
        this.listaCriterios = listaCriterios;
        this.activo = true;
    }
    
    public int getIdLote() {
        return idLote;
    }

    public void setIdLote(int idLote) {
        this.idLote = idLote;
    }

    public Date getFechaCompra() {
        return fechaCompra;
    }

    public void setFechaCompra(Date fechaCompra) {
        this.fechaCompra = fechaCompra;
    }

    public Date getFechaLlegada() {
        return fechaLlegada;
    }

    public void setFechaLlegada(Date fechaLlegada) {
        this.fechaLlegada = fechaLlegada;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public String getObservacion() {
        return observacion;
    }

    public void setObservacion(String observacion) {
        this.observacion = observacion;
    }

    public double getCostoTotal() {
        return costoTotal;
    }

    public void setCostoTotal(double costoTotal) {
        this.costoTotal = costoTotal;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public Proveedor getProveedor() {
        return proveedor;
    }

    public void setProveedor(Proveedor proveedor) {
        this.proveedor = proveedor;
    }

    public Almacen getAlmacen() {
        return almacen;
    }

    public void setAlmacen(Almacen almacen) {
        this.almacen = almacen;
    }

    public Producto getProducto() {
        return producto;
    }

    public void setProducto(Producto producto) {
        this.producto = producto;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public double getCostoUnitario() {
        return costoUnitario;
    }

    public void setCostoUnitario(double costoUnitario) {
        this.costoUnitario = costoUnitario;
    }

    public ArrayList<LotexCriterioControlCalidad> getListaCriterios() {
        return listaCriterios;
    }

    public void setListaCriterios(ArrayList<LotexCriterioControlCalidad> listaCriterios) {
        this.listaCriterios = listaCriterios;
    }
    
    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}
