using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagecliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        try
        {
            clscliente clte = new clscliente(0, "", "", "","");
            clte.Idcliente = int.Parse(txtcliente.Text.Trim());
            clte.Nombre = txtnombre.Text;
            clte.Apellidos = txtapellidos.Text;
            clte.Direccion = txtdireccion.Text;
            clte.Telefono = txttelefono.Text;
            clte.agregar();
            lblestado.Text = "Registro Agregado con exito";
            txtcliente.Text = "";
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
        }
        catch
        {
            lblestado.Text = "Se ha generado una excepción";
        }
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        clscliente clte = new clscliente(0, "", "", "","");
        if (clte.eliminar(int.Parse(txtcliente.Text)))
        {
            lblestado.Text = "El registro se eliminó con exito";
            txtcliente.Text = "";
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
        }
        else { lblestado.Text = "El registro No se eliminó"; }
    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
         clscliente clte = new clscliente(0, "", "", "","");
         if (clte.existe(int.Parse(txtcliente.Text)))
        {
            txtcliente.Text = clte.Idcliente.ToString();
            txtdireccion.Text = clte.Direccion;
            txtnombre.Text = clte.Nombre;
            txtapellidos.Text = clte.Apellidos;
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
        clscliente clte = new clscliente(0, "", "", "","");
        if (clte.existe(int.Parse(drpClientes.SelectedValue)))
        {
            txtcliente.Text = clte.Idcliente.ToString();
            txtdireccion.Text = clte.Direccion;
            txtnombre.Text = clte.Nombre;
            txtapellidos.Text = clte.Apellidos;
            txttelefono.Text = clte.Telefono;
            lblestado.Text = "Registro encontrado";
        }
        else
        {
            lblestado.Text = "Registro no Encontrado";
        }
    }
}

