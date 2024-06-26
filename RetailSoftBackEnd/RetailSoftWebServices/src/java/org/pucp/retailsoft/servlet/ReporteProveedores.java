package org.pucp.retailsoft.servlet;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JREmptyDataSource;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import org.pucp.retailsoft.config.DBManager;

@WebServlet(name = "ReporteProveedores", urlPatterns = {"/ReporteProveedores"})
public class ReporteProveedores extends HttpServlet {
    
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        try{
            Connection con = DBManager.getInstance().getConnection();
            JasperReport jr = (JasperReport) JRLoader.loadObject(
              ReporteProveedores.class.getResource("/org/pucp/retailsoft/reportes/ReporteProveedores.jasper"));
            
            String rutaImagen = ReporteProveedores.class.getResource("/org/pucp/retailsoft/img/logoRIG.png").getPath();
            Image img = (new ImageIcon(rutaImagen)).getImage();
            String rutaSubreporte = ReporteProveedores.class.getResource(
                        "/org/pucp/retailsoft/reportes/SubreporteLotes.jasper").getPath();
            
            HashMap hm = new HashMap();
            hm.put("logo",img);
            hm.put("rutaSubreporte",rutaSubreporte);
            
            JasperPrint jp = JasperFillManager.fillReport(jr, hm, con);
            con.close();
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
