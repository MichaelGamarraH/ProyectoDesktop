package org.pucp.retailsoft.ventas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.ventas.dao.BoletaDAO;
import org.pucp.retailsoft.ventas.model.Boleta;

public class BoletaMySQL implements BoletaDAO {
    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Boleta boleta) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_BOLETA(?,?,?)}");
            cs.registerOutParameter("_id_boleta", java.sql.Types.INTEGER);
            cs.setInt("_fid_cliente", boleta.getCliente().getIdCliente());
            cs.setInt("_fid_venta", boleta.getVenta().getIdVenta());
            cs.executeUpdate();
            boleta.setIdBoleta(cs.getInt("_id_boleta"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Boleta boleta) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_BOLETA(?,?,?)}");
            cs.setInt("_id_boleta", boleta.getIdBoleta());
            cs.setInt("_fid_cliente", boleta.getCliente().getIdCliente());
            cs.setInt("_fid_venta", boleta.getVenta().getIdVenta());
            cs.executeUpdate();
            boleta.setIdBoleta(cs.getInt("_id_boleta"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int eliminar(int idBoleta) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_BOLETA(?)}");
            cs.setInt("_id_empleado", idBoleta);
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
    public ArrayList<Boleta> listarPromociones() {
        ArrayList<Boleta> boletas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BOLETAS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Boleta bo = new Boleta();
                bo.setIdDocumentoVenta(rs.getInt("id_documento_venta"));
                bo.setFechaEmision(rs.getDate("fecha_emision"));
                bo.setNumDocumento(rs.getString("num_documento"));
                bo.setActivo(true);
                boletas.add(bo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return boletas;
    }
    
}
