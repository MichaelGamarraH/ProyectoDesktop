/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.SalarioDAO;
import org.pucp.retailsoft.rrhh.model.Colaborador;
import org.pucp.retailsoft.rrhh.model.Salario;

/**
 *
 * @author JOHAN
 */
public class SalarioMySQL implements SalarioDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Salario salario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_SALARIO(?,?,?,?)}");
            cs.registerOutParameter("_id_salario", INTEGER);
            cs.setInt("_fid_colaborador", salario.getColaborador().getIdColaborador());
            cs.setDouble("_salario_base", salario.getSalarioBase());
            cs.setDouble("_salario_final", salario.getSalarioFinal());
            cs.executeUpdate();
            salario.setIdSalario(cs.getInt("_id_salario"));   
            resultado = salario.getIdSalario(); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idSalario) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_SALARIO(?)}");
            cs.setInt("_id_salario", idSalario);
            resultado = cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }
    
    @Override
    public Salario listarxidcolab(int idColab) {
        Salario salario = new Salario();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SALARIO_X_ID_COLABORADOR(?)}");
            cs.setInt("_id_colaborador", idColab);
            rs = cs.executeQuery();
            while(rs.next()){
                salario.setColaborador(new Colaborador());
                salario.setIdSalario(rs.getInt("id_salario"));
                salario.getColaborador().setIdColaborador(rs.getInt("fid_colaborador"));
                salario.setSalarioBase(rs.getDouble("salario_base"));
                salario.setSalarioFinal(rs.getDouble("salario_final"));
                salario.setFechaRegistro(rs.getDate("fecha_registro"));
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return salario;
    }
}
