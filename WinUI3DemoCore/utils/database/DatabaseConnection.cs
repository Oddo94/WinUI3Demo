using System.Data;

namespace WinUI3DemoCore.utils.database {
    public interface DatabaseConnection {

        IDbConnection getConnection();
    }
}
