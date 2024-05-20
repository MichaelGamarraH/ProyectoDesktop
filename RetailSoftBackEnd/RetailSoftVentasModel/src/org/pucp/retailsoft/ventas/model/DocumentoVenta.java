package org.pucp.retailsoft.ventas.model;

import java.util.Date;

abstract public class DocumentoVenta {
    private int idDocumentoVenta;
    private String numDocumento;
    private Date fechaEmision; 
    private Cliente cliente; 
    private Venta venta; 

    public DocumentoVenta(){}
    
    public int getIdDocumentoVenta() {
        return idDocumentoVenta;
    }

    public void setIdDocumentoVenta(int idDocumentoVenta) {
        this.idDocumentoVenta = idDocumentoVenta;
    }

    public String getNumDocumento() {
        return numDocumento;
    }

    public void setNumDocumento(String numDocumento) {
        this.numDocumento = numDocumento;
    }

    public Date getFechaEmision() {
        return fechaEmision;
    }

    public void setFechaEmision(Date fechaEmision) {
        this.fechaEmision = fechaEmision;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Venta getVenta() {
        return venta;
    }

    public void setVenta(Venta venta) {
        this.venta = venta;
    }

    
    
    
}
