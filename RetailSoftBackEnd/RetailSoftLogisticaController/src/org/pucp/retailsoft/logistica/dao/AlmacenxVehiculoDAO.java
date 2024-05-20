/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.AlmacenxVehiculo;

/**
 *
 * @author Dell
 */
public interface AlmacenxVehiculoDAO {
    int insertar(AlmacenxVehiculo almaxveh);
    int modificar(AlmacenxVehiculo almaxveh);
    int eliminar(int almaxveh);
    ArrayList<AlmacenxVehiculo> listarAlmaVehiculo();
    ArrayList<AlmacenxVehiculo> listarPorIdAlmacen(int idAlmacen);
}