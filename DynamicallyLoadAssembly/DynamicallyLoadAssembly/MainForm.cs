using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection; //Dynamic Load Assembly
using System.IO;
using PluginInterface;

namespace DynamicLoadAssembly
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Dictionary<string, AppDomain> DLLList = new Dictionary<string, AppDomain>();

        private IPlugin LoadAssembly(string assemblyPath)
        {
            string assembly = Path.GetFullPath(assemblyPath);
            Assembly ptrAssembly = Assembly.LoadFile(assembly);

            foreach (Type item in ptrAssembly.GetTypes())
            {
                if (!item.IsClass)
                    continue;
                if (item.GetInterfaces().Contains(typeof(IPlugin)))
                {
                    return (IPlugin)Activator.CreateInstance(item);
                }
            }
            throw new Exception("Invalid DLL, Interface not found!");
        }

        private void UnloadAssembly(IPlugin plugin)
        {
            throw new NotImplementedException("Not implemented. ");
        }

        #region [ Simple Test ]

        private IPlugin ptrPlugin;
        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ptrPlugin = LoadAssembly(".\\Plugins\\Plugin_Sum.dll");
                MessageBox.Show("DLL Loaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load DLL!\n" + ex.ToString());
            }
        }

        private void btUnloadDLL_Click(object sender, EventArgs e)
        {
            UnloadAssembly(ptrPlugin);
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            if (ptrPlugin == null) { MessageBox.Show("DLL not loaded."); return; }
            Debug.WriteLine("DLL Name = " + ptrPlugin.Name);
            Debug.WriteLine("Description = " + ptrPlugin.Description);
            MessageBox.Show("Result = " + ptrPlugin.Execute(40, 29));
        }

        #endregion

        #region [ Advance Test ]

        IPlugin currPlugin;

        private void btRefresh_Click(object sender, EventArgs e)
        {
            //Load Assemblies from Plugin Folder
            cbAssemblies.Items.Clear();
            string[] items = Directory.GetFiles(".\\Plugins", "*.dll");
            foreach (string item in items)
            {
                cbAssemblies.Items.Add(Path.GetFileNameWithoutExtension(item));
            }

            if (cbAssemblies.Items.Count != 0)
                cbAssemblies.SelectedIndex = 0;
        }

        private void btLoadAssembly_Click(object sender, EventArgs e)
        {
            try
            {
                currPlugin = LoadAssembly(".\\Plugins\\" + cbAssemblies.Text + ".dll");
                currPlugin.OnExecute += new EventHandler(currPlugin_OnExecute); //Subscribe to DLL Event.
                MessageBox.Show(string.Format("{0}\n{1}", currPlugin.Name, currPlugin.Description));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load DLL!\n" + ex.ToString());
            }
        }

        //Event Handler
        void currPlugin_OnExecute(object sender, EventArgs e)
        {
            MessageBox.Show("Event OnExecute triggered from DLL " + ((IPlugin)sender).Name);
        }

        private void btTestExecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Result = " + currPlugin.Execute(Convert.ToDouble(txtValue1.Text), Convert.ToDouble(txtValue2.Text)));
            txtResult.Text = currPlugin.GetLastResult.ToString();
        }

        private void btException_Click(object sender, EventArgs e)
        {
            try
            {
                currPlugin.ExceptionTest("<Message from Host>");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btUnload_Click(object sender, EventArgs e)
        {
            try
            {
                UnloadAssembly(currPlugin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load DLL!\n" + ex.ToString());
            }
        }

        #endregion

    }
}
