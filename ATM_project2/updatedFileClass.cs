using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_project2
{
    class updatedFileClass
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;  // Reference variable of type SW
        private int recordWrittenCount;

        public updatedFileClass(string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                            "Output File Connection Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // end constructor

        public void putNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IO error in file write. Terminate program.", "File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            recordWrittenCount += 1;
        }

        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        }

        public void closeFile()
        {
            updatedFileSW.Close();
        }

        public void rewindFile()
        {

        }
    }
}