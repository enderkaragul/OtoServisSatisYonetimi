<%@ Page Title="Araç Yönetimi" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="AracYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.AracYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        
    </style>
</asp:Content>
    
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Araç Yönetimi</h1>
    <div>
        <asp:GridView ID="dgvAraclar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvAraclar_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
    </div>
    <hr />  
    <h1>Araç Bilgileri</h1>
    <table class="auto-style1">
        <tr>
            <td>Marka</td>
            <td>
                <asp:DropDownList ID="ddlMarkalar" runat="server" DataTextField="Adi" DataValueField="Id">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Renk</td>
            <td>
                <asp:TextBox ID="txtRenk" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Fiyat</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtFiyati" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFiyati" ErrorMessage="Fiyat Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>Modeli</td>
            <td>
                <asp:TextBox ID="txtModeli" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Kasa Tipi</td>
            <td>
                <asp:TextBox ID="txtKasaTipi" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Model Yılı</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtModelYili" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtModelYili" ErrorMessage="Model Yılı Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style3"></td>
            <td class="auto-style3">
                <br />
            </td>
        </tr>
        <tr>
            <td>Notlar</td>
            <td>
                <asp:TextBox ID="txtNotlar" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:CheckBox ID="cbSatistaMi" runat="server" Text="Satışta Mı?" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" />
                <asp:Button ID="btnGuncelle" runat="server" OnClick="btnGuncelle_Click" Text="Guncelle" />
                <asp:Button ID="btnSil" runat="server" OnClick="btnSil_Click" Text="Sil" ValidationGroup="sil" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    

</asp:Content>
