package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.SubcategoriaProducto;

public interface SubcategoriaProductoDAO {
    ArrayList<SubcategoriaProducto> listarSubcategoriasProducto();
    ArrayList<SubcategoriaProducto> listarSubcategoriasXCategoria(int idCategoria);
}
