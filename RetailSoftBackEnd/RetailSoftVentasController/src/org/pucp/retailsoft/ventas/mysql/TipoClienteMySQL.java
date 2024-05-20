package org.pucp.retailsoft.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.ventas.dao.TipoClienteDAO;
import org.pucp.retailsoft.ventas.model.Cliente;
import org.pucp.retailsoft.ventas.model.TipoCliente;

public class TipoClienteMySQL implements TipoClienteDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(TipoCliente tipocliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_TIPO_CLIENTE(?,?,?)}");
            cs.registerOutParameter("_id_tipo_cliente", java.sql.Types.INTEGER);
            cs.setString("_nombre",tipocliente.getNombre());
            cs.setDouble("_descuento", tipocliente.getDescuento());
        
            cs.executeUpdate();
            tipocliente.setIdTipoCliente(cs.getInt("_id_tipo_cliente"));
            resultado = tipocliente.getIdTipoCliente();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();} catch(Exception ex) {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(TipoCliente tipocliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_TIPO_CLIENTE(?,?,?)}");
            cs.setInt("_id_tipo_cliente", tipocliente.getIdTipoCliente());
            cs.setString("_nombre", tipocliente.getNombre());
            cs.setDouble("_descuento", tipocliente.getDescuento());
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
    public ArrayList<TipoCliente> listarTipoClientes() {
        ArrayList<TipoCliente> tipoclientes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TIPO_CLIENTES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoCliente tipocliente = new TipoCliente();
                tipocliente.setIdTipoCliente(rs.getInt("id_tipo_cliente"));
                tipocliente.setNombre(rs.getString("nombre"));
                tipocliente.setDescuento(rs.getInt("descuento"));       
                tipoclientes.add(tipocliente);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return tipoclientes;
    }

    @Override
    public int eliminar(int idTipoCliente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_TIPO_CLIENTE(?)}");
            cs.setInt("id_tipo_cliente", idTipoCliente);
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
