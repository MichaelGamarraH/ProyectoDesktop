package org.pucp.retailsoft.logistica.model;

/**
 *
 * @author Dell
 */
public class AlmacenxVehiculo {

    private int idAlmacenxVehiculo;
    private Almacen almacen;
    private Vehiculo vehiculo;
    private boolean activo;
    
    public int getIdAlmacenxVehiculo() {
        return idAlmacenxVehiculo;
    }
    public void setIdAlmacenxVehiculo(int idAlmacenxVehiculo) {
        this.idAlmacenxVehiculo = idAlmacenxVehiculo;
    }

    public Almacen getAlmacen() {
        return almacen;
    }
    
    public void setAlmacen(Almacen almacen) {
        this.almacen = almacen;
    }
    
    public Vehiculo getVehiculo() {
        return vehiculo;
    }

    public void setVehiculo(Vehiculo vehiculo) {
        this.vehiculo = vehiculo;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}
