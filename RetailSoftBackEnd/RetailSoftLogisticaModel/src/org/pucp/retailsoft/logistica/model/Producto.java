package org.pucp.retailsoft.logistica.model;

public class Producto {
    private int idProducto;
    private String nombre;
    private String descripcion;
    private byte[] imagen;
    private int stock;
    private String tallaModelo;
    private double precio;
    private boolean estado;
    private MarcaProducto marcaProducto;
    private SubcategoriaProducto subcategoriaProducto;
    private boolean activo;
	private Promocion promocion;

    public Producto() {}

    public Producto(String nombre, String descripcion, byte[] imagen, int stock, String tallaModelo, double precio, boolean estado, MarcaProducto marcaProducto, SubcategoriaProducto subcategoriaProducto) {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.imagen = imagen;
        this.stock = stock;
        this.tallaModelo = tallaModelo;
        this.precio = precio;
        this.estado = estado;
        this.marcaProducto = marcaProducto;
        this.subcategoriaProducto = subcategoriaProducto;
        this.activo = true;
    }

    public int getIdProducto() {
        return idProducto;
    }

    public void setIdProducto(int idProducto) {
        this.idProducto = idProducto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public String getTallaModelo() {
        return tallaModelo;
    }

    public void setTallaModelo(String tallaModelo) {
        this.tallaModelo = tallaModelo;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public MarcaProducto getMarcaProducto() {
        return marcaProducto;
    }

    public void setMarcaProducto(MarcaProducto marcaProducto) {
        this.marcaProducto = marcaProducto;
    }

    public SubcategoriaProducto getSubcategoriaProducto() {
        return subcategoriaProducto;
    }

    public void setSubcategoriaProducto(SubcategoriaProducto subcategoriaProducto) {
        this.subcategoriaProducto = subcategoriaProducto;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
	public Promocion getPromocion() {
        return promocion;
    }

    public void setPromocion(Promocion promocion) {
        this.promocion = promocion;
    }
    
}
