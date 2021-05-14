using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample.ValueObj
{
    public enum OutputType
    {
        /// <summary>
        /// Log escrito no Console
        /// </summary>
        Console = 1,
        /// <summary>
        /// Log escrito em um arquivo texto (.txt)
        /// </summary>
        TxtFile = 2
    }
}
