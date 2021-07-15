/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package RumahSakit;

import java.sql.Connection;
import java.sql.DriverManager;
import javax.swing.JOptionPane;

/**
 *
 * @author udins
 */
public class koneksi {
    Connection connection;
    
    public Connection getcConnection(){
        try{
            connection = DriverManager.getConnection("jdbc:mysql://localhost/sistem informasi rumah sakit","root","") ;
        }
        catch (Exception e){
            JOptionPane.showMessageDialog(null,"Gagal Koneksi:\n"+e);
        }
        return connection;
        
    }
    
}
