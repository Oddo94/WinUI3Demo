using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3DemoCore.utils.database {
    public interface DatabaseConnection {

        IDbConnection getConnection();
    }
}
