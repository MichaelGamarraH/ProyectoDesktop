package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.MarcaProductoDAO;
import org.pucp.retailsoft.logistica.model.MarcaProducto;

public class MarcaProductoMySQL implements MarcaProductoDAO {
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public ArrayList<MarcaProducto> listarMarcasProducto() {
        ArrayList<MarcaProducto> marcasProducto = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MARCA_PRODUCTO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                MarcaProducto marcaProducto = new MarcaProducto();
                
                marcaProducto.setIdMarcaProducto(rs.getInt("id_marca_producto"));
                marcaProducto.setNombre(rs.getString("nombre"));
                marcaProducto.setIcono(rs.getBytes("icono"));
                marcaProducto.setActivo(true);
                marcasProducto.add(marcaProducto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return marcasProducto;
    }
    
}
