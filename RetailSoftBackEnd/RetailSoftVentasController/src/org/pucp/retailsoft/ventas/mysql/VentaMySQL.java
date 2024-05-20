package org.pucp.retailsoft.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.model.Colaborador;
import org.pucp.retailsoft.ventas.model.Cliente;
import org.pucp.retailsoft.ventas.model.LineaVenta;
import org.pucp.retailsoft.ventas.model.Venta;
import org.pucp.retailsoft.ventas.dao.VentaDAO;

public class VentaMySQL implements VentaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Venta venta) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            
//            cs = con.prepareCall("{call INSERTAR_CLIENTE(?,?,?,?)}");
//            
//            
//            cs.registerOutParameter("_id_cliente", java.sql.Types.INTEGER);
//            
//            cs.setInt("_fid_tipo_cliente", venta.getCliente().getTipoCliente().getIdTipoCliente());
//            cs.setString("_documento_identidad", venta.getCliente().getDocumentoIdentidad());
//            
//            cs.setInt("_cantidad_pedidos", venta.getCliente().getCantidadPedidos());
            
            
            
            
            cs = con.prepareCall("{call INSERTAR_VENTA(?,?,?,?,?,?)}");
            
            
            cs.registerOutParameter("_id_venta", java.sql.Types.INTEGER);
            
            cs.setString("_dni", venta.getCliente().getDocumentoIdentidad());
            cs.setString("_nombre_cliente", venta.getCliente().getNombre());
            
            cs.setString("_nombre_colaborador", venta.getPromotor().getNombre());
            
            
            cs.setDouble("_monto_total", venta.getMontoTotal());
            cs.setDate("_fecha_venta", new java.sql.Date(venta.getFechaVenta().getTime()));
            
            
            cs.executeUpdate();
            
            venta.setIdVenta(cs.getInt("_id_venta"));
            for(LineaVenta lineaPedido : venta.getLineasVenta()){
                cs = con.prepareCall("{call INSERTAR_LINEA_VENTA(?,?,?,?,?,?,?)}");
                cs.registerOutParameter("_id_linea_venta", java.sql.Types.INTEGER);
                
                cs.setInt("_fid_venta", venta.getIdVenta());
                cs.setInt("_fid_producto", lineaPedido.getProducto().getIdProducto());
                cs.setString("_nombre_prod", lineaPedido.getProducto().getNombre());
                
                cs.setInt("_fid_marca", lineaPedido.getProducto().getMarcaProducto().getIdMarcaProducto());
                cs.setString("_nombre_marca", lineaPedido.getProducto().getMarcaProducto().getNombre());
                
                cs.setDouble("_subtotal", lineaPedido.getSubTotal());
                cs.executeUpdate();
            }
            resultado = venta.getIdVenta();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public ArrayList<Venta> listarPorIdDNICliente(String idDNICliente) {
        ArrayList<Venta> ventas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_VENTAS_X_ID_DNI_CLIENTE(?)}");
            cs.setString("_id_dni_cliente", idDNICliente);
            rs = cs.executeQuery();
            while(rs.next()){
                Venta venta = new Venta();
                
                venta.setIdVenta(rs.getInt("id_venta"));
                venta.setCliente(new Cliente());
                
                venta.getCliente().setDocumentoIdentidad(rs.getString("dni_cliente"));
                venta.getCliente().setNombre(rs.getString("nombre_cliente"));
                
                venta.setPromotor(new Colaborador());
                venta.getPromotor().setNombre(rs.getString("nombre_colaborador"));
                
                
                venta.setFechaVenta(rs.getDate("fecha_venta"));
                venta.setMontoTotal(rs.getDouble("monto_total"));
                ventas.add(venta);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ventas;
    }
    
}
