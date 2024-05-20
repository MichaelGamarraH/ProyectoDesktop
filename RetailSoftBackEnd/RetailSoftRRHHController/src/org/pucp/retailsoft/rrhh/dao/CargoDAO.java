package org.pucp.retailsoft.rrhh.dao;
import java.util.ArrayList;
import org.pucp.retailsoft.rrhh.model.Cargo;

public interface CargoDAO {
    int insertar(Cargo cargo);
    int modificar(Cargo cargo);
    int eliminar(int idCargo);
    ArrayList<Cargo> listarCargos();
}