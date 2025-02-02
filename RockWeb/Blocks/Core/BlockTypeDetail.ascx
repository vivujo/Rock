﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BlockTypeDetail.ascx.cs" Inherits="RockWeb.Blocks.Core.BlockTypeDetail" %>

<asp:UpdatePanel ID="upPanel" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlDetails" CssClass="panel panel-block" runat="server" Visible="false">

            <asp:HiddenField ID="hfBlockTypeId" runat="server" />

            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-square"></i>
                    <asp:Literal ID="lActionTitle" runat="server" /></h1>
            </div>
            <Rock:PanelDrawer ID="pdAuditDetails" runat="server"></Rock:PanelDrawer>
            <div class="panel-body">
                <Rock:NotificationBox ID="nbEditModeMessage" runat="server" NotificationBoxType="Info" />
                <asp:ValidationSummary ID="vsDetails" runat="server" HeaderText="Please correct the following:" CssClass="alert alert-validation" />
                <Rock:NotificationBox ID="nbWarningMessage" runat="server" NotificationBoxType="Warning" />

                <asp:Panel ID="pnlReadOnly" runat="server">
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Literal ID="lReadonlySummary" runat="server" />
                            <Rock:RockLiteral ID="lblStatus" runat="server" Label="Status" />
                            <Rock:RockLiteral ID="lPages" runat="server" Label="Pages that use this block type" />
                            <Rock:RockLiteral ID="lLayout" runat="server" Label="Layouts that use this block type" Visible="False" />
                            <Rock:RockLiteral ID="lSites" runat="server" Label="Sites that use this block type" Visible="False" />
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlEdit" runat="server">
                    <div class="row">
                        <div class="col-md-12">
                            <Rock:DataTextBox ID="tbName" runat="server" SourceTypeName="Rock.Model.BlockType, Rock" PropertyName="Name" Label="Name" />
                            <Rock:DataTextBox ID="tbDescription" runat="server" SourceTypeName="Rock.Model.BlockType, Rock" PropertyName="Description" TextMode="MultiLine" Rows="4" />
                            <Rock:DataTextBox ID="tbPath" runat="server" SourceTypeName="Rock.Model.BlockType, Rock" PropertyName="Path" CssClass="input-xlarge" />
                        </div>
                    </div>
                </asp:Panel>


                <div class="actions">
                    <asp:LinkButton ID="btnEdit" runat="server" data-shortcut-key="e" AccessKey="m" ToolTip="Alt+e" Text="Edit" CssClass="btn btn-primary" CausesValidation="false" OnClick="btnEdit_Click" />
                    <asp:LinkButton ID="btnSave" runat="server" data-shortcut-key="s" ToolTip="Alt+s" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
                    <asp:LinkButton ID="btnCancel" runat="server" data-shortcut-key="c" ToolTip="Alt+c" Text="Cancel" CssClass="btn btn-link" CausesValidation="false" OnClick="btnCancel_Click" />
                </div>

            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>

