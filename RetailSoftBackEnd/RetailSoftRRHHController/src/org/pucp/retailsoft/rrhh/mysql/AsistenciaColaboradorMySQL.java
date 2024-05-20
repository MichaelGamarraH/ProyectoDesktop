package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.AsistenciaColaboradorDAO;
import org.pucp.retailsoft.rrhh.model.AsistenciaColaborador;
import org.pucp.retailsoft.rrhh.model.Colaborador;

public class AsistenciaColaboradorMySQL implements AsistenciaColaboradorDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(AsistenciaColaborador asistenciaColaborador) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ASISTENCIA_COLABORADOR(?,?)}");
            cs.registerOutParameter("_id_asistencia", INTEGER);
            cs.setInt("_fid_colaborador", asistenciaColaborador.getColaborador().getIdColaborador());
            resultado = cs.executeUpdate();
            asistenciaColaborador.setIdAsistencia(cs.getInt("_id_asistencia")); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(AsistenciaColaborador asistenciaColaborador) {
        int resultado = 0;
	try{
		con = DBManager.getInstance().getConnection();
		cs = con.prepareCall("{call MODIFICAR_ASISTENCIA_COLABORADOR(?,?,?,?,?,?)}");
                cs.setInt("_id_asistencia", asistenciaColaborador.getIdAsistencia());
		cs.setInt("_fid_colaborador", asistenciaColaborador.getColaborador().getIdColaborador());
                cs.setDate("_fecha_asistencia", new java.sql.Date(asistenciaColaborador.getFechaAsistencia().getTime()));
                cs.setTime("_hora_ingreso",asistenciaColaborador.getHoraIngreso());
                cs.setTime("_hora_salida",asistenciaColaborador.getHoraSalida());
                cs.setDouble("_horas_trabajadas",asistenciaColaborador.getHorasTrabajadas());
		resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public ArrayList<AsistenciaColaborador> listarAsistenciaColaborador() {
        ArrayList<AsistenciaColaborador> asistencias = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ASISTENCIA_COLABORADOR()}");
            rs = cs.executeQuery();
            while(rs.next()){
                AsistenciaColaborador a = new AsistenciaColaborador();
                a.setIdAsistencia(rs.getInt("id_asistencia"));
                a.setColaborador(new Colaborador());
                a.getColaborador().setIdColaborador(rs.getInt("fid_colaborador"));
                a.setFechaAsistencia(rs.getDate("fecha_asistencia"));
                a.setHoraIngreso(rs.getTime("hora_ingreso"));
                a.setHoraSalida(rs.getTime("hora_salida"));
                a.setHorasTrabajadas(rs.getDouble("horas_trabajadas"));
                asistencias.add(a);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return asistencias;
    }

    @Override
    public AsistenciaColaborador listarxidColaborador(int idColab) {
        AsistenciaColaborador a = new AsistenciaColaborador();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ASISTENCIA_X_ID_COLABORADOR(?)}");
            cs.setInt("_id_colaborador", idColab);
            rs = cs.executeQuery();
            while(rs.next()){
                a.setIdAsistencia(rs.getInt("id_asistencia"));
                a.setColaborador(new Colaborador());
                a.getColaborador().setIdColaborador(rs.getInt("fid_colaborador"));
                a.setFechaAsistencia(rs.getDate("fecha_asistencia"));
                a.setHoraIngreso(rs.getTime("hora_ingreso"));
                a.setHoraSalida(rs.getTime("hora_salida"));
                a.setHorasTrabajadas(rs.getDouble("horas_trabajadas"));
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return a;
    }
    
}
