package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.LotexCriterioControlCalidadDAO;
import org.pucp.retailsoft.logistica.model.CriterioControlCalidad;
import org.pucp.retailsoft.logistica.model.LotexCriterioControlCalidad;

public class LotexCriterioControlCalidadMySQL implements LotexCriterioControlCalidadDAO{
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public ArrayList<LotexCriterioControlCalidad> listarLotexCriterioControlCalidad(int idLote) {
        ArrayList<LotexCriterioControlCalidad> lotexCriteriosControlCalidad = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LOTE_X_CRITERIO_CONTROL_CALIDAD(?)}");
            cs.setInt("_id_lote", idLote);
            rs = cs.executeQuery();
            while(rs.next()){
                LotexCriterioControlCalidad lotexCriterioControlCalidad = new LotexCriterioControlCalidad();
                
                lotexCriterioControlCalidad.setIdLotexCriterioControlCalidad(rs.getInt("id_lote_x_criterio_control_calidad"));
                lotexCriterioControlCalidad.setResultado(rs.getBoolean("resultado"));
                lotexCriterioControlCalidad.setFechaInspeccion(rs.getDate("fecha_inspeccion"));
                lotexCriterioControlCalidad.setObservacion(rs.getString("observacion"));
                lotexCriterioControlCalidad.setCriterioControlCalidad(new CriterioControlCalidad());
                lotexCriterioControlCalidad.getCriterioControlCalidad().setNombre(rs.getString("nombre"));
                lotexCriterioControlCalidad.getCriterioControlCalidad().setDescripcion(rs.getString("descripcion"));
                lotexCriterioControlCalidad.setActivo(true);
                lotexCriteriosControlCalidad.add(lotexCriterioControlCalidad);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return lotexCriteriosControlCalidad;
    }
    
}
