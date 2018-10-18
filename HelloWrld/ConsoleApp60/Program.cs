﻿//6. 괄호 채워 주세요

//[c:\GitHub\process.log 파일의 내용]
//Process() begin
//Process() end
 
 
using System;
using System.IO;
 
namespace Akadia.SimpleDelegate
{
    public class MyClass
    {
        public delegate void LogHandler(string message);
        public void Process(LogHandler logHandler)
        {
                logHandler.Invoke("Process() begin");
                logHandler.Invoke("Process() end");
            
        }
    }

    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;

        // Constructor
        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }

        // Member Function which is used in the Delegate
        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }

    public class TestApplication
    {
        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger("c:\\GitHub\\process.log");

            MyClass myClass = new MyClass();

            MyClass.LogHandler myLogger = fl.Logger;
            myClass.Process(myLogger);
            fl.Close();
        }
    }
}