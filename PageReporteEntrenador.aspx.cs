using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Drawing;
using CrystalDecisions.Web;
using CrystalDecisions.Shared;



public partial class PageReporteEntrenador : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            clsconexion con = new clsconexion();
            string strConeccion = ConfigurationManager.ConnectionStrings["clientesConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(strConeccion);
            DataSetEntrenador data = new DataSetEntrenador();
            string sql = "SELECT  [identificacion] ,[nombre] ,[telefono]   ,[direccion]  FROM[clientes].[dbo].[entrenador]";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexion);
            adapter.Fill(data.entrenador);

            ReportDocument reporte = new ReportDocument();
            reporte.Load(Server.MapPath("reportes/CrystalReportE.rpt"));
            reporte.SetDataSource(data);
            CrystalReportViewerEntrenador.ReportSource = reporte;
        }
        catch { }

    }
}