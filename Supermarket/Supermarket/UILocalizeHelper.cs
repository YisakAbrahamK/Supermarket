using Sunny.UI;

public static class UILocalizeHelper
{
    public static void SetEN()
    {
        UILocalize.InfoTitle = "Info";
        UILocalize.SuccessTitle = "Success";
        UILocalize.WarningTitle = "Warning";
        UILocalize.ErrorTitle = "Error";
        UILocalize.AskTitle = "Query";
        UILocalize.InputTitle = "Input";
        UILocalize.CloseAll = "Close all";
        UILocalize.OK = "OK";
        UILocalize.Cancel = "Cancel";
        UILocalize.GridNoData = "[ No data ]";
        UILocalize.GridDataLoading = "Data loading ......";
        UILocalize.GridDataSourceException = "The data source must be DataTable or List";
    }

    public static void SetCH()
    {
        UILocalize.InfoTitle = "提示";
        UILocalize.SuccessTitle = "正确";
        UILocalize.WarningTitle = "警告";
        UILocalize.ErrorTitle = "错误";
        UILocalize.AskTitle = "提示";
        UILocalize.InputTitle = "输入";
        UILocalize.CloseAll = "全部关闭";
        UILocalize.OK = "确定";
        UILocalize.Cancel = "取消";
        UILocalize.GridNoData = "[ 无数据 ]";
        UILocalize.GridDataLoading = "数据加载中 ......";
        UILocalize.GridDataSourceException = "数据源必须为DataTable或者List";
    }
}