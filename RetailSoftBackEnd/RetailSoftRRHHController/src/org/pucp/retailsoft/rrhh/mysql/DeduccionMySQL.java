package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.DeduccionDAO;
import org.pucp.retailsoft.rrhh.model.Deduccion;

public class DeduccionMySQL implements DeduccionDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<Deduccion> listar() {
        ArrayList<Deduccion> deducciones = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_DEDUCCIONES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Deduccion deduccion = new Deduccion();
                deduccion.setIdDeduccion(rs.getInt("id_deduccion"));
                deduccion.setNombre(rs.getString("nombre"));
                deduccion.setDescripcion(rs.getString("descripcion"));
                deduccion.setMonto(rs.getDouble("monto"));
                deduccion.setActivo(true);
                deducciones.add(deduccion);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return deducciones;
    }
    
}
