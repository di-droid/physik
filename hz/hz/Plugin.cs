using System;
using System.Collections.Generic;
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
                    Assembly plugin = Assembly.LoadFrom(openFile.FileName);
                    Type[] types = plugin.GetTypes();

                    foreach (Type currentPlugin in types)
                    {
                        foreach (Attribute attribute in currentPlugin.GetCustomAttributes())
                        {
                            if (attribute is FactoryAttribute factoryAttribute)
                            {
                                pluginDict.Add(factoryAttribute.ToolName, currentPlugin);
                                name = factoryAttribute.ToolName;
                            }
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
