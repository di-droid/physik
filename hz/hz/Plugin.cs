using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace hz
{
    public class Plugin
    {
        private Dictionary<string, Type> pluginDict = new Dictionary<string, Type>();

        public string LoadPlugin()
        {
            string name = "";
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = @"File DLL (*.dll)|*.dll"
            };

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    name = Path.GetFileName(openFile.FileName);
                    name = name.Substring(0, name.Length - 4);

                    Assembly plugin = Assembly.LoadFrom(openFile.FileName);
                    Type[] types = plugin.GetTypes();

                    foreach (Type currentPlugin in types)
                    {
                        if (typeof(ICreator).IsAssignableFrom(currentPlugin))
                        {
                            pluginDict.Add(name, currentPlugin); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return name;
        }

        public Type GetType(string pluginName)
        {
            return pluginDict[pluginName];
        }
    }
}
