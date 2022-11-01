<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="ServisYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.ServisYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 45px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Servis Yönetimi</h1>
    <div>
        <asp:GridView ID="dgvServisler" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvServisler_SelectedIndexChanged" >
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
    <div>

        <table class="auto-style1">
            <tr>
                <td>Giriş Tarihi</td>
                <td>
                    <asp:Calendar ID="dtpServiseGelisTarihi" runat="server" Width="150px"></asp:Calendar>
                    <br />
                </td>
                <td>Çıkış Tarihi</td>
                <td>
                    <asp:Calendar ID="dtpServistenCikisTarihi" runat="server" Width="150px"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>Araç Sorunu</td>
                <td>
                    <asp:TextBox ID="txtAracSorunu" runat="server" TextMode="MultiLine" Width="187px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAracSorunu" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                </td>
                <td>Yapılan İşlemler</td>
                <td>
                    <asp:TextBox ID="txtYapilanİslemler" runat="server" TextMode="MultiLine" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Servis Ücreti</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtServisUcreti" runat="server" Width="189px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtServisUcreti" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                </td>
                <td class="auto-style2">Araç Marka</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMarka" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Araç Plaka</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtAracPlaka" runat="server" Width="189px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAracPlaka" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">Model</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtModel" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBox ID="cbGaranti" runat="server" Text="Garanti Kapsamında Mı?" />
                </td>
                <td>Kasa Tipi</td>
                <td>
                    <asp:TextBox ID="txtKasaTipi" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Notlar</td>
                <td>
                    <asp:TextBox ID="txtNotlar" runat="server" TextMode="MultiLine" Width="187px"></asp:TextBox>
                </td>
                <td>Şase No</td>
                <td>
                    <asp:TextBox ID="txtSaseNo" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
                    <asp:Button ID="btnGuncelle" runat="server" Text="Guncelle" OnClick="btnGuncelle_Click"  />
                    <asp:Button ID="btnSil" runat="server" Text="Sil" OnClick="btnSil_Click" ValidationGroup="Sil" />
                </td>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
