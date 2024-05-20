package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.logistica.model.Lote;

public interface LoteDAO {
    int insertar(Lote lote);
    int modificar(Lote lote);
    int eliminar(int idLote);
    ArrayList<Lote> listarLotes();
    ArrayList<Lote> listarLotesXProveedor(int idProveedor);
    ArrayList<Lote> listarLotesXFechaCompra(Date fechaInicio,Date fechaFin);
    ArrayList<Lote> listarLotesXFechaLlegada(Date fechaInicio,Date fechaFin);
    ArrayList<Lote> listarLotesXIDProveedorAlmacen(String idProveedorAlmacen);
}
