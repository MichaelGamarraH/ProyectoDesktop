package org.pucp.retailsoft.ventas.dao;
import org.pucp.retailsoft.ventas.model.Cliente;
import java.util.ArrayList;

public interface ClienteDAO {
    int insertar(Cliente cliente);
    int modificar(Cliente cliente);
    int eliminar(int idCliente);
    ArrayList<Cliente> listarClientes();
}


