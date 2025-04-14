<%@ Page Title="Lista de Resultados" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultado01.aspx.cs" Inherits="TestWeb_WCF_CheckSalud.Resultado01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        #mainContainer {
            margin: 0 !important;
            padding: 0 !important;
            width: 100% !important;
        }
        
        .container-fluid {
            padding: 0 !important;
            margin: 0 !important;
        }

        .row {
            margin: 0 !important;
        }

        .col-12 {
            padding: 0 !important;
        }

        .table-container {
            padding-left: 20px !important;
            padding-right: 20px !important;
        }

        .table {
            width: 100%;
            margin: 0 !important;
            padding: 0 !important;
            font-size: 0.8em;
        }
        
        .table th, .table td {
            padding: 5px !important;
        }

        .btn-edit, .btn-delete {
            width: 70px; /* Ajusta el ancho según tus necesidades */
        }
    </style>
    <div class="container-fluid p-0 table-container">
        <div class="row m-0 mb-3">
            <div class="col-8">
                <br />
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control d-inline-block" Placeholder="Buscar por paciente" style="width: calc(100% - 120px);"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-primary d-inline-block" style="width: 100px; margin-left: 10px;" />
            </div>
            <div class="col-4 text-right">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblTotalResultados" runat="server" CssClass="form-label"></asp:Label>
            </div>
        </div>
        <div class="row m-0">
            <div class="col-12 p-0">
                <br />
                <asp:GridView ID="gvResultados" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered">
                    <Columns>
                        <asp:BoundField DataField="codResultado" HeaderText="Código" />
                        <asp:BoundField DataField="NomApePaciente" HeaderText="Paciente" />
                        <asp:BoundField DataField="fecNac" HeaderText="Fecha Nacimiento" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="False" />
                        <asp:BoundField DataField="edad" HeaderText="Edad" />
                        <asp:BoundField DataField="lugarTrabajo" HeaderText="Lugar de Trabajo" />
                        <asp:BoundField DataField="tipoExamen" HeaderText="Tipo de Examen" />
                        <asp:BoundField DataField="fechaEvaluacion" HeaderText="Fecha de Evaluación" />
                        <asp:BoundField DataField="peso" HeaderText="Peso" />
                        <asp:BoundField DataField="altura" HeaderText="Altura" />
                        <asp:BoundField DataField="sangre" HeaderText="Sangre" />
                        <asp:BoundField DataField="orina" HeaderText="Orina" />
                        <asp:BoundField DataField="ekg" HeaderText="EKG" />
                        <asp:BoundField DataField="spirometria" HeaderText="Espirometría" />
                        <asp:BoundField DataField="psicologia" HeaderText="Psicología" />
                        <asp:BoundField DataField="rayosX" HeaderText="Rayos X" />
                        <asp:BoundField DataField="audicion" HeaderText="Audición" />
                        <asp:BoundField DataField="vista" HeaderText="Vista" />
                        <asp:BoundField DataField="enfermedad" HeaderText="Enfermedad" />
                        <asp:BoundField DataField="recomendaciones" HeaderText="Recomendaciones" />
                        <asp:BoundField DataField="Evaluador" HeaderText="Evaluador" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandArgument='<%# Eval("codResultado") %>' OnClick="btnEditar_Click" CssClass="btn btn-primary btn-sm btn-edit" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# Eval("codResultado") %>' OnClick="btnEliminar_Click" CssClass="btn btn-danger btn-sm btn-delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
</asp:Content>