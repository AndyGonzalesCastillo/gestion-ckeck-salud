<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultado02.aspx.cs" Inherits="TestWeb_WCF_CheckSalud.Resultado02" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>&nbsp;</p>
    <h1>Ingresar Resultado</h1>
    <table class="table table-borderless" style="width: 97%">
        <tr>
            <td style="width: 289px; height: 22px">&nbsp;Peso:&nbsp;
<asp:TextBox ID="txtPeso" runat="server" Width="93px"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="meePeso" runat="server" TargetControlID="txtPeso" Mask="99.9" MessageValidatorTip="true" MaskType="Number" />            </td>
            <td style="width: 283px; height: 22px">Altura:&nbsp;
                 <asp:TextBox ID="txtAltura" runat="server" Width="87px"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="meeAltura" runat="server" TargetControlID="txtAltura" Mask="9.99" MessageValidatorTip="true" MaskType="Number" />
            </td>
            <td style="width: 203px; height: 22px">&nbsp;</td>
            <td style="height: 22px; width: 218px">Paciente:</td>
            <td style="height: 22px; width: 244px;">
                <asp:DropDownList ID="cbocodPaciente" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 289px">Sangre:</td>
            <td style="width: 283px" class="modal-sm">
                <asp:DropDownList ID="cboSangre" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td style="width: 203px" class="modal-sm">
                &nbsp;</td>
            <td class="modal-sm" style="width: 218px">Rayos X:</td>
            <td style="width: 244px">
                <asp:DropDownList ID="cboRayosX" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 289px">Orina:</td>
            <td style="width: 283px" class="modal-sm">
                <asp:DropDownList ID="cboOrina" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td style="width: 203px" class="modal-sm">
                &nbsp;</td>
            <td class="modal-sm" style="width: 218px">Audicion:</td>
            <td style="width: 244px">
                <asp:DropDownList ID="cboAudicion" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 289px">Espirometria: </td>
            <td style="width: 283px" class="modal-sm">
                <asp:DropDownList ID="cboEspirometria" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td style="width: 203px" class="modal-sm">
                &nbsp;</td>
            <td class="modal-sm" style="width: 218px">Vista:</td>
            <td style="width: 244px">
                <asp:DropDownList ID="cboVista" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 289px">Psicologia:</td>
            <td style="width: 283px" class="modal-sm">
                <asp:DropDownList ID="cboPsicologia" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td style="width: 203px" class="modal-sm">
                &nbsp;</td>
            <td class="modal-sm" style="width: 218px">Ekg:</td>
            <td style="width: 244px">
                <asp:DropDownList ID="cboEkg" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 289px">Fecha de Evaluacion:</td>
            <td style="width: 283px" class="modal-sm">
                <asp:TextBox ID="txtFechaEval" runat="server" Width="205px"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="ceFechaEval" runat="server" TargetControlID="txtFechaEval" Format="dd/MM/yyyy" />
           
            </td>
            <td style="width: 203px" class="modal-sm">
                &nbsp;</td>
            <td class="modal-sm" style="width: 218px">Enfermedad:</td>
            <td style="width: 244px">
                <asp:DropDownList ID="cbocodEnfermedad" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 289px; height: 20px">Recomendaciones:</td>
            <td colspan="4" style="height: 20px">
                <asp:TextBox ID="txtRecomendaciones" runat="server" Height="70px" Width="522px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 289px">Medico que realizo los examenes:</td>
            <td style="width: 283px" class="modal-sm">
                <asp:DropDownList ID="cboMedico" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td style="width: 203px" class="modal-sm">
                &nbsp;</td>
            <td class="modal-sm" style="width: 218px">Medico que realizo la evaluacion:</td>
            <td style="width: 244px">
                <asp:DropDownList ID="cboAuditor" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="5">Costo:&nbsp;
                <asp:TextBox ID="txtCosto" runat="server" Width="99px"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="meeCosto" runat="server" TargetControlID="txtCosto" Mask="999.99" MessageValidatorTip="true" MaskType="Number" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <asp:Button ID="btnAgregar" class="btn btn-primary" runat="server" Text="AGREGAR" Width="98px" OnClick="btnAgregar_Click" />
                &nbsp;&nbsp;&nbsp;<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                </td>
            <td style="width: 203px">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>
    &nbsp;&nbsp;
    <br />
</asp:Content>