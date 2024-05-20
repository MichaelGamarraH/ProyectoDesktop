package org.pucp.retailsoft.config;

import java.sql.Connection;
import java.sql.DriverManager;

public class DBManager {
    private Connection con;
    private static DBManager dbManager;
    private String url = "jdbc:mysql://"+
            "retailsoftdb.c5nbddepyjkb.us-east-1.rds.amazonaws.com" 
            + ":3306/" + "retailSoft?useSSL=false";
    private String username = "admin";
    private String password = "lp2TASoft9185";
    
    public Connection getConnection(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url, username, password);     
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
}
