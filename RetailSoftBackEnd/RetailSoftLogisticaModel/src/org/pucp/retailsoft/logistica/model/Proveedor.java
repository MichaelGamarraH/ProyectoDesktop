package org.pucp.retailsoft.logistica.model;

import java.util.Date;

public class Proveedor {
  
    private int idProveedor;
    private String razonSocial;
    private String representante;
    private String RUC;
    private String direccion;
    private String telefono;
    private String correo;
    private String sitioWeb;
    private CategoriaProducto categoriaProducto;
    private Date fechaInicio;
    private String notaProveedor;
    private boolean activo;
    
    public Proveedor() {
    }
    
    public Proveedor(String razonSocial, String representante, String RUC, String direccion, String telefono, String correo, String sitioWeb, CategoriaProducto categoriaProducto, Date fechaInicio, String notaProveedor, boolean activo) {
        this.razonSocial = razonSocial;
        this.representante = representante;
        this.RUC = RUC;
        this.direccion = direccion;
        this.telefono = telefono;
        this.correo = correo;
        this.sitioWeb = sitioWeb;
        this.categoriaProducto = categoriaProducto;
        this.fechaInicio = fechaInicio;
        this.notaProveedor = notaProveedor;
        this.activo = activo;
    }    
    
    public int getIdProveedor() {
        return idProveedor;
    }

    public void setIdProveedor(int idProveedor) {
        this.idProveedor = idProveedor;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }

    public String getRepresentante() {
        return representante;
    }

    public void setRepresentante(String representante) {
        this.representante = representante;
    }

    public String getRUC() {
        return RUC;
    }

    public void setRUC(String RUC) {
        this.RUC = RUC;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getSitioWeb() {
        return sitioWeb;
    }

    public void setSitioWeb(String sitioWeb) {
        this.sitioWeb = sitioWeb;
    }

    public CategoriaProducto getCategoriaProducto() {
        return categoriaProducto;
    }

    public void setCategoriaProducto(CategoriaProducto categoriaProducto) {
        this.categoriaProducto = categoriaProducto;
    }

    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public String getNotaProveedor() {
        return notaProveedor;
    }

    public void setNotaProveedor(String notaProveedor) {
        this.notaProveedor = notaProveedor;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

}