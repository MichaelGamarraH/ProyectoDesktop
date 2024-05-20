package org.pucp.retailsoft.logistica.model;

import java.util.ArrayList;
import java.util.Date;

public class Almacen {
    private int idAlmacen;
    private String nombre;
    private String responsable;
    private String direccion;
    private int capacidad;
    private Date fechaActualizacion;
    private Date fecha_mantenimiento;
    private String descripcion;
    private boolean espacio_pickpack;
    private boolean stand_ajustable;
    private boolean sistema_iluminacion;
    private boolean control_calidad;
    private boolean activo;
    private ArrayList<Vehiculo> vehiculos;
    
    public Almacen() {}

    public ArrayList<Vehiculo> getVehiculos() {
        return vehiculos;
    }

    public void setVehiculos(ArrayList<Vehiculo> vehiculos) {
        this.vehiculos = vehiculos;
    }
    
    public Almacen(String nombre, String direccion, int capacidad) {
        this.nombre = nombre;
        this.direccion = direccion;
        this.capacidad = capacidad;
        this.activo=true;
    }

    
    public int getIdAlmacen() {
        return idAlmacen;
    }

    public void setIdAlmacen(int idAlmacen) {
        this.idAlmacen = idAlmacen;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getCapacidad() {
        return capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    public String getResponsable() {
        return responsable;
    }

    public void setResponsable(String responsable) {
        this.responsable = responsable;
    }

    public Date getFechaActualizacion() {
        return fechaActualizacion;
    }

    public void setFechaActualizacion(Date fechaActualizacion) {
        this.fechaActualizacion = fechaActualizacion;
    }

    public Date getFecha_mantenimiento() {
        return fecha_mantenimiento;
    }

    public void setFecha_mantenimiento(Date fecha_mantenimiento) {
        this.fecha_mantenimiento = fecha_mantenimiento;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public boolean isEspacio_pickpack() {
        return espacio_pickpack;
    }

    public void setEspacio_pickpack(boolean espacio_pickpack) {
        this.espacio_pickpack = espacio_pickpack;
    }

    public boolean isStand_ajustable() {
        return stand_ajustable;
    }

    public void setStand_ajustable(boolean stand_ajustable) {
        this.stand_ajustable = stand_ajustable;
    }

    public boolean isSistema_iluminacion() {
        return sistema_iluminacion;
    }

    public void setSistema_iluminacion(boolean sistema_iluminacion) {
        this.sistema_iluminacion = sistema_iluminacion;
    }

    public boolean isControl_calidad() {
        return control_calidad;
    }

    public void setControl_calidad(boolean control_calidad) {
        this.control_calidad = control_calidad;
    }
}