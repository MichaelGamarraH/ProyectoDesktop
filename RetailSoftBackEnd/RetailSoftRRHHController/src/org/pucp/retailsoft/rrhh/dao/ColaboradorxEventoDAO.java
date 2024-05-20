package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.rrhh.model.ColaboradorxEvento;

public interface ColaboradorxEventoDAO {
    int insertar(ColaboradorxEvento colabxevento);
    int eliminar(int idColabxEvento);
    ArrayList<ColaboradorxEvento> listarxidEvento(int idEvento);
}
