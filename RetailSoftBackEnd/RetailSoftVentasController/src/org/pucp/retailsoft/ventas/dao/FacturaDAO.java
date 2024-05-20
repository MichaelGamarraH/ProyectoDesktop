package org.pucp.retailsoft.ventas.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.ventas.model.Factura;

public interface FacturaDAO {
    int insertar(Factura factura);
    int modificar(Factura factura);
    int eliminar(int idFactura);
    ArrayList<Factura> listarFacturas();
}
