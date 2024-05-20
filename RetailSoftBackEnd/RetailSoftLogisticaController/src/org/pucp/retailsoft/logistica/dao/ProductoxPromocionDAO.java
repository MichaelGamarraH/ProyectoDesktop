package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.ProductoxPromocion;

public interface ProductoxPromocionDAO {
    ArrayList<ProductoxPromocion> listarProductoPorPromocion(int idPromocion);
}
