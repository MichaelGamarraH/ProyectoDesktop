package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.BeneficioxPuestoDAO;
import org.pucp.retailsoft.rrhh.model.BeneficioxPuesto;


public class BeneficioxPuestoMySQL implements BeneficioxPuestoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(BeneficioxPuesto benxpuesto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_BENEFICIO_X_PUESTO(?,?,?) }");
            cs.registerOutParameter("_id_beneficio_puesto", 
            java.sql.Types.INTEGER);
            cs.setInt("_fid_puesto_trabajo", benxpuesto.getPuestoTrabajo().getIdPuestoTrabajo());
            cs.setInt("_fid_beneficio", benxpuesto.getBeneficio().getIdBeneficio());
            cs.executeUpdate();
            benxpuesto.setIdBeneficioPuesto(cs.getInt("_id_beneficio_puesto"));
            resultado = benxpuesto.getIdBeneficioPuesto();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
