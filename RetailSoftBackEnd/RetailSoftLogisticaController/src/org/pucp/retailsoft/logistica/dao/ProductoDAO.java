package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.Producto;

public interface ProductoDAO {
    int insertar(Producto producto);
    int modificar(Producto producto);
    int eliminar(int idProducto);
    int actualizarStock(int idProducto,int stock);
    ArrayList<Producto> listarProductos();
    ArrayList<Producto> listarProductosXCategoria(int idCategoria);
    ArrayList<Producto> listarProductosXMarca(int idMarca);
    ArrayList<Producto> listarProductosXIdNombre(String idNombre);
    ArrayList<Producto> listarPorPromocion(int idPromocion);
}