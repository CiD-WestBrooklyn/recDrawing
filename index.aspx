<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Drawing.index.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img runat="server" id="imgCtrl" />

        <br />
        
        <asp:Button
    runat="server"
    ID="btNew"
    OnClick="ButtonNew_Click"
    Text="Zeichnen" />
        <br />
      Tiefe:   <asp:textbox id="input_tiefe" runat="server"/>
                <asp:RangeValidator id="valRange" runat="server"
                    ControlToValidate="input_tiefe"
                     MaximumValue="10000"
                     MinimumValue="1"
                    Type="Integer"
                    ErrorMessage="Bitte eine Zahl angeben"
                    Display="static">*</asp:RangeValidator>
        <br />
              Weite:   <asp:textbox id="input_weite" runat="server"/>
                <asp:RangeValidator id="RangeValidator1" runat="server"
                    ControlToValidate="input_weite"
                     MaximumValue="10000"
                     MinimumValue="1"
                    Type="Integer"
                    ErrorMessage="Bitte eine Zahl angeben"
                    Display="static">*</asp:RangeValidator>
        <br />
            
            Bild-Weite:  <asp:textbox id="input_bild_weite" runat="server"/>
                <asp:RangeValidator id="RangeValidator2" runat="server"
                    ControlToValidate="input_bild_weite"
                     MaximumValue="10000"
                     MinimumValue="1"
                    Type="Integer"
                    ErrorMessage="Bitte eine Zahl angeben"
                    Display="static">*</asp:RangeValidator>
        <br />
             Bild-Höhe:  <asp:textbox id="input_bild_hoehe" runat="server"/>
                <asp:RangeValidator id="RangeValidator3" runat="server"
                    ControlToValidate="input_bild_hoehe"
                     MaximumValue="10000"
                     MinimumValue="1"
                    Type="Integer"
                    ErrorMessage="Bitte eine Zahl angeben"
                    Display="static">*</asp:RangeValidator>
            

    </div>
    </form>
</body>
</html>
