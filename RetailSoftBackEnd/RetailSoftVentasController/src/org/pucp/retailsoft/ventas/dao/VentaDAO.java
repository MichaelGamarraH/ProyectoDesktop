package org.pucp.retailsoft.ventas.dao;
import java.util.ArrayList;
import org.pucp.retailsoft.ventas.model.Venta;

public interface VentaDAO {
    int insertar(Venta pedido);
    ArrayList<Venta> listarPorIdDNICliente(String idDNICliente);
}
