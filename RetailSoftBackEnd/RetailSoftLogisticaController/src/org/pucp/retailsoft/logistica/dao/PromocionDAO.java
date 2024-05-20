/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.Promocion;

/**
 *
 * @author ABerrocalS
 */
public interface PromocionDAO {
    int insertar(Promocion promocion);
    int modificar(Promocion promocion);
    int eliminar(int idPromocion);
//    ArrayList<Promocion> listarPromociones();
    ArrayList<Promocion> listarPorCategoria(int idCategoria);

}
