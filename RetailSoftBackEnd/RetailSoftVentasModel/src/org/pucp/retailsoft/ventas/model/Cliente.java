package org.pucp.retailsoft.ventas.model;
import java.util.ArrayList;

public class Cliente {
    private int idCliente;
    private String nombre;
    private String documentoIdentidad;
    private int cantidadPedidos;
    private TipoCliente tipoCliente;
    private ArrayList<DocumentoVenta> documentosVenta;

    public Cliente(){}
    

    public int getIdCliente() {
        return idCliente;
    }

    public void setIdCliente(int idCliente) {
        this.idCliente = idCliente;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDocumentoIdentidad() {
        return documentoIdentidad;
    }

    public void setDocumentoIdentidad(String documentoIdentidad) {
        this.documentoIdentidad = documentoIdentidad;
    }

    

    public int getCantidadPedidos() {
        return cantidadPedidos;
    }

    public void setCantidadPedidos(int cantidadPedidos) {
        this.cantidadPedidos = cantidadPedidos;
    }

    public TipoCliente getTipoCliente() {
        return tipoCliente;
    }

    public void setTipoCliente(TipoCliente tipoCliente) {
        this.tipoCliente = tipoCliente;
    }

    public ArrayList<DocumentoVenta> getDocumentosVenta() {
        return documentosVenta;
    }

    public void setDocumentosVenta(ArrayList<DocumentoVenta> documentosVenta) {
        this.documentosVenta = documentosVenta;
    }
    
    
    
}
