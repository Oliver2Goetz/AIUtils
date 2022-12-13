using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUtils {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            embedVAMemoryDll();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AIUtils());
        }

        private static void embedVAMemoryDll() {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) => {
                String resourceName = "AIUtils.VAMemory.dll";
                using(var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)) {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return System.Reflection.Assembly.Load(assemblyData);
                }
            };
        }
    }
}
