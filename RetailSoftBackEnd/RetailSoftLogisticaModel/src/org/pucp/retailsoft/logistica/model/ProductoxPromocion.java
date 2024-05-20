package org.pucp.retailsoft.logistica.model;

import java.util.Date;

public class ProductoxPromocion {
    private int idProductoxPromocion;
    private Producto producto;
    private Promocion promocion;
    private boolean activo;
    
    public ProductoxPromocion() {}

    public int getIdProductoxPromocion() {
        return idProductoxPromocion;
    }

    public void setIdProductoxPromocion(int idProductoxPromocion) {
        this.idProductoxPromocion = idProductoxPromocion;
    }

    public Producto getProducto() {
        return producto;
    }

    public void setProducto(Producto producto) {
        this.producto = producto;
    }

    public Promocion getPromocion() {
        return promocion;
    }

    public void setPromocion(Promocion promocion) {
        this.promocion = promocion;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
    
}
