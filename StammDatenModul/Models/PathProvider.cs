using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gehax.Core.Logging;

namespace StammDatenModul.Models;
public class PathProvider: IPathProvider
{
    public string GetBaseDirectory()
    {
        return AppDomain.CurrentDomain.BaseDirectory;
    }
}
