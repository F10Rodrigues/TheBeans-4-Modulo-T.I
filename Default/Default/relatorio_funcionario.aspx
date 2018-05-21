﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="relatorio_funcionario.aspx.cs" Inherits="Default.relatorio_funcionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btn_voltar" runat="server" Text="Voltar" OnClick="btn_voltar_Click" />
    <asp:Button ID="btn_sair" runat="server" Text="SAIR" OnClick="btn_sair_Click" /><br /><br />
    <asp:GridView ID="grid_funcionario" runat="server" Width="1043px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField HeaderText="NOME" DataField="nome" />
            <asp:BoundField HeaderText="CPF" DataField="cpf" />
            <asp:BoundField DataField="ctps" HeaderText="CTPS" />
            <asp:BoundField HeaderText="R.G." DataField="rg" />
            <asp:BoundField HeaderText="CELULAR" DataField="celular" />
<asp:BoundField HeaderText="ENDEREÇO" DataField="endereco"></asp:BoundField>
            <asp:BoundField DataField="numero" HeaderText="NUMERO" />
            <asp:BoundField DataField="bairro" HeaderText="BAIRRO" />
            <asp:BoundField DataField="cidade" HeaderText="CIDADE" />
            <asp:BoundField HeaderText="EMAIL" DataField="email" />
            <asp:BoundField DataField="estado" HeaderText="ESTADO" />
        </Columns>
    </asp:GridView><br /><br />
    </asp:Content>
