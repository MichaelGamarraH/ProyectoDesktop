/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;


import java.util.ArrayList;
import java.util.Date;
 
import org.pucp.retailsoft.logistica.model.Proveedor;

/**
 *
 * @author Dell
 */
public interface ProveedorDAO {
    int insertar(Proveedor proveedor);
    int modificar(Proveedor proveedor);
    int eliminar(int idProveedor);
    ArrayList<Proveedor> listarProveedores();
    ArrayList<Proveedor> listarPorNombreProveedores(String razonProveedor);
    ArrayList<Proveedor> listarProveedoresRecientes();
    ArrayList<Proveedor> listarProveedoresAntiguos();
    ArrayList<Proveedor> listarProveedorEntreFechas(Date fechaInicial,Date fechaFinal); 
    
}
