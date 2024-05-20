/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.BeneficioxColaboradorDAO;
import org.pucp.retailsoft.rrhh.model.Beneficio;
import org.pucp.retailsoft.rrhh.model.BeneficioxColaborador;
import org.pucp.retailsoft.rrhh.model.Colaborador;

/**
 *
 * @author JOHAN
 */
public class BeneficioxColaboradorMySQL implements BeneficioxColaboradorDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(BeneficioxColaborador benxcolab) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_BENEFICIO_X_COLABORADOR(?,?,?) }");
            cs.registerOutParameter("_id_beneficio_colaborador", 
            java.sql.Types.INTEGER);
            cs.setInt("_fid_colaborador", benxcolab.getColaborador().getIdColaborador());
            cs.setInt("_fid_beneficio", benxcolab.getBeneficio().getIdBeneficio());
            resultado = cs.executeUpdate();
            benxcolab.setIdBeneficioxColaborador(cs.getInt("_id_beneficio_colaborador"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idBenxcolab) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_BENEFICIO_X_COLABORADOR(?)}");
            cs.setInt("_id_beneficio_colaborador", idBenxcolab);
            resultado = cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }
    
    @Override
    public ArrayList<BeneficioxColaborador> listarxidcolab(int idcolab) {
        ArrayList<BeneficioxColaborador> beneficiosColab = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BENEFICIOS_X_ID_COLABORADOR(?)}");
            cs.setInt("_id_colaborador", idcolab);
            rs = cs.executeQuery();
            while(rs.next()){
                BeneficioxColaborador bc = new BeneficioxColaborador();
                bc.setColaborador(new Colaborador());
                bc.setBeneficio(new Beneficio());
                bc.setIdBeneficioxColaborador(rs.getInt("id_beneficio_colaborador"));
                bc.getColaborador().setIdColaborador(rs.getInt("fid_colaborador"));
                bc.getBeneficio().setIdBeneficio(rs.getInt("fid_beneficio"));
                bc.getBeneficio().setNombre(rs.getString("nombre"));
                bc.getBeneficio().setDescripcion(rs.getString("descripcion"));
                bc.setFechaRegistro(rs.getDate("fecha_registro"));
                bc.getBeneficio().setMonto(rs.getDouble("monto"));
                beneficiosColab.add(bc);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return beneficiosColab;
    }    
}
