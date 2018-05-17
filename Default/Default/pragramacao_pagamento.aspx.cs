﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Default
{
    public partial class pragramacao_pagamento : System.Web.UI.Page
    {
        private bancodadosinterEntities1 entities = new bancodadosinterEntities1();

        //private List<programacao_pagamento> lista;

        public void limparCampos()
        {
            txt_DataVencimento.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Sair_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btn_Voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("obs_gerente.aspx");
        }

        protected void btn_Limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        protected void btn_Concluir_Click(object sender, EventArgs e)
        {
            if (txt_IDpag.Text == string.Empty)
            {
                //novo registro
                programacao_pagamento p = new programacao_pagamento();
                p.cnpj = txt_CNPJ.Text;
                p.ie = txt_IE.Text;
                p.data_emissao = Convert.ToDateTime(txt_DataEmissao.Text.ToString());
                p.numero = txt_Numero.Text;
                p.serie = txt_Serie.Text;
                p.data_entrada = Convert.ToDateTime(txt_DataEntrada.Text.ToString());
                p.data_vencimento = Convert.ToDateTime(txt_DataVencimento.Text.ToString());
                p.total = Convert.ToDecimal(txt_Total.Text.ToString());
                entities.programacao_pagamento.Add(p);
            }
            entities.SaveChanges();
            Response.Redirect("pos_login.aspx");
        }

    }
}