using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reporte : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CrystalReport1_Init(object sender, EventArgs e)
    {
        CrystalReport1 objRpt;
        objRpt = new CrystalReport1();


        String ConnStr = @"Data Source=SQLSRV\TuServidor;Initial Catalog=TuBasedeDatos;Persist Security Info=True;User ID=Tuusuario;Password=Tupassword";

        // LA DE ARRIBA ES NUESTRA CADENA DE CONEXION DEL SERVIDOR

        SqlConnection myConnection = new SqlConnection(ConnStr); // TIENEN QUE UTILIZAR EN EL USING LA CLASE DE System.Data.SqlClient

        String Query = "SELECT * FROM EjemploReportes"; // ESTE ES NUESTRO QUERY

        SqlDataAdapter adapter = new SqlDataAdapter(Query, ConnStr);

        Reportes Ds = new Reportes(); // ESTE ES EL NOMBRE DE NUESTRO DATASET
        adapter.Fill(Ds, "Reportes"); // ESTE Reportes ES EL NOMBRE DE NUESTRA TABLA DE DATOS QUE ESTA DENTRO DE NUESTRO DATASET


        objRpt.SetDataSource(Ds); frmReporte rpt = new frmReporte(); // ES EL FORM DONDE ESTA NUESTRO CRYSTAL REPORT VIEWER
        rpt.crystalReportViewer1.ReportSource = objRpt; // ESTE ES NUESTRO REPORT VIEWER
        rpt.ShowDialog(); // AQUI LO MUESTRA
    }
}