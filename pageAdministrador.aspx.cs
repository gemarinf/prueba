using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageAdministrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnagregar_Click(object sender, EventArgs e)
    {
        try
        {
            clsadministrador clte = new clsadministrador(0, "", "");
            clte.Identificacion = int.Parse(txtidentificacion.Text.Trim());
            clte.Nombre = txtnombre.Text;
            clte.Telefono = txttelefono.Text;
            clte.agregar();
            lblestado.Text = "Registro Agregado con exito";
            txtidentificacion.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
        }
        catch
        {
            lblestado.Text = "Se ha generado una excepción";
        }
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        clsadministrador clte = new clsadministrador(0, "", "");
        if (clte.eliminar(int.Parse(txtidentificacion.Text)))
        {
            lblestado.Text = "El registro se eliminó con exito";
            txtidentificacion.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
        }
        else { lblestado.Text = "El registro No se eliminó"; }
    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        clsadministrador clte = new clsadministrador (0, "", "");
        if (clte.existe(int.Parse(txtidentificacion.Text)))
        {
            txtidentificacion.Text = clte.Identificacion.ToString();
            txtnombre.Text = clte.Nombre;
            txttelefono.Text = clte.Telefono;
            lblestado.Text = "Registro encontrado";
        }
        else
        {
            lblestado.Text = "Registro no Encontrado";
        }
    }

    protected void drpClientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        clsadministrador clte = new clsadministrador(0, "", "");
        if (clte.existe(int.Parse(drpClientes.SelectedValue)))
        {
            txtidentificacion.Text = clte.Identificacion.ToString();
            txtnombre.Text = clte.Nombre;
            txttelefono.Text = clte.Telefono;
            lblestado.Text = "Registro encontrado";
        }
        else
        {
            lblestado.Text = "Registro no Encontrado";
        }
    }
}

