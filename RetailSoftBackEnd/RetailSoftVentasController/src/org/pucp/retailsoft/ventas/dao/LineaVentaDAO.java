package org.pucp.retailsoft.ventas.dao;
import org.pucp.retailsoft.ventas.model.LineaVenta;
import java.util.ArrayList;

public interface LineaVentaDAO {
    int insertar(LineaVenta lineaPedido);
    int modificar(LineaVenta lineaPedido);
    int eliminar(int idLineaPedido);
    ArrayList<LineaVenta> listarClientes();
    ArrayList<LineaVenta> listarPorIdVenta(String idVenta);
}
