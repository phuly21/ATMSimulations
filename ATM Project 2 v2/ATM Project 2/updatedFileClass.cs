using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project_2
{
    public class updatedFileClass
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;   // Reference variable of type SW
        private int recordWriteCount;

        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public updatedFileClass(string filePath)
        {
            recordWriteCount = 0;
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
            } // end Try
        } // end currentFileClass 



        public void putNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
                recordWriteCount += 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("IO error in file write. Terminate program.", "File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        } // end getNextRecord

        // Get value of number of records write
        public int getRecordsWrittenCount()
        {
            return recordWriteCount;
        } // end getecordsReadCount


        // Close the input file
        public void closeFile()
        {
            updatedFileSW.Close();
        } // end Sub


        // Rewind the input file
        public void rewindFile()
        {
            recordWriteCount = 0;
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile


     

    } // end currentFileClass
}

