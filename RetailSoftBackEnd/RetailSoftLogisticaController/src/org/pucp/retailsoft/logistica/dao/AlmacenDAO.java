/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.Almacen;


/**
 *
 * @author Dell
 */
public interface AlmacenDAO {
    int insertar(Almacen almacen);
    int modificar(Almacen almacen);
    int eliminar(int idAlmacen);
    ArrayList<Almacen> listarAlmacenes();
}
