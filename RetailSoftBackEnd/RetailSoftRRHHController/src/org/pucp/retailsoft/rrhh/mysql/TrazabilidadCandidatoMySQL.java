package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.TrazabilidadCandidatoDAO;
import org.pucp.retailsoft.rrhh.model.Candidato;
import org.pucp.retailsoft.rrhh.model.EstadoCandidato;
import org.pucp.retailsoft.rrhh.model.TrazabilidadCandidato;

public class TrazabilidadCandidatoMySQL implements TrazabilidadCandidatoDAO
{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(TrazabilidadCandidato traza) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_TRAZABILIDAD_CANDIDATO(?,?,?,?,?)}");
            cs.registerOutParameter("_id_trazabilidad", INTEGER);
            cs.setInt("_fid_candidato", traza.getCandidato().getIdCandidato());
            cs.setInt("_fid_estado_candidato", traza.getEstadoCandidato().getIdEstadoCandidato());
            cs.setDate("_fecha", new java.sql.Date(traza.getFecha().getTime()));
            cs.setString("_observacion", traza.getObservacion());
            cs.executeUpdate();
            traza.setIdTrazabilidadCandidato(cs.getInt("_id_trazabilidad"));   
            resultado = traza.getIdTrazabilidadCandidato(); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public TrazabilidadCandidato listarTrazabilidadActualIdCandidato(int idCand) {
        TrazabilidadCandidato traza = new TrazabilidadCandidato();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TRAZABILIDAD_ACTUAL_ID_CANDIDATO(?)}");
            cs.setInt("_id_candidato", idCand);
            rs = cs.executeQuery();
            while(rs.next()){
                traza.setIdTrazabilidadCandidato(rs.getInt("id_trazabilidad"));
                traza.setCandidato(new Candidato());
                traza.getCandidato().setIdCandidato(rs.getInt("fid_candidato"));
                traza.setEstadoCandidato(new EstadoCandidato());
                traza.getEstadoCandidato().setIdEstadoCandidato(rs.getInt("fid_estado_candidato"));
                traza.getEstadoCandidato().setNombre(rs.getString("nombre"));
                traza.setFecha(rs.getDate("fecha"));
                traza.setObservacion(rs.getString("observacion"));
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return traza;
    }

    @Override
    public ArrayList<TrazabilidadCandidato> listarTrazabilidadXIdCandidato(int idCand) {
        ArrayList<TrazabilidadCandidato> trazas = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TRAZABILIDAD_X_ID_CANDIDATO(?)}");
            cs.setInt("_id_candidato", idCand);
            rs = cs.executeQuery();
            while(rs.next()){
                TrazabilidadCandidato traza = new TrazabilidadCandidato();
                traza.setIdTrazabilidadCandidato(rs.getInt("id_trazabilidad"));
                traza.setCandidato(new Candidato());
                traza.getCandidato().setIdCandidato(rs.getInt("fid_candidato"));
                traza.setEstadoCandidato(new EstadoCandidato());
                traza.getEstadoCandidato().setIdEstadoCandidato(rs.getInt("fid_estado_candidato"));
                traza.getEstadoCandidato().setNombre(rs.getString("nombre"));
                traza.setFecha(rs.getDate("fecha"));
                traza.setObservacion(rs.getString("observacion"));
                trazas.add(traza);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return trazas;
    }
}
