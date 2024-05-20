package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.EstadoCandidatoDAO;
import org.pucp.retailsoft.rrhh.model.EstadoCandidato;

public class EstadoCandidatoMySQL implements EstadoCandidatoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<EstadoCandidato> listar() {
        ArrayList<EstadoCandidato> estados = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ESTADOS_CANDIDATO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                EstadoCandidato estado = new EstadoCandidato();
                estado.setIdEstadoCandidato(rs.getInt("id_estado_candidato"));
                estado.setNombre(rs.getString("nombre"));
                estado.setActivo(true);
                estados.add(estado);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return estados;
    }
    
}
