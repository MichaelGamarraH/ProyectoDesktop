package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.rrhh.model.PuestoTrabajo;

public interface PuestoTrabajoDAO {
   int insertar(PuestoTrabajo puesto);
   int modificar(PuestoTrabajo puesto);
   int eliminar(int idPuesto);
   ArrayList<PuestoTrabajo> listar();
   ArrayList<PuestoTrabajo> listarPorNombre(String nombre);
   ArrayList<PuestoTrabajo> listarPorFechaPublicacion(Date fechaInicio, Date fechaFin);
   ArrayList<PuestoTrabajo> listarPorFechaLimite(Date fechaInicio, Date fechaFin);
}
