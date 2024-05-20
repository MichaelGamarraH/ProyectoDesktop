/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.TipoVehiculo;


/**
 *
 * @author Dell
 */
public interface TipoVehiculoDAO {
    int insertar(TipoVehiculo tipoVehiculo);
    int modificar(TipoVehiculo tipoVehiculo);
    int eliminar(int idTipoVehiculo);
    ArrayList<TipoVehiculo> listarTiposVehiculos();
}
