namespace Synorvia.FileAccess.Contracts
{
    public interface IFileSaver
    {
        bool ShowFileSaveDialog(out string selectedFilename, string defaultFielname = "",
                                string defaultFileExtension = "",
                                string initialDirectory = "",
                                string filter = "All Files (*.*)|*.*",
                                string title = "Save file...");

        void WriteDataToFile(string filename, byte[] data);
    }
}
