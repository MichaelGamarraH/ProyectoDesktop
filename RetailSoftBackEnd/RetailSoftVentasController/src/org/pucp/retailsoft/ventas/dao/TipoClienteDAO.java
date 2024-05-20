package org.pucp.retailsoft.ventas.dao;
import org.pucp.retailsoft.ventas.model.TipoCliente;
import java.util.ArrayList;

public interface TipoClienteDAO {
    int insertar(TipoCliente tipoCliente);
    int modificar(TipoCliente tipoCliente);
    int eliminar(int idTipoCliente);
    ArrayList<TipoCliente> listarTipoClientes();
}
