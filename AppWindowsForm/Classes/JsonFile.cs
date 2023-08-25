using System.IO;
using System.Windows.Forms;

namespace AppWindowsForm
{
    internal class JsonFile
    {
        public static string Data { get; set; }

        public static OpenFileDialog Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open Json File";
            openFileDialog.DefaultExt = "json";
            openFileDialog.Filter = "json files (*.json)|*.json";

            return openFileDialog;
        }

        public static void Save(string newData)
        {
            File.WriteAllText(Data, newData);
        }
    }
}
