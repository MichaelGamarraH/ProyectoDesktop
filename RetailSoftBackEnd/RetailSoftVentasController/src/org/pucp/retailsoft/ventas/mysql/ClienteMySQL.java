package org.pucp.retailsoft.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.ventas.dao.ClienteDAO;
import org.pucp.retailsoft.ventas.model.Cliente;
import org.pucp.retailsoft.ventas.model.TipoCliente;

public class ClienteMySQL implements ClienteDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Cliente cliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CLIENTE(?,?,?,?)}");
            cs.registerOutParameter("_id_cliente", java.sql.Types.INTEGER);         
            cs.setInt("_fid_tipo_cliente", cliente.getTipoCliente().getIdTipoCliente());
            cs.setString("_documento_identidad",cliente.getDocumentoIdentidad());
            cs.setInt("_cantidad_pedidos", cliente.getCantidadPedidos());
            
            cs.executeUpdate();
            cliente.setIdCliente(cs.getInt("_id_cliente"));
            resultado = cliente.getIdCliente();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();} catch(Exception ex) {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Cliente cliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CLIENTE(?,?,?)}");
            cs.setInt("_id_cliente", cliente.getIdCliente());
            cs.setString("_documento_identidad", cliente.getDocumentoIdentidad());
            cs.setInt("_fid_tipo_cliente", cliente.getTipoCliente().getIdTipoCliente());
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
   
    @Override
    public ArrayList<Cliente> listarClientes() {
        ArrayList<Cliente> clientes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CLIENTES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Cliente cliente = new Cliente();
                cliente.setIdCliente(rs.getInt("id_cliente"));
                cliente.setTipoCliente(new TipoCliente());
                cliente.getTipoCliente().setIdTipoCliente(rs.getInt("fid_tipo_cliente"));
                cliente.setDocumentoIdentidad(rs.getString("documento_identidad"));
                cliente.setCantidadPedidos(rs.getInt("cantidad_pedidos"));       
                clientes.add(cliente);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return clientes;
    }

    @Override
    public int eliminar(int idCliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CLIENTE(?)}");
            cs.setInt("_id_cliente", idCliente);
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

}