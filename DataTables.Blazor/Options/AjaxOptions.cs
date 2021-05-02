﻿using DataTables.Blazor.Interop;

namespace DataTables.Blazor.Options
{
    /// <summary>
    /// Represents the ajax options for a DataTable. See <a href="https://datatables.net/reference/option/ajax">DataTables Reference</a> for more info.
    /// </summary>
    public class AjaxOptions
    {
        public AjaxOptions(string source)
        {
            Url = source;
        }

        public string Url { get; set; }

        public JavaScriptFunction Data { get; set; }

        public JavaScriptFunction DataSrc { get; set; }
    }
}
