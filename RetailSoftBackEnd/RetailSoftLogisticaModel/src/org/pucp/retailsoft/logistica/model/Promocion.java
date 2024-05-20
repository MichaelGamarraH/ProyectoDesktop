package org.pucp.retailsoft.logistica.model;

import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;
import org.pucp.retailsoft.logistica.model.Producto;

public class Promocion {
    private int idPromocion;
    private String nombre;
    private double descuento; 
    private double precioPromocion;
    private String descripcion;
    private Date fechaInicio;
    private Date fechaFin;    
    private boolean activo;
    private CategoriaProducto categoriaProducto;
//    private ArrayList<LineaVenta> lineasVenta;
    private ArrayList<ProductoxPromocion> productosXpromocion;

    public ArrayList<ProductoxPromocion> getProductosXpromocion() {
        return productosXpromocion;
    }

    public void setProductosXpromocion(ArrayList<ProductoxPromocion> productosXpromocion) {
        this.productosXpromocion = productosXpromocion;
    }
    private byte[] imagen;

    public int getIdPromocion() {
        return idPromocion;
    }

    public void setIdPromocion(int idPromocion) {
        this.idPromocion = idPromocion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getDescuento() {
        return descuento;
    }

    public void setDescuento(double descuento) {
        this.descuento = descuento;
    }

    public double getPrecioPromocion() {
        return precioPromocion;
    }

    public void setPrecioPromocion(double precioPromocion) {
        this.precioPromocion = precioPromocion;
    }

    public CategoriaProducto getCategoriaProducto() {
        return categoriaProducto;
    }

    public void setCategoriaProducto(CategoriaProducto categoriaProducto) {
        this.categoriaProducto = categoriaProducto;
    }
    
    

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }


    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }
    
    
     
}
