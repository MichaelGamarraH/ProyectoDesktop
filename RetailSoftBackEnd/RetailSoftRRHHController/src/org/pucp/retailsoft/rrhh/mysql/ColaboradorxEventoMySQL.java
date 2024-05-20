package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.ColaboradorxEventoDAO;
import org.pucp.retailsoft.rrhh.model.Cargo;
import org.pucp.retailsoft.rrhh.model.Colaborador;
import org.pucp.retailsoft.rrhh.model.ColaboradorxEvento;
import org.pucp.retailsoft.rrhh.model.Evento;

public class ColaboradorxEventoMySQL implements ColaboradorxEventoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(ColaboradorxEvento colabxevento) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_COLABORADOR_X_EVENTO(?,?,?,?) }");
            cs.registerOutParameter("_id_colaborador_evento", 
            java.sql.Types.INTEGER);
            cs.setInt("_fid_colaborador", colabxevento.getColaborador().getIdPersona());
            cs.setInt("_fid_evento", colabxevento.getEvento().getIdEvento());
            cs.setBoolean("_asistencia", colabxevento.isAsistencia());
            resultado = cs.executeUpdate();
            colabxevento.setIdColaboradorxEvento(cs.getInt("_id_colaborador_evento"));
            //resultado = colabxevento.getIdColaboradorxEvento();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<ColaboradorxEvento> listarxidEvento(int idEvento) {
        ArrayList<ColaboradorxEvento> colaboradoresEvento = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_COLABORADORES_X_ID_EVENTO(?)}");
            cs.setInt("_id_evento", idEvento);
            rs = cs.executeQuery();
            while(rs.next()){
                ColaboradorxEvento ce = new ColaboradorxEvento();
                ce.setEvento(new Evento());
                ce.setColaborador(new Colaborador());
                ce.setIdColaboradorxEvento(rs.getInt("id_colaborador_evento"));
                ce.setAsistencia(true);
                ce.getEvento().setIdEvento(rs.getInt("fid_evento"));
                ce.getColaborador().setIdColaborador(rs.getInt("fid_colaborador"));
                ce.getColaborador().setIdPersona(rs.getInt("fid_colaborador"));
                ce.getColaborador().setNombre(rs.getString("nombre"));
                ce.getColaborador().setDni(rs.getString("documento_identidad"));
                ce.getColaborador().setApellidoPaterno(rs.getString("apellido_paterno"));
                ce.getColaborador().setApellidoMaterno(rs.getString("apellido_materno"));
                ce.getColaborador().setCorreoElectronico(rs.getString("correo_electronico"));
                ce.getColaborador().setCargo(new Cargo());
                ce.getColaborador().getCargo().setIdCargo(rs.getInt("id_cargo"));
                ce.getColaborador().getCargo().setTipoCargo(rs.getString("tipo_cargo"));
                colaboradoresEvento.add(ce);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return colaboradoresEvento;
    }

    @Override
    public int eliminar(int idColabxEvento) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_COLABORADOR_X_EVENTO(?)}");
            cs.setInt("_id_colaborador_evento", idColabxEvento);
            resultado = cs.executeUpdate();
	}catch(Exception ex){
            System.out.println(ex.getMessage());
	}finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }
}
