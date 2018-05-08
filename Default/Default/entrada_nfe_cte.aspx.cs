﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Default
{
    public partial class entrada_nfe_cte : System.Web.UI.Page
    {

        private bancodadosinterEntities1 entities = new bancodadosinterEntities1();

        public void LimparCampos()
        {
            //limpar todos os campos da capa NFe
            txtIDNFe.Text = string.Empty;  
            txt_chave.Text = string.Empty;
            txt_base_calc_icms.Text = string.Empty;
            txt_base_calc_st.Text = string.Empty;
            txt_cnpj.Text = string.Empty;
            txt_data_emissao.Text = string.Empty;
            txt_data_entrada.Text = string.Empty;
            txt_desconto.Text = string.Empty;
            txt_frete_nf.Text = string.Empty;
            txt_ie.Text = string.Empty;
            txt_ipi.Text = string.Empty;
            txt_numero.Text = string.Empty;
            txt_serie.Text = string.Empty;
            txt_total.Text = string.Empty;
            txt_valor_icms.Text = string.Empty;
            txt_valor_st.Text = string.Empty;
            txt_vlor_produtos.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        protected void btn_sair_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("pos_login.aspx");
        }

        public void carregaGrid()
        {
            List<NFe> lista = entities.NFe.ToList();
            grid_NFe.DataSource = lista;
            //grid_NFe.DataBind();
        }

        protected void btn_concluir_Click(object sender, EventArgs e)
        {
            if(txtIDNFe.Text == string.Empty)
            {
                NFe n = new NFe();
                n.chave_acesso = txt_chave.Text;
                n.cnpj = txt_cnpj.Text;
                n.ie = txt_ie.Text;
                n.data_emissao = Convert.ToDateTime(txt_data_emissao.Text);
                n.numero = Convert.ToInt32(txt_numero.Text);
                n.serie = txt_serie.Text;
                n.data_entrada = Convert.ToDateTime(txt_data_entrada.Text);
                n.base_calc_icms = Convert.ToDouble(txt_base_calc_icms.Text);
                n.valor_icms = Convert.ToDouble(txt_valor_icms.Text);
                n.frete_nfe = Convert.ToDouble(txt_frete_nf.Text);
                n.desconto = Convert.ToDouble(txt_desconto.Text);
                n.base_st = Convert.ToDouble(txt_base_calc_st.Text);
                n.valor_st = Convert.ToDouble(txt_valor_st.Text);
                n.ipi = Convert.ToDouble(txt_ipi.Text);
                n.valor_produtos = Convert.ToDouble(txt_vlor_produtos.Text);
                n.total = Convert.ToDouble(txt_total.Text);
                entities.NFe.Add(n);
            }
            else
            {
                NFe n = entities.NFe.Find(Convert.ToInt32(txtIDNFe.Text));
                n.chave_acesso = txt_chave.Text;
                n.cnpj = txt_cnpj.Text;
                n.ie = txt_ie.Text;
                n.data_emissao = Convert.ToDateTime(txt_data_emissao.Text);
                n.numero = Convert.ToInt32(txt_numero.Text);
                n.serie = txt_serie.Text;
                n.data_entrada = Convert.ToDateTime(txt_data_entrada.Text);
                n.base_calc_icms = Convert.ToDouble(txt_base_calc_icms.Text);
                n.valor_icms = Convert.ToDouble(txt_valor_icms.Text);
                n.frete_nfe = Convert.ToDouble(txt_frete_nf.Text);
                n.desconto = Convert.ToDouble(txt_desconto.Text);
                n.base_st = Convert.ToDouble(txt_base_calc_st.Text);
                n.valor_st = Convert.ToDouble(txt_valor_st.Text);
                n.ipi = Convert.ToDouble(txt_ipi.Text);
                n.valor_produtos = Convert.ToDouble(txt_vlor_produtos.Text);
                n.total = Convert.ToDouble(txt_total.Text);
                entities.Entry(n);
            }

            entities.SaveChanges();
            carregaGrid();
            LimparCampos();
        }

        protected void grid_NFe_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);
            int idSelect = Convert.ToInt32(grid_NFe.Rows[index].Cells[0].Text.ToString());
            if (e.CommandName.ToString().Equals("btRemover"))
            {
                NFe n = entities.NFe.Find(Convert.ToInt32(idSelect));
                entities.NFe.Remove(n);
                entities.SaveChanges();
                carregaGrid();
            }
            else if (e.CommandName.ToString().Equals("btAlterar"))
            {
                NFe n = entities.NFe.Find(Convert.ToInt32(idSelect));
                txtIDNFe.Text = n.id_nfe.ToString();
                n.chave_acesso = txt_chave.Text;
                n.cnpj = txt_cnpj.Text;
                n.ie = txt_ie.Text;
                n.data_emissao = Convert.ToDateTime(txt_data_emissao.Text);
                n.numero = Convert.ToInt32(txt_numero.Text);
                n.serie = txt_serie.Text;
                n.data_entrada = Convert.ToDateTime(txt_data_entrada.Text);
                n.base_calc_icms = Convert.ToDouble(txt_base_calc_icms.Text);
                n.valor_icms = Convert.ToDouble(txt_valor_icms.Text);
                n.frete_nfe = Convert.ToDouble(txt_frete_nf.Text);
                n.desconto = Convert.ToDouble(txt_desconto.Text);
                n.base_st = Convert.ToDouble(txt_base_calc_st.Text);
                n.valor_st = Convert.ToDouble(txt_valor_st.Text);
                n.ipi = Convert.ToDouble(txt_ipi.Text);
                n.valor_produtos = Convert.ToDouble(txt_vlor_produtos.Text);
                n.total = Convert.ToDouble(txt_total.Text);

            }
        }
    }
}