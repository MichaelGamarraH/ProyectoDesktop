package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.rrhh.model.AsistenciaColaborador;

public interface AsistenciaColaboradorDAO {
    int insertar(AsistenciaColaborador asistenciaColaborador);
    int modificar(AsistenciaColaborador asistenciaColaborador);
    ArrayList<AsistenciaColaborador> listarAsistenciaColaborador();
    AsistenciaColaborador listarxidColaborador(int idColab);
}
