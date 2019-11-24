﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagecalculos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btncalcular_Click(object sender, EventArgs e)
    {
        clscalculos calculo = new clscalculos(0, 0, 0);
        if (rdbcalculos.SelectedValue == "1")
        {
            txtresultado.Text = calculo.Suma(double.Parse(txtvalor1.Text), double.Parse(txtvalor2.Text)).ToString();
        }
        else
        {
            if (rdbcalculos.SelectedValue == "2")
            {
                txtresultado.Text = calculo.Resta(double.Parse(txtvalor1.Text), double.Parse(txtvalor2.Text)).ToString();
            }
            else
            {
                if (rdbcalculos.SelectedValue == "3")
                {
                    txtresultado.Text = calculo.Producto(double.Parse(txtvalor1.Text), double.Parse(txtvalor2.Text)).ToString();
                }
                else
                {
                    txtresultado.Text = "0";
                }
            }
        }
    }
}