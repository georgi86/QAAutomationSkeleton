namespace AutomationTests.Pages.ResizablePage
{
    internal static class Constants
    {
        //// Common
        internal const string RESIZABLE_URL = "http://demoqa.com/resizable/";
        internal const int WAIT_SECCONDS = 20;

        //// Selectors
        internal const string DEFAULT_TAB_SELECTOR = "ui-id-1";                                    //This is a main Tab
        internal const string CONSTRAINT_RESIZE_TAB_SELECTOR = "ui-id-3";                          //This is a main tab
        internal const string MIN_MAX_SIZE_TAB_SELECTOR = "ui-id-5";                               //This is a main tab
        internal const string DEFAULT_RESIZABLE_BOX = "resizable";                                 //This will be use only in the assetrt logic. 
        internal const string DEFAULT_RESIZE_ANGLE = "//*[@id=\"resizable\"]/div[3]";              //This is an lower right angle and will be use for resizing.
        internal const string CONSTRAINT_RESIZABLE_BOX = "resizableconstrain";                     //This will be use only in the assetrt logic.    
        internal const string CONSTRAINT_RESIZE_ANGLE = "//*[@id=\"resizableconstrain\"]/div[3]";  //This is an lower right angle and will be use for resizing.
        internal const string MIN_MAX_RESIZABLE_BOX = "resizable_max_min";                         //This will be use only in the assetrt logic.
        internal const string MIN_MAX_RESIZE_ANGLE = "//*[@id=\"resizable_max_min\"]/div[3]";      //This is an lower right angle and will be use for resizing.
    }
}
