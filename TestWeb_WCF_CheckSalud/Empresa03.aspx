<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empresa03.aspx.cs" Inherits="TestWeb_WCF_CheckSalud.Empresa03" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }

        function validateForm() {
            var razonSocial = document.getElementById('<%= txtRazonSocial.ClientID %>').value.trim();
            var direccion = document.getElementById('<%= txtDireccion.ClientID %>').value.trim();
            var telefono = document.getElementById('<%= txtTelefono.ClientID %>').value.trim();
            var ruc = document.getElementById('<%= txtRuc.ClientID %>').value.trim();
            var representante = document.getElementById('<%= txtRepresentante.ClientID %>').value.trim();
            var distrito = document.getElementById('<%= ddlUbigeo.ClientID %>').value;

            if (!razonSocial || !direccion || !telefono || !ruc || !representante) {
                showAlert('Debe completar todos los campos');
                return false;
            }

            if (ruc.length !== 11) {
                showAlert('El RUC debe tener 11 dígitos');
                return false;
            }

            if (distrito === "0") {
                showAlert('Debe seleccionar un distrito');
                return false;
            }

            return true;
        }

        function showAlert(message) {
            var alertDiv = document.createElement('div');
            alertDiv.style.position = 'fixed';
            alertDiv.style.top = '50%';
            alertDiv.style.left = '50%';
            alertDiv.style.transform = 'translate(-50%, -50%)';
            alertDiv.style.padding = '20px';
            alertDiv.style.backgroundColor = '#f8d7da';
            alertDiv.style.border = '1px solid #f5c6cb';
            alertDiv.style.color = '#721c24';
            alertDiv.style.zIndex = '10000';
            alertDiv.innerText = message;

            document.body.appendChild(alertDiv);

            setTimeout(function () {
                document.body.removeChild(alertDiv);
            }, 3000);
        }
    </script>

    <div>
        <asp:Label ID="lblCodigo" class="fw-bold" runat="server" Text="Código: " />
        <asp:Label ID="lblCodigoValue" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblRazonSocial" class="fw-bold" runat="server" Text="Razón Social: " />
        <asp:TextBox ID="txtRazonSocial" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblDireccion" class="fw-bold" runat="server" Text="Dirección: " />
        <asp:TextBox ID="txtDireccion" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblTelefono" class="fw-bold" runat="server" Text="Teléfono: " />
        <asp:TextBox ID="txtTelefono" runat="server" MaxLength="9" onkeypress="return isNumberKey(event)" />
        <br />
        <br />
        <asp:Label ID="lblRuc" class="fw-bold" runat="server" Text="RUC: " />
        <asp:TextBox ID="txtRuc" runat="server" MaxLength="11" onkeypress="return isNumberKey(event)" />
        <br />
        <br />
        <asp:Label ID="lblRepresentante" class="fw-bold" runat="server" Text="Representante: " />
        <asp:TextBox ID="txtRepresentante" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblUbigeo" class="fw-bold" runat="server" Text="Distrito: " />
        <asp:DropDownList ID="ddlUbigeo" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblEstado" class="fw-bold" runat="server" Text="Estado: " />
        <asp:DropDownList ID="ddlEstado" runat="server">
            <asp:ListItem Value="1">Activo</asp:ListItem>
            <asp:ListItem Value="0">Inactivo</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardar" class="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click" OnClientClick="return validateForm();" />
        &nbsp;
        <asp:Button ID="btnCancelar" class="btn btn-danger" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    </div>
</asp:Content>
