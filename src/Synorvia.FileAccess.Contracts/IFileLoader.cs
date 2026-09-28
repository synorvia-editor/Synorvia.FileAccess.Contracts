namespace Synorvia.FileAccess.Contracts
{
    public interface IFileLoader
    {
        bool ShowOpenFileDialog(out string selectedFilename, string defaultFielname = "",
                                string defaultFileExtension = "",
                                string initialDirectory = "",
                                string filter = "All Files (*.*)|*.*",
                                string title = "Open file...");

        byte[] ReadDataFromFile(string filename);
    }
}
