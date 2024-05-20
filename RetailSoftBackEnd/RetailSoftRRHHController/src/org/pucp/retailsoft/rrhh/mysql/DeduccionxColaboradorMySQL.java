package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.DeduccionxColaboradorDAO;
import org.pucp.retailsoft.rrhh.model.DeduccionxColaborador;

public class DeduccionxColaboradorMySQL implements DeduccionxColaboradorDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(DeduccionxColaborador deducxcolab) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_DEDUCCION_X_COLABORADOR(?,?,?) }");
            cs.registerOutParameter("_id_deduccion_colaborador", 
            java.sql.Types.INTEGER);
            cs.setInt("_fid_colaborador", deducxcolab.getColaborador().getIdColaborador());
            cs.setInt("_fid_deduccion", deducxcolab.getDeduccion().getIdDeduccion());
            resultado = cs.executeUpdate();
            deducxcolab.setIdDeduccionxColaborador(cs.getInt("_id_deduccion_colaborador"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
