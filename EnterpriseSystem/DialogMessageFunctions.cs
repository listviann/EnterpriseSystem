namespace EnterpriseSystem
{
    public static class DialogMessageFunctions
    {
        // used for showing models validation error messages in forms
        // this method subscribes to ModelNotify event of Employee and Product classes
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}