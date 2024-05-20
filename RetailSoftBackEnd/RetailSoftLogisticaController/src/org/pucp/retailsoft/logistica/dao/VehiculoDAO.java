/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.Vehiculo;

/**
 *
 * @author Dell
 */
public interface VehiculoDAO {
    int insertar(Vehiculo vehiculo);
    int modificar(Vehiculo vehiculo);
    int eliminar(int idVehiculo);
    ArrayList<Vehiculo> listarVehiculos();
}
