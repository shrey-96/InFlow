/// 
/// \class Logging
/// <summary> The <c>Logging</c> class will log create a log everyday and logs the exception cases that occurred in the program with all the details.
/// For instance, an input from user caused program to misbehave, the exception will be caught for bug fixes in future.</summary>
/// <remarks>
///		<para>
///			This class contains method such as opening a log file, checking if it already exist for a particular day. Log events that weren't
///			suppose to happen and what caused them to happen. These logs will be used by developers in future to fix bugs that might occur.
///			
///		</para>
/// </remarks>
///
/// <author><i>EMS-SET Survivors</i></author>

using System;
using System.IO;
using System.Text;



namespace DataAccess
{


    public static class Logging
    {

        private static StreamWriter fileLog = null;




        /// <name>NewLog</name> 
        /// <summary>
        ///     The <c>NewLog</c> method method will take the callingMethod and triggeringEvent as parameter, write to the file
        ///     the information retrieved by the parameters in the form of a string.
        /// </summary>
        /// <param>
        ///		string callingMethod - holding the calling class and method
        ///		string TriggeringEvent - Event which triggered a log to be placed
        /// </param>
        /// 
        ///	<returns>
        ///		returns true if written successfully, false otherwise
        /// </returns>
        public static bool NewLog(string callingMethod, string triggeringEvent)
        {

            if (callingMethod.Length <= 2 || triggeringEvent.Length <= 2)
            {
                return false;
            }
            if (OpenFile() == false)
            {

                return false;

            }

            //	timeStamp			callingMethod/class			triggeringEvent
            // "YYYY-MM-DD hh:mm:ss" [Class.MethodName] event that happend - "Details"

            string newLog = GenerateTimeStamp(true); // true since we are getting the time stamp info for a new log
            newLog += callingMethod + "  " + triggeringEvent;

            fileLog.WriteLine(newLog);

            fileLog.Close();
            return true;
        }





        /// <name>GenerateLogFileName</name> 
        /// <summary>
        ///     The <c>GenerateNewLogFile</c> method will create a log file for present day.
        ///     There's a specific format of filename, it will be first generated and it will be 
        ///     made sure that it doesn't already exist, otherwise append to it. If not exist, crate it.
        /// </summary>
        /// <param>
        ///		none 
        /// </param>
        /// 
        ///	<returns>
        ///		returns string - the full file path for the current log file
        /// </returns>
        private static string GenerateLogFileName()
        {
            CreateDirectory();

            string fileName = "ems.";
            fileName += GenerateTimeStamp(false);
            string filePath = @".\DBase\" + fileName + ".log";
            return filePath;
            // check current date / store into string
            // check if file exists
            // if so append
            // else
            // create new file/overwrite file - with title titleString

        }


        // create directory
        public static bool CreateDirectory()
        {
            bool flag = true;

            try
            {
                System.IO.Directory.CreateDirectory("DBase");
            }
            catch (Exception)
            {
                flag = false;
            }

            return flag;
        }





        /// <name>GenerateTimeStamp</name> 
        /// <summary>
        ///     The <c>GenerateTimeStamp</c> method will generate the final string to be written in log file
        ///     by getting current time in specific format and concatinating it in a specific way with
        ///     class name and other attributes.
        /// </summary>
        /// <param>
        ///		string classinfo - information about the class where exception occurred.
        /// </param>
        /// 
        ///	<returns>
        ///		returns string LogInfo - final string that is to be written in log file
        /// </returns>
        private static string GenerateTimeStamp(bool newLog)
        {
            string currentTime = "";
            if (newLog == true)
            {
                // format for adding a new log
                currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            }
            else
            {
                // format for file name
                currentTime = DateTime.Now.ToString("yyyy-MM-dd");

            }


            return currentTime;
        }





        /// <name>OpenFile</name> 
        /// <summary>
        ///     The <c>OpenFile</c> method will take the filename in specific format concatinated with
        ///     today's date as parameter, and check if the file already exist, check if already opened
        ///     and if not, it'll open it and return true after opening it.
        /// </summary>
        /// <param>
        ///		string fileName - the name of log file that is to be opened
        /// </param>
        /// 
        ///	<returns>
        ///		returns bool - if sucessfully opened the file true, false otherwise
        /// </returns>
        private static bool OpenFile()
        {
            bool results = true;

            string path = GenerateLogFileName();

            if (path == null)
            {

                results = false;
                return results;

            }

            if (!File.Exists(path))
            {
                // Create a file to write to.


                try
                {

                    File.Create(path);
                    // create the new file and open it for writing
                    FileStream fLog = new FileStream(path, FileMode.Append, FileAccess.Write);
                    fileLog = new StreamWriter(fLog);

                }
                catch (IOException e)
                {

                    Logging.NewLog("Openfile", "Critical Error with log file: " + e);

                }

            }
            else
            {
                try
                {

                    FileStream fLog = new FileStream(path, FileMode.Append, FileAccess.Write);
                    fileLog = new StreamWriter(fLog);

                }
                catch (IOException e)
                {

                    Logging.NewLog("OpenFile", "Critical Error with log file: " + e);

                }

            }

            if (fileLog != null)
            {

                results = true;

            }
            else
            {
                results = false;
            }

            return results;
            // check if file exsits
            // check if file is already open
            // return fileHandler
        }





        /// <name>CloseFile</name> 
        /// <summary>
        ///     The <c>CloseFile</c> method check if file exist, checks if it is open, close it
        ///     if it is open, and raise flag to false if it is either not open or doesn't exist 
        ///     and return the flag
        /// </summary>
        /// <param>
        ///		string filename - the name of the file to be closed
        /// </param>
        /// 
        ///	<returns>
        ///		returns true if closed, false otherwise
        /// </returns>
        private static bool CloseFile(string fileName)
        {
            bool results = true;
            // check file is exsists
            // make sure file is open
            // close if open
            return results;
        }


    }

}