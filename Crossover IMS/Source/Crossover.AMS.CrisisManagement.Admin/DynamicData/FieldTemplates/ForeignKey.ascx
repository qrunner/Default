﻿<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="Crossover.AMS.CrisisManagement.Admin.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

