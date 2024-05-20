package org.pucp.retailsoft.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.ventas.dao.FacturaDAO;
import org.pucp.retailsoft.ventas.model.Factura;


public class FacturaMySQL implements FacturaDAO {
    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Factura factura) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_FACTURA(?,?,?,?,?)}");
            cs.registerOutParameter("_id_factura", java.sql.Types.INTEGER);
            cs.setInt("_fid_cliente", factura.getCliente().getIdCliente());
            cs.setInt("_fid_venta", factura.getVenta().getIdVenta());
            cs.setDate("_fecha_vencimiento", new java.sql.Date(factura.getFechaVencimiento().getTime()));
            cs.setString("_terminos_pago",factura.getTerminosPago());
            
            cs.executeUpdate();
            factura.setIdFactura(cs.getInt("_id_factura"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int modificar(Factura factura) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_FACTURA(?,?,?,?,?)}");
            cs.setInt("_id_factura", factura.getIdFactura());
            cs.setInt("_fid_cliente", factura.getCliente().getIdCliente());
            cs.setInt("_fid_venta", factura.getVenta().getIdVenta());
            cs.setDate("_fecha_vencimiento", new java.sql.Date(factura.getFechaVencimiento().getTime()));
            cs.setString("_terminos_pago",factura.getTerminosPago());
            
            cs.executeUpdate();
            factura.setIdFactura(cs.getInt("_id_factura"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int eliminar(int idFactura) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_FACTURA(?)}");
            cs.setInt("_id_empleado", idFactura);
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
    public ArrayList<Factura> listarFacturas() {
        ArrayList<Factura> facturas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_FACTURAS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Factura fa = new Factura();
                fa.setIdDocumentoVenta(rs.getInt("id_documento_venta"));
                fa.setFechaEmision(rs.getDate("fecha_emision"));
                fa.setNumDocumento(rs.getString("num_documento"));
                fa.setFechaVencimiento(rs.getDate("fecha_vencimiento"));
                fa.setTerminosPago(rs.getString("terminos_pago"));
                fa.setActivo(true);
                facturas.add(fa);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return facturas;
    }
    
}
