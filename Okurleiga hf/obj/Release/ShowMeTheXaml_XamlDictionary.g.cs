
using System.Collections.Generic;

namespace ShowMeTheXAML
{
    public static class XamlDictionary
    {
        static XamlDictionary()
        {
            XamlResolver.Set("buttons_1", @"<smtx:XamlDisplay Key=""buttons_1"" Margin=""10 0"" HorizontalAlignment=""Right"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Style=""{StaticResource MaterialDesignFloatingActionButton}"" ToolTip=""MaterialDesignFloatingActionButton"" Width=""25"" Height=""25"" Margin=""10"" VerticalAlignment=""Center"" HorizontalAlignment=""Right"" Background=""Gray"" Click=""Button_Click"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Kind=""Power"" Height=""25"" Width=""25"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
        }
    }
}