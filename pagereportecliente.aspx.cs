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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var conn = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=clientes;Integrated Security=True");
        try
        {
            using (var comando = new SqlCommand("SELECT TOP 1000 [idcliente] ,[nombre]  ,[apellidos]  ,[direccion] ,[telefono] FROM[clientes].[dbo].[cliente]", conn))
            {
                using (var adaptador = new SqlDataAdapter(comando))
                {
                    var ds = new DataSet();
                    adaptador.Fill(ds);

                    var reporte = new ReportDocument();
                    reporte.Load(Server.MapPath("Reportes/CrystalReport.rpt"));
                    reporte.SetDataSource(ds.Tables[0]);
                    reporte.DataSourceConnections[0].SetConnection("LENOVO-PC", "Clientes", "sa", "12345");

                 CrystalReportViewer1.ReportSource = reporte;
                } // end using adaptador
            } // end using comando
        } // end try
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
        finally
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
            conn.Dispose();

        }
    }
}