/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;

/**
 *
 * @author Dell
 */
public interface CategoriaProductoDAO {
    int insertar(CategoriaProducto categoriaProducto);
    int modificar(CategoriaProducto categoriaProducto);
    int eliminar(int idCategoriaProducto);
    ArrayList<CategoriaProducto> listarCategoriaProductos();
}
