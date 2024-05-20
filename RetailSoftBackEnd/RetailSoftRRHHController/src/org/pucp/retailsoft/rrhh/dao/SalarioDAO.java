/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.rrhh.dao;

import org.pucp.retailsoft.rrhh.model.Salario;

/**
 *
 * @author JOHAN
 */
public interface SalarioDAO {
    int insertar(Salario salario);
    int eliminar(int idSalario);
    Salario listarxidcolab(int idColab);
}
