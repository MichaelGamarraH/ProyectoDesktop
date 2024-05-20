package org.pucp.retailsoft.ventas.dao;
import java.util.ArrayList;
import org.pucp.retailsoft.ventas.model.Boleta;

public interface BoletaDAO {
    int insertar(Boleta boleta);
    int modificar(Boleta boleta);
    int eliminar(int idBoleta);
    ArrayList<Boleta> listarPromociones();
}
