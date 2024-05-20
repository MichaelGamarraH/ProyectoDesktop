package org.pucp.retailsoft.logistica.model;

public class SubcategoriaProducto {
    private int idSubcategoriaProducto;
    private String nombre;
    private byte[] icono;
    private CategoriaProducto categoriaProducto;
    private boolean activo;

    public SubcategoriaProducto() {}

    public SubcategoriaProducto(String nombre, byte[] icono, CategoriaProducto categoriaProducto) {
        this.nombre = nombre;
        this.icono = icono;
        this.categoriaProducto = categoriaProducto;
        this.activo = true;
    }

    public int getIdSubcategoriaProducto() {
        return idSubcategoriaProducto;
    }

    public void setIdSubcategoriaProducto(int idSubcategoriaProducto) {
        this.idSubcategoriaProducto = idSubcategoriaProducto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public byte[] getIcono() {
        return icono;
    }

    public void setIcono(byte[] icono) {
        this.icono = icono;
    }

    public CategoriaProducto getCategoriaProducto() {
        return categoriaProducto;
    }

    public void setCategoriaProducto(CategoriaProducto categoriaProducto) {
        this.categoriaProducto = categoriaProducto;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}
