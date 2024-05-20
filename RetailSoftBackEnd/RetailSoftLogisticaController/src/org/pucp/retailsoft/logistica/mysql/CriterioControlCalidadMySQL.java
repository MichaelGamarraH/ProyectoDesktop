package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.CriterioControlCalidadDAO;
import org.pucp.retailsoft.logistica.model.CriterioControlCalidad;

public class CriterioControlCalidadMySQL implements CriterioControlCalidadDAO {

    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<CriterioControlCalidad> listarCriteriosControlCalidad() {
        ArrayList<CriterioControlCalidad> criteriosControlCalidad = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CRITERIO_CONTROL_CALIDAD()}");
            rs = cs.executeQuery();
            while(rs.next()){
                CriterioControlCalidad criterioControlCalidad = new CriterioControlCalidad();
                criterioControlCalidad.setIdCriterioControlCalidad(rs.getInt("id_criterio_control_calidad"));
                criterioControlCalidad.setNombre(rs.getString("nombre"));
                criterioControlCalidad.setDescripcion(rs.getString("descripcion"));
                criterioControlCalidad.setActivo(true);
                criteriosControlCalidad.add(criterioControlCalidad);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return criteriosControlCalidad;
    }
    
}
