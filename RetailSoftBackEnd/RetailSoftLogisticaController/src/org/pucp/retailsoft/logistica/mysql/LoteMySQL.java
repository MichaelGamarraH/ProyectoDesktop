package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.LoteDAO;
import org.pucp.retailsoft.logistica.model.Almacen;
import org.pucp.retailsoft.logistica.model.Lote;
import org.pucp.retailsoft.logistica.model.LotexCriterioControlCalidad;
import org.pucp.retailsoft.logistica.model.Producto;
import org.pucp.retailsoft.logistica.model.Proveedor;

public class LoteMySQL implements LoteDAO {
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Lote lote) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_LOTE(?,?,?,?,?,?,?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_lote",java.sql.Types.INTEGER);
            cs.setDate("_fecha_compra", new java.sql.Date(lote.getFechaCompra().getTime()));
            cs.setDate("_fecha_llegada", new java.sql.Date(lote.getFechaLlegada().getTime()));
            cs.setDouble("_peso", lote.getPeso());
            cs.setString("_observacion", lote.getObservacion());
            cs.setDouble("_costo_total", lote.getCostoTotal());
            cs.setInt("_estado", lote.getEstado());
            cs.setInt("_fid_proveedor", lote.getProveedor().getIdProveedor());
            cs.setInt("_fid_almacen", lote.getAlmacen().getIdAlmacen());
            cs.setInt("_fid_producto",lote.getProducto().getIdProducto());
            cs.setInt("_cantidad", lote.getCantidad());
            cs.setDouble("_costo_unitario", lote.getCostoUnitario());
            cs.executeUpdate();
            lote.setIdLote(cs.getInt("_id_lote"));
            
            for(LotexCriterioControlCalidad lcc : lote.getListaCriterios()){
                cs = con.prepareCall("{ call INSERTAR_LOTE_X_CRITERIO_CONTROL_CALIDAD(?,?,?,?,?,?) }");
                cs.registerOutParameter("_id_lote_x_criterio_control_calidad",java.sql.Types.INTEGER);
                cs.setBoolean("_resultado", lcc.isResultado());
                cs.setDate("_fecha_inspeccion", new java.sql.Date(lcc.getFechaInspeccion().getTime()));
                cs.setString("_observacion", lcc.getObservacion());
                cs.setInt("_fid_lote", lote.getIdLote());
                cs.setInt("_fid_criterio_control_calidad", lcc.getCriterioControlCalidad().getIdCriterioControlCalidad());
                cs.executeUpdate();
                lcc.setIdLotexCriterioControlCalidad(cs.getInt("_id_lote_x_criterio_control_calidad"));
            }
            resultado = lote.getIdLote();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Lote lote) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_LOTE(?,?,?,?,?,?,?,?,?,?,?,?) }");
            cs.setInt("_id_lote", lote.getIdLote());
            cs.setDate("_fecha_compra", new java.sql.Date(lote.getFechaCompra().getTime()));
            cs.setDate("_fecha_llegada", new java.sql.Date(lote.getFechaLlegada().getTime()));
            cs.setDouble("_peso", lote.getPeso());
            cs.setString("_observacion", lote.getObservacion());
            cs.setDouble("_costo_total", lote.getCostoTotal());
            cs.setInt("_estado", lote.getEstado());
            cs.setInt("_fid_proveedor", lote.getProveedor().getIdProveedor());
            cs.setInt("_fid_almacen", lote.getAlmacen().getIdAlmacen());
            cs.setInt("_fid_producto",lote.getProducto().getIdProducto());
            cs.setInt("_cantidad", lote.getCantidad());
            cs.setDouble("_costo_unitario", lote.getCostoUnitario());
            resultado = cs.executeUpdate();
            
            for(LotexCriterioControlCalidad lcc : lote.getListaCriterios()){
                cs = con.prepareCall("{ call MODIFICAR_LOTE_X_CRITERIO_CONTROL_CALIDAD(?,?,?,?,?,?) }");
                cs.setInt("_id_lote_x_criterio_control_calidad", lcc.getIdLotexCriterioControlCalidad());
                cs.setBoolean("_resultado", lcc.isResultado());
                cs.setDate("_fecha_inspeccion", new java.sql.Date(lcc.getFechaInspeccion().getTime()));
                cs.setString("_observacion", lcc.getObservacion());
                cs.setInt("_fid_lote", lote.getIdLote());
                cs.setInt("_fid_criterio_control_calidad", lcc.getCriterioControlCalidad().getIdCriterioControlCalidad());
                resultado = cs.executeUpdate();
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idLote) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall(" { call ELIMINAR_LOTE(?) }");
            cs.setInt("_id_lote", idLote);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Lote> listarLotes() {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LOTE()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Lote lote = new Lote();
                lote.setIdLote(rs.getInt("id_lote"));
                lote.setProveedor(new Proveedor());
                lote.getProveedor().setIdProveedor(rs.getInt("id_proveedor"));
                lote.getProveedor().setRazonSocial(rs.getString("razon_social"));
                lote.setAlmacen(new Almacen());
                lote.getAlmacen().setIdAlmacen(rs.getInt("id_almacen"));
                lote.getAlmacen().setNombre(rs.getString("nombre_almacen"));
                lote.setProducto(new Producto());
                lote.getProducto().setIdProducto(rs.getInt("id_producto"));
                lote.getProducto().setNombre(rs.getString("nombre_producto"));
                lote.setFechaCompra(rs.getDate("fecha_compra"));
                lote.setFechaLlegada(rs.getDate("fecha_llegada"));
                lote.setPeso(rs.getDouble("peso"));
                lote.setObservacion(rs.getString("observacion"));
                lote.setCostoTotal(rs.getDouble("costo_total"));
                lote.setCantidad(rs.getInt("cantidad"));
                lote.setCostoUnitario(rs.getDouble("costo_unitario"));
                lote.setEstado(rs.getInt("estado"));
                lote.setActivo(true);
                lotes.add(lote);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return lotes;
    }
    
    @Override
    public ArrayList<Lote> listarLotesXProveedor(int idProveedor) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LOTE_X_PROVEEDOR(?)}");
            cs.setInt("_id_proveedor", idProveedor);
            rs = cs.executeQuery();
            while(rs.next()){
                Lote lote = new Lote();
                lote.setIdLote(rs.getInt("id_lote"));
                lote.setProveedor(new Proveedor());
                lote.getProveedor().setIdProveedor(rs.getInt("id_proveedor"));
                lote.getProveedor().setRazonSocial(rs.getString("razon_social"));
                lote.setAlmacen(new Almacen());
                lote.getAlmacen().setIdAlmacen(rs.getInt("id_almacen"));
                lote.getAlmacen().setNombre(rs.getString("nombre_almacen"));
                lote.setProducto(new Producto());
                lote.getProducto().setIdProducto(rs.getInt("id_producto"));
                lote.getProducto().setNombre(rs.getString("nombre_producto"));
                lote.setFechaCompra(rs.getDate("fecha_compra"));
                lote.setFechaLlegada(rs.getDate("fecha_llegada"));
                lote.setPeso(rs.getDouble("peso"));
                lote.setObservacion(rs.getString("observacion"));
                lote.setCostoTotal(rs.getDouble("costo_total"));
                lote.setCantidad(rs.getInt("cantidad"));
                lote.setCostoUnitario(rs.getDouble("costo_unitario"));
                lote.setEstado(rs.getInt("estado"));
                lote.setActivo(true);
                lotes.add(lote);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return lotes;
    }

    @Override
    public ArrayList<Lote> listarLotesXFechaCompra(Date fechaInicio, Date fechaFin) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LOTE_X_FECHA_COMPRA(?,?)}");
            cs.setDate("_fecha_inicio", new java.sql.Date(fechaInicio.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fechaFin.getTime()));
            rs = cs.executeQuery();
            while(rs.next()){
                Lote lote = new Lote();
                lote.setIdLote(rs.getInt("id_lote"));
                lote.setProveedor(new Proveedor());
                lote.getProveedor().setIdProveedor(rs.getInt("id_proveedor"));
                lote.getProveedor().setRazonSocial(rs.getString("razon_social"));
                lote.setAlmacen(new Almacen());
                lote.getAlmacen().setIdAlmacen(rs.getInt("id_almacen"));
                lote.getAlmacen().setNombre(rs.getString("nombre_almacen"));
                lote.setProducto(new Producto());
                lote.getProducto().setIdProducto(rs.getInt("id_producto"));
                lote.getProducto().setNombre(rs.getString("nombre_producto"));
                lote.setFechaCompra(rs.getDate("fecha_compra"));
                lote.setFechaLlegada(rs.getDate("fecha_llegada"));
                lote.setPeso(rs.getDouble("peso"));
                lote.setObservacion(rs.getString("observacion"));
                lote.setCostoTotal(rs.getDouble("costo_total"));
                lote.setCantidad(rs.getInt("cantidad"));
                lote.setCostoUnitario(rs.getDouble("costo_unitario"));
                lote.setEstado(rs.getInt("estado"));
                lote.setActivo(true);
                lotes.add(lote);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return lotes;
    }

    @Override
    public ArrayList<Lote> listarLotesXFechaLlegada(Date fechaInicio, Date fechaFin) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LOTE_X_FECHA_LLEGADA(?,?)}");
            cs.setDate("_fecha_inicio", new java.sql.Date(fechaInicio.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fechaFin.getTime()));
            rs = cs.executeQuery();
            while(rs.next()){
                Lote lote = new Lote();
                lote.setIdLote(rs.getInt("id_lote"));
                lote.setProveedor(new Proveedor());
                lote.getProveedor().setIdProveedor(rs.getInt("id_proveedor"));
                lote.getProveedor().setRazonSocial(rs.getString("razon_social"));
                lote.setAlmacen(new Almacen());
                lote.getAlmacen().setIdAlmacen(rs.getInt("id_almacen"));
                lote.getAlmacen().setNombre(rs.getString("nombre_almacen"));
                lote.setProducto(new Producto());
                lote.getProducto().setIdProducto(rs.getInt("id_producto"));
                lote.getProducto().setNombre(rs.getString("nombre_producto"));
                lote.setFechaCompra(rs.getDate("fecha_compra"));
                lote.setFechaLlegada(rs.getDate("fecha_llegada"));
                lote.setPeso(rs.getDouble("peso"));
                lote.setObservacion(rs.getString("observacion"));
                lote.setCostoTotal(rs.getDouble("costo_total"));
                lote.setCantidad(rs.getInt("cantidad"));
                lote.setCostoUnitario(rs.getDouble("costo_unitario"));
                lote.setEstado(rs.getInt("estado"));
                lote.setActivo(true);
                lotes.add(lote);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return lotes;
    }

    @Override
    public ArrayList<Lote> listarLotesXIDProveedorAlmacen(String idProveedorAlmacen) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LOTE_X_IDLOTE_PROVEEDOR_ALMACEN(?)}");
            cs.setString("_idlote_proveedor_almacen", idProveedorAlmacen);
            rs = cs.executeQuery();
            while(rs.next()){
                Lote lote = new Lote();
                lote.setIdLote(rs.getInt("id_lote"));
                lote.setProveedor(new Proveedor());
                lote.getProveedor().setIdProveedor(rs.getInt("id_proveedor"));
                lote.getProveedor().setRazonSocial(rs.getString("razon_social"));
                lote.setAlmacen(new Almacen());
                lote.getAlmacen().setIdAlmacen(rs.getInt("id_almacen"));
                lote.getAlmacen().setNombre(rs.getString("nombre_almacen"));
                lote.setProducto(new Producto());
                lote.getProducto().setIdProducto(rs.getInt("id_producto"));
                lote.getProducto().setNombre(rs.getString("nombre_producto"));
                lote.setFechaCompra(rs.getDate("fecha_compra"));
                lote.setFechaLlegada(rs.getDate("fecha_llegada"));
                lote.setPeso(rs.getDouble("peso"));
                lote.setObservacion(rs.getString("observacion"));
                lote.setCostoTotal(rs.getDouble("costo_total"));
                lote.setCantidad(rs.getInt("cantidad"));
                lote.setCostoUnitario(rs.getDouble("costo_unitario"));
                lote.setEstado(rs.getInt("estado"));
                lote.setActivo(true);
                lotes.add(lote);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return lotes;
    }
}