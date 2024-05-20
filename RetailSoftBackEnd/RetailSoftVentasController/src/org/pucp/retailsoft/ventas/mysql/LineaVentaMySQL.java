package org.pucp.retailsoft.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.model.MarcaProducto;
import org.pucp.retailsoft.logistica.model.Producto;
import org.pucp.retailsoft.ventas.model.LineaVenta;
import org.pucp.retailsoft.ventas.dao.LineaVentaDAO;

public class LineaVentaMySQL implements LineaVentaDAO {
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(LineaVenta lineaPedido) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int modificar(LineaVenta lineaPedido) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idLineaPedido) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public ArrayList<LineaVenta> listarClientes() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    @Override
    public ArrayList<LineaVenta> listarPorIdVenta(String idVenta) {
        ArrayList<LineaVenta> lineas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LINEAS_VENTAS_X_ID_VENTA(?)}");
            cs.setString("_id_venta", idVenta);
            rs = cs.executeQuery();
            while(rs.next()){
                LineaVenta linea = new LineaVenta();
                
                linea.setIdLineaPedido(rs.getInt("id_linea_venta"));
                linea.setProducto(new Producto());
                
                linea.getProducto().setIdProducto(rs.getInt("fid_producto"));
                linea.getProducto().setNombre(rs.getString("nombre_prod"));
                
                linea.getProducto().setMarcaProducto(new MarcaProducto());
                linea.getProducto().getMarcaProducto().setNombre(rs.getString("nombre_marca"));
                
                linea.setSubTotal(rs.getDouble("subtotal"));
                
                lineas.add(linea);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lineas;
    }
    
}
