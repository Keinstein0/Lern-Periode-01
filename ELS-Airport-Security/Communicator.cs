using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace _ELS__Airport_Security
{
    public class Communicator
    {
        public required string sourcefile;

        public bool get_response(string input)
        {
            ScriptEngine engine = Python.CreateEngine();

            dynamic pythonScript = engine.ExecuteFile(this.sourcefile);
            dynamic calling = pythonScript.get_response;

            bool result = calling(input);

            return result;

        }

    }
}